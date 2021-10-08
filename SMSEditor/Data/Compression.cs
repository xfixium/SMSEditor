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

using System.Linq;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    public class Compression
    {
        /// <summary>
        /// Compresses the given bytes using the given compression type
        /// </summary>
        /// <param name="type">Compression type to use</param>
        /// <param name="bytes">The bytes to compress</param>
        /// <returns>A compressed byte array</returns>
        public static byte[] Compress(CompressionType type, byte[] bytes)
        {
            switch (type)
            {
                case CompressionType.PSRLELinear: { return CompressPSRLELinear(bytes); }
                case CompressionType.PSRLEPlanar2: { return CompressPSRLEPlanar2(bytes); }
                case CompressionType.PSRLEPlanar4: { return CompressPSRLEPlanar4(bytes); }
                default: return bytes;
            }
        }

        /// <summary>
        /// Decompresses the given bytes using the given compression type
        /// </summary>
        /// <param name="type">Decompression type to use</param>
        /// <param name="bytes">The bytes to decompression</param>
        /// <returns>A decompression byte array</returns>
        public static byte[] Decompress(CompressionType type, byte[] bytes)
        {
            switch (type)
            {
                case CompressionType.PSRLELinear: { return DecompressPSRLELinear(bytes); }
                case CompressionType.PSRLEPlanar2: { return DecompressPSRLEPlanar4(bytes); }
                case CompressionType.PSRLEPlanar4: { return DecompressPSRLEPlanar4(bytes); }
                default: return bytes;
            }
        }

        public static byte[] CompressPSRLELinear(byte[] data)
        {
            List<byte[]> planes = new List<byte[]>();
            planes.Add(data.ToArray());
            return PSRLECompress(planes);
        }

        public static byte[] CompressPSRLEPlanar4(byte[] data)
        {
            List<byte[]> planes = new List<byte[]>();
            for (int i = 0; i < 4; i++)
                planes.Add(new byte[data.Length / 4]);

            int index = 0;
            for (int j = 0; j < data.Length / 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (j < planes[k].Length)
                        planes[k][j] = data[index];

                    index++;
                }
            }
            return PSRLECompress(planes);
        }

        public static byte[] CompressPSRLEPlanar2(byte[] data)
        {
            int length = data.Length / 2;
            List<byte[]> planes = new List<byte[]>();
            for (int i = 0; i < 2; i++)
                planes.Add(new byte[length]);

            int index = 0;
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (j < planes[k].Length)
                        planes[k][j] = data[index];

                    index++;
                }
            }
            return PSRLECompress(planes);
        }

        private static byte[] PSRLECompress(List<byte[]> planes)
        {
            List<byte> compressed = new List<byte>();
            foreach (byte[] plane in planes)
            {
                int mode = 0; // No run = 0, run = 1, raw = 2
                List<byte> buffer = new List<byte>();
                List<Block> blocks = new List<Block>();
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
                            blocks.Add(new Block(false, buffer.DeepClone()));
                            buffer.Clear();
                            buffer.Add(plane[i]);
                            mode = 0;
                        }
                    }
                    else if (mode == 2)
                    {
                        if (plane[i] == buffer[buffer.Count - 1])
                        {
                            blocks.Add(new Block(true, buffer.DeepClone().GetRange(0, buffer.Count - 1)));
                            buffer.Clear();
                            buffer.AddRange(new byte[] { plane[i], plane[i] });
                            mode = 1;
                        }
                        else
                            buffer.Add(plane[i]);
                    }
                }

                blocks.Add(new Block(mode != 1, buffer.DeepClone()));

                for (int i = 1; i < blocks.Count;)
                {
                    if ((blocks[i - 1].Raw && !blocks[i].Raw && blocks[i].Data.Count == 2) ||
                        (blocks[i - 1].Raw && blocks[i].Raw) ||
                        (!blocks[i - 1].Raw && blocks[i - 1].Data.Count == 2 && blocks[i].Raw))
                    {
                        if (blocks[i - 1].Data.Count + blocks[i].Data.Count >= 127)
                            i++;
                        else
                        {
                            blocks[i - 1].Data.AddRange(blocks[i].Data.DeepClone());
                            blocks[i - 1].Raw = true;
                            blocks.RemoveAt(i);
                        }
                    }
                    else
                        i++;
                }

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (Block block in blocks)
                {
                    if (block.Data.Count <= 0)
                        continue;

                    if (block.Raw)
                    {
                        compressed.Add((byte)(block.Data.Count + 128));
                        compressed.AddRange(block.Data);
                    }
                    else
                    {
                        compressed.Add((byte)(block.Data.Count));
                        compressed.Add(block.Data[0]);
                    }

                    sb.AppendLine(block.ToString());
                }

                compressed.Add(0);
            }

            return compressed.ToArray();
        }

        public static byte[] DecompressPSRLEPlanar4(byte[] data)
        {
            int index = 0;
            int count;
            byte value;
            List<byte>[] bitPlanes = new List<byte>[4];
            for (int i = 0; i < 4; i++)
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
                for (int k = 0; k < 4; k++)
                    if (j < bitPlanes[k].Count)
                        decompressed.Add(bitPlanes[k][j]);

            return decompressed.ToArray();
        }

        public static byte[] DecompressPSRLELinear(byte[] data)
        {
            List<byte> decompressed = new List<byte>();
            int index = 0;
            int count;
            byte value;
            while (index < data.Length && data[index] != 0)
            {
                if (data[index] < 128)
                {
                    count = data[index];
                    index++;
                    value = data[index];
                    index++;
                    for (int j = 0; j < count; j++)
                        decompressed.Add(value);
                }
                else
                {
                    count = data[index] - 128;
                    index++;
                    for (int j = 0; j < count; j++)
                    {
                        value = data[index];
                        decompressed.Add(value);
                        index++;
                    }
                }
            }
            return decompressed.ToArray();
        }

        public class Block
        {
            public bool Raw { get; set; }
            public List<byte> Data { get; set; } = new List<byte>();

            public Block(bool raw, List<byte> data)
            {
                Raw = raw;
                Data.AddRange(data.ToArray());
            }
        };
    }
}
