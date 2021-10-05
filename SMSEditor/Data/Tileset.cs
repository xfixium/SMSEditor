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
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    /// <summary>
    /// Tileset object that holds the raw pixel data making up a graphic, represented by 8 x 8 tiles.
    /// Note: When tileset pixel data is imported, it is represented by a whole byte in this object.
    /// The typical format of a single pixel for SMS is stored as 4bpp (Nibble 0BGR). Although 
    /// technically 3bpp, the first bit is not used. An 8 x 8 tile is stored in the ROM is 32 bytes in size
    /// Versus the 64 bytes it becomes when imported into this object.
    /// </summary>
    [Serializable]
    public class Tileset : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int SpriteID { get; set; } = -1;                                             // Optional sprite id, if creating alternates using the same asset
        public int TileCount { get { return Pixels.Count <= 0 ? 0 : Pixels.Count / 64; } }  // The number of 8 x 8 tiles the tileset has
        public int PaletteID { get; set; } = -1;                                            // The display palette
        public bool Masked { get; set; } = false;                                           // If the pixel data is offset by 2 times the value, except when the value is zero
        public List<byte> Pixels { get; set; } = new List<byte>();                          // The raw pixel data, the byte value will be an index of 0 - 15 (16 colors)

        /// <summary>
        /// Constructors
        /// </summary>
        public Tileset() { }
        public Tileset(int id) { ID = id; }
        public Tileset(string name) { Name = name; }
        public Tileset(int id, string name, int length)
        {
            ID = id;
            Name = name;
            Length = length;
        }
        public Tileset(int id, string name, int length, int offset = 0, int padding = 0)
        {
            ID = id;
            Name = name;
            Length = length;
            Offset = offset;
        }
        public Tileset(int id, string name, int length, int offset = 0, bool masked = false)
        {
            ID = id;
            Name = name;
            Length = length;
            Offset = offset;
            Masked = masked;
        }
        public Tileset(int id, string name, int length, int offset = 0, CompressionType compression = CompressionType.None, bool masked = false)
        {
            ID = id;
            Name = name;
            Length = length;
            Offset = offset;
            CompressionType = compression;
            Masked = masked;
        }

        /// <summary>
        /// Updates the tileset with the given tileset
        /// </summary>
        /// <param name="tileset">The tileset to update with</param>
        public void Update(Tileset tileset)
        {
            Name = tileset.Name;
            Length = tileset.Length;
            Offset = tileset.Offset;
            ActualLength = tileset.ActualLength;
            CompressionType = tileset.CompressionType;
            PaletteID = tileset.PaletteID;
            Masked = tileset.Masked;
        }

        /// <summary>
        /// Gets a pixel color index (4bpp planar)
        /// </summary>
        /// <param name="bitPlanes">The bit planes to combine into a color index</param>
        /// <param name="bit">The bit we're combining</param>
        /// <returns>A single pixel color index</returns>
        public static byte GetPixel(byte[] bitPlanes, int bit)
        {
            bool[] bits = new bool[4];
            bits[0] = (bitPlanes[0] & (1 << bit)) != 0;
            bits[1] = (bitPlanes[1] & (1 << bit)) != 0;
            bits[2] = (bitPlanes[2] & (1 << bit)) != 0;
            bits[3] = (bitPlanes[3] & (1 << bit)) != 0;
            byte[] result = new byte[1];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0];
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string GetInfo()
        {
            int length = GetTilesetData(false, false).Length;
            StatusType = TileCount < length / 32 || Length < length ? StatusType.Overflow : StatusType.Good;
            return "ID: " + DataStartString + " | Tile Count: " + TileCount + "/" + ActualLength / 32 + " tiles | Length: " + length + "/" + Length + " bytes | Compression: " + EnumMethods.GetDescription(CompressionType) + " | Offset: " + Offset;
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString()
        {
            StringBuilder sb = new StringBuilder();
            byte[] data = GetTilesetData(true, false);
            for (int i = 0; i < data.Length / 32; i++)
            {
                sb.AppendLine("; Tile index $" + i.ToString("X3"));
                string line = ".db ";
                for (int j = 0; j < 32; j++)
                    line += "$" + data[i * j + j].ToString("X2") + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Prefixes an empty tile to the tileset
        /// </summary>
        public void AddEmptyTile()
        {
            for (int i = 0; i < 64; i++)
                Pixels.Insert(0, 0);
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id. 
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <returns>A tile's worth of pixel data</returns>
        public List<byte> GetTilePixels(int tileID)
        {
            return Pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id. 
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <returns>A tile's worth of pixel data</returns>
        public void SetTilePixels(int tileID, List<byte> pixels)
        {
            int index = 0;
            int count = tileID * 64 + 64;
            for (int i = tileID * 64; i < count; i++)
            {
                Pixels[i] = pixels[index];
                index++;
            }
        }

        /// <summary>
        /// Swaps out target color with selected color
        /// </summary>
        /// <param name="target">Color to swap</param>
        /// <param name="source">Replacement color</param>
        public void SwapPixels(byte target, byte source)
        {
            for (int i = 0; i < Pixels.Count; i++)
                if (Pixels[i] == target)
                    Pixels[i] = source;
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <param name="pixels">The list of pixels to get the pixel data from</param>
        /// <returns>A tile's worth of pixel data</returns>
        public static List<byte> GetTilePixels(int tileID, List<byte> pixels)
        {
            return pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Gets the edit data in bytes
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="pad">Padding with zeros, if the data is smaller than the original</param>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetTilesetData(bool getRawData, bool pad)
        {
            List<byte> bytes = new List<byte>();
            List<byte> pixels = new List<byte>();

            pixels.AddRange(Pixels.ToArray());
            if (Masked)
            {
                for (int i = 0; i < pixels.Count; i++)
                    pixels[i] = pixels[i] == 0 ? (byte)1 : (byte)(pixels[i] * 2);
            }
            for (int i = 0; i < pixels.Count; i += 8)
            {
                List<bool[]> row = new List<bool[]>();
                for (int j = 0; j < 8; j++)
                    row.Add(GetPlaneBits(pixels[i + j]));

                for (int k = 0; k < 4; k++)
                {
                    int index = 7;
                    byte[] value = new byte[1];
                    bool[] bits = new bool[8];
                    for (int l = 0; l < 8; l++)
                    {
                        bits[l] = row[index][k];
                        index--;
                    }
                    BitArray arr = new BitArray(bits);
                    arr.CopyTo(value, 0);
                    bytes.Add(value[0]);
                }
            }
            return getRawData ? bytes.ToArray() : GetExportData(bytes, pad);
        }

        /// <summary>
        /// Gets bits of the given color index byte
        /// </summary>
        /// <param name="value">The color index value (0 - 15)</param>
        /// <returns>A bit array representing a color index value</returns>
        private static bool[] GetPlaneBits(byte value)
        {
            switch (value)
            {
                case 1: return new bool[] { true, false, false, false };
                case 2: return new bool[] { false, true, false, false };
                case 3: return new bool[] { true, true, false, false };
                case 4: return new bool[] { false, false, true, false };
                case 5: return new bool[] { true, false, true, false };
                case 6: return new bool[] { false, true, true, false };
                case 7: return new bool[] { true, true, true, false };
                case 8: return new bool[] { false, false, false, true };
                case 9: return new bool[] { true, false, false, true };
                case 10: return new bool[] { false, true, false, true };
                case 11: return new bool[] { true, true, false, true };
                case 12: return new bool[] { false, false, true, true };
                case 13: return new bool[] { true, false, true, true };
                case 14: return new bool[] { false, true, true, true };
                case 15: return new bool[] { true, true, true, true };
                default: return new bool[] { false, false, false, false };
            }
        }
    }
}
