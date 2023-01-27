// 
// SMS Editor
// Copyright (C) 2021 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Linq;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    public class Compression
    {
        /// <summary>
        /// Compresses the given data with the given compression type
        /// </summary>
        /// <param name="type"> The type of compression to use</param>
        /// <param name="data">The data to compress</param>
        /// <returns>Compressed data</returns>
        public static byte[] Compress(CompressionType type, byte[] data)
        {
            switch (type)
            {
                case CompressionType.PSRLELinear: { return CompressPSRLE(data, 1); }
                case CompressionType.PSRLEPlanar2: { return CompressPSRLE(data, 2); }
                case CompressionType.PSRLEPlanar4: { return CompressPSRLE(data, 4); }
                case CompressionType.Sonic1: { return CompressSonic1(data); }
                default: return data;
            }
        }

        /// <summary>
        /// Decompresses the given data with the given compression type
        /// </summary>
        /// <param name="type"> The type of compression to use</param>
        /// <param name="data">The data to decompress</param>
        /// <returns>Decompressed data</returns>
        public static byte[] Decompress(CompressionType type, byte[] data)
        {
            switch (type)
            {
                case CompressionType.PSRLELinear: { return DecompressPSRLE(data, 1); }
                case CompressionType.PSRLEPlanar2: { return DecompressPSRLE(data, 2); }
                case CompressionType.PSRLEPlanar4: { return DecompressPSRLE(data, 4); }
                case CompressionType.Sonic1: { return DecompressSonic1(data); }
                default: return data;
            }
        }

        /// <summary>
        /// Compresses the given data planes, using Phantasy Star RLE compression
        /// </summary>
        /// <param name="data">The data to compress</param>
        /// <param name="planeCount">Number of planes to interleave</param>
        /// <returns></returns>
        private static byte[] CompressPSRLE(byte[] data, int planeCount)
        {
            int length = data.Length / planeCount;
            List<byte[]> planes = new List<byte[]>();
            for (int i = 0; i < planeCount; i++)
                planes.Add(new byte[length]);

            int index = 0;
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < planeCount; k++)
                {
                    if (j < planes[k].Length)
                        planes[k][j] = data[index];

                    index++;
                }
            }

            List<byte> compressed = new List<byte>();
            foreach (byte[] plane in planes)
            {
                int mode = 0; // No run = 0, run = 1, raw = 2
                List<byte> buffer = new List<byte>();
                List<Tuple<bool, List<byte>>> blocks = new List<Tuple<bool, List<byte>>>();
                for (int i = 0; i < plane.Length; i++)
                {
                    if (buffer.Count < 2)
                    {
                        buffer.Add(plane[i]);
                        continue;
                    }

                    if (mode == 0)
                        mode = buffer.Distinct().Count() == 1 ? 1 : 2;

                    if (mode == 1)
                    {
                        if (plane[i] == buffer[buffer.Count - 1] && buffer.Count < 127)
                            buffer.Add(plane[i]);
                        else
                        {
                            blocks.Add(new Tuple<bool, List<byte>>(false, buffer.DeepClone()));
                            buffer.Clear();
                            buffer.Add(plane[i]);
                            mode = 0;
                        }
                    }
                    else if (mode == 2)
                    {
                        if (plane[i] == buffer[buffer.Count - 1])
                        {
                            blocks.Add(new Tuple<bool, List<byte>>(true, buffer.DeepClone().GetRange(0, buffer.Count - 1)));
                            buffer.Clear();
                            buffer.AddRange(new byte[] { plane[i], plane[i] });
                            mode = 1;
                        }
                        else
                            buffer.Add(plane[i]);
                    }
                }

                blocks.Add(new Tuple<bool, List<byte>>(mode != 1, buffer.DeepClone()));

                for (int i = 1; i < blocks.Count;)
                {
                    if ((blocks[i - 1].Item1 && !blocks[i].Item1 && blocks[i].Item2.Count == 2) ||
                        (blocks[i - 1].Item1 && blocks[i].Item1) ||
                        (!blocks[i - 1].Item1 && blocks[i - 1].Item2.Count == 2 && blocks[i].Item1))
                    {
                        if (blocks[i - 1].Item2.Count + blocks[i].Item2.Count >= 127)
                            i++;
                        else
                        {
                            blocks[i - 1].Item2.AddRange(blocks[i].Item2.DeepClone());
                            blocks[i - 1] = new Tuple<bool, List<byte>>(true, blocks[i - 1].Item2);
                            blocks.RemoveAt(i);
                        }
                    }
                    else
                        i++;
                }

                foreach (Tuple<bool, List<byte>> block in blocks)
                {
                    if (block.Item2.Count <= 0)
                        continue;

                    if (block.Item2.Count >= 127)
                    {
                        var sets = Math.Ceiling((decimal)((decimal)block.Item2.Count / (decimal)128));
                        for (int i = 0; i < sets; i++)
                        {
                            int count = block.Item2.Count < 127 ? block.Item2.Count : 127;
                            List<byte> bytes = block.Item2.GetRange(0, count);
                            block.Item2.RemoveRange(0, count);
                            if (block.Item1)
                            {
                                compressed.Add((byte)(bytes.Count == 127 ? 255 : bytes.Count + 128));
                                compressed.AddRange(bytes);
                            }
                            else
                            {
                                compressed.Add((byte)(bytes.Count));
                                compressed.Add(bytes[0]);
                            }
                        }
                        continue;
                    }

                    if (block.Item1)
                    {
                        compressed.Add((byte)(block.Item2.Count + 128));
                        compressed.AddRange(block.Item2);
                    }
                    else
                    {
                        compressed.Add((byte)(block.Item2.Count));
                        compressed.Add(block.Item2[0]);
                    }
                }

                compressed.Add(0);
            }

            return compressed.ToArray();
        }

        /// <summary>
        /// Decompresses Phantasy Star RLE compression
        /// </summary>
        /// <param name="data">The data to decompress</param>
        /// <param name="planeCount">Number of planes</param>
        /// <returns></returns>
        public static byte[] DecompressPSRLE(byte[] data, int planeCount)
        {
            int index = 0;
            int count;
            byte value;
            List<byte>[] bitPlanes = new List<byte>[planeCount];
            for (int i = 0; i < planeCount; i++)
            {
                bitPlanes[i] = new List<byte>();
                while (index < data.Length && data[index] != 0)
                {
                    if (data[index] < 128)
                    {
                        count = data[index];
                        index++;
                        value = data[index];
                        index++;
                        for (int j = 0; j < count; j++)
                            bitPlanes[i].Add(value);
                    }
                    else
                    {
                        count = data[index] - 128;
                        index++;
                        for (int j = 0; j < count; j++)
                        {
                            value = data[index];
                            bitPlanes[i].Add(value);
                            index++;
                        }
                    }
                }
                index++;
            }

            List<byte> decompressed = new List<byte>();
            for (int j = 0; j < bitPlanes[0].Count; j++)
                for (int k = 0; k < planeCount; k++)
                    if (j < bitPlanes[k].Count)
                        decompressed.Add(bitPlanes[k][j]);

            return decompressed.ToArray();
        }

        /// <summary>
        /// Converts word (unsigned short) into 2 bytes
        /// </summary>
        /// <param name="word">Word (unsigned short) to convert into 2 bytes</param>
        /// <returns>2 bytes</returns>
        private static byte[] GetWord(ushort word)
        {
            byte[] bytes = new byte[2];
            bytes[0] = (byte)((word >> 0) & 0xff);
            bytes[1] = (byte)((word >> 8) & 0xff);
            return bytes;
        }

        /// <summary>
        /// Converts 2 bytes into a word (unsigned short)
        /// </summary>
        /// <param name="word">2 bytes to convert into a word</param>
        /// <returns>A word</returns>
        private static ushort GetWord(byte[] word)
        {
            return BitConverter.ToUInt16(word, 0);
        }

        /// <summary>
        /// Converts given tile row data into an integer
        /// </summary>
        /// <param name="data">Byte values to convert to integer</param>
        /// <returns>An integer (4 bytes)</returns>
        private static int GetRow(byte[] data)
        {
            return (data[0] << 0) | (data[1] << 8) | (data[2] << 16) | (data[3] << 24);
        }

        /// <summary>
        /// Sega Master System Sonic 1 compression
        /// </summary>
        /// <param name="data">Data to compress</param>
        /// <returns>Compressed data</returns>
        private static byte[] CompressSonic1(byte[] data)
        {
            int count = data.Length / 32;
            List<int> artData = new List<int>();
            List<byte> duplicateRows = new List<byte>();
            List<byte> compressed = new List<byte>();
            compressed.AddRange(GetWord(0x5948));
            compressed.AddRange(GetWord((ushort)(count + 8)));
            compressed.AddRange(GetWord((ushort)(count * 8)));
            int point = 0;
            for (int i = 0; i < count; i++)
            {
                byte bitmask = 0;
                for (int j = 0; j < 8; j++)
                {
                    bitmask >>= 1;
                    int row = GetRow(new byte[] { data[point], data[point + 1], data[point + 2], data[point + 3] });
                    point += 4;
                    if (!artData.Any(x => x == row))
                        artData.Add(row);
                    else
                    {
                        bitmask |= 0x80;
                        ushort index = (ushort)(artData.IndexOf(row));
                        if (index >= 0xF0)
                            duplicateRows.Add((byte)((index >> 8) | 0xF0));

                        duplicateRows.Add((byte)(index));
                    }
                }
                compressed.Add(bitmask);
            }

            compressed.InsertRange(4, GetWord((ushort)(compressed.Count + duplicateRows.Count + 2)));
            compressed.AddRange(duplicateRows);
            foreach (var row in artData)
                compressed.AddRange(BitConverter.GetBytes(row));

            return compressed.ToArray();
        }

        /// <summary>
        /// Sega Master System Sonic 1 decompression
        /// </summary>
        /// <param name="data">The data to decompress</param>
        /// <returns>Decompressed data</returns>
        private static byte[] DecompressSonic1(byte[] data)
        {
            List<byte> decompressed = new List<byte>();
            var duplicateOffset = GetWord(new byte[] { data[2], data[3] });
            var artOffset = GetWord(new byte[] { data[4], data[5] });
            int artIndex = 0;
            int duplicateIndex = 0;
            for (int i = 8; i < duplicateOffset; i++)
            {
                byte row = data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((row & (1 << j)) == 0)
                    {
                        int index = artIndex + artOffset;
                        if (index >= data.Length)
                            continue;
                        decompressed.AddRange(new byte[] { data[index], data[index + 1], data[index + 2], data[index + 3] });
                        artIndex += 4;
                    }
                    else
                    {
                        int index = duplicateIndex + duplicateOffset;
                        int value = ((data[index] >= 240 ? GetWord(new byte[] { data[index + 1], (byte)(data[index] & 0x0F) }) : data[index]));
                        value = value * 4 + artOffset;
                        if (value >= data.Length)
                            continue;
                        decompressed.AddRange(new byte[] { data[value], data[value + 1], data[value + 2], data[value + 3] });
                        duplicateIndex += data[index] >= 240 ? 2 : 1;
                    }
                }
            }

            return decompressed.ToArray();
        }
    }
}
