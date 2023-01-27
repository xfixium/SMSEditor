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
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    /// <summary>
    /// Tilemap object that holds the tile data, be aware that not all tilemaps have tile attribute data
    /// </summary>
    [Serializable]
    public class Tilemap : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int SpriteID { get; set; } = -1;                                 // Optional sprite id, if creating alternates using the same asset
        public int Count { get { return Columns * Rows; } }                     // The number of tiles
        public int Columns { get; set; } = 8;                                   // The number of columns
        public int Rows { get; set; } = 8;                                      // The number of rows
        public byte[] Bounds { get; set; } = new byte[] { 0, 0, 0, 0 };         // Bounding position offset rectangle
        public bool UseTileAttributes { get; set; } = false;                    // If the tilemap tiles use attribute flags
        public bool PlaceHolder { get; set; } = false;                          // If the tilemap is a placeholder for the tileset
        public bool VerticalOrientation { get; set; } = false;                  // If the tilemap data is stored in a vertical orientation
        public int TilesetID { get; set; } = -1;                                // The tileset for this tilemap
        public int BGPaletteID { get; set; } = -1;                              // The display BG palette
        public int SPRPaletteID { get; set; } = -1;                             // The display SPR palette
        public Size Size { get { return new Size(Columns * 8, Rows * 8); } }    // The size of the tilemap in pixels
        public List<Tile> Tiles { get; set; } = new List<Tile>();               // Tilemap tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public Tilemap() { SetAssetProperties(); }
        public Tilemap(string name) { Name = name; SetAssetProperties(); }
        public Tilemap(int id, int tilesetID, string name, int columns, int rows, bool useTileAttributes = false, int offset = 0,
            CompressionType compression = CompressionType.None, int length = 0, int padding = 0)
        {
            ID = id;
            Name = name;
            TilesetID = tilesetID;
            Columns = columns;
            Rows = rows;
            Length = compression == CompressionType.None ? columns * rows * (useTileAttributes ? 2 : 1) : length;
            UseTileAttributes = useTileAttributes;
            Offset = offset;
            CompressionType = compression;
            SetAssetProperties();
        }
        public Tilemap(int id, int tilesetID, string name, int columns, int rows, byte[] bounds, bool useTileAttributes = false, int offset = 0, 
            CompressionType compression = CompressionType.None, int length = 0)
        {
            ID = id;
            Name = name;
            TilesetID = tilesetID;
            Columns = columns;
            Rows = rows;
            Length = compression == CompressionType.None ? columns * rows * (useTileAttributes ? 2 : 1) : length;
            Bounds = bounds;
            UseTileAttributes = useTileAttributes;
            Offset = offset;
            CompressionType = compression;
            SetAssetProperties();
        }

        /// <summary>
        /// Updates the tilemap with the given tilemap
        /// </summary>
        /// <param name="tilemap">The tilemap to update with</param>
        public void Update(Tilemap tilemap)
        {
            Name = tilemap.Name;
            Length = tilemap.Length;
            Offset = tilemap.Offset;
            ActualLength = tilemap.ActualLength;
            CompressionType = tilemap.CompressionType;
            Columns = tilemap.Columns;
            Rows = tilemap.Rows;
            TilesetID = tilemap.TilesetID;
            Bounds = tilemap.Bounds;
            UseTileAttributes = tilemap.UseTileAttributes;
        }

        /// <summary>
        /// Tiles for the purpose of displaying a tileset for
        /// </summary>
        public void SetPlaceholderTiles()
        {
            Tiles.Clear();
            for (int i = 0; i < Count; i++)
                Tiles.Add(new Tile(i + Offset));
        }

        /// <summary>
        /// Sets default properties
        /// </summary>
        public void SetAssetProperties()
        {
            if (AssetProperties == null)
                AssetProperties = new List<AssetProperty>();

            AssetProperties.Clear();
            AssetProperties.Add(new AssetProperty("Columns", -1, (byte)Columns, false, false));
            AssetProperties.Add(new AssetProperty("Rows", -1, (byte)Rows, false, false));
            AssetProperties.Add(new AssetProperty("Bounds X0", -1, Bounds[1], false, false));
            AssetProperties.Add(new AssetProperty("Bounds Y0", -1, Bounds[0], false, false));
            AssetProperties.Add(new AssetProperty("Bounds X1", -1, Bounds[3], false, false));
            AssetProperties.Add(new AssetProperty("Bounds Y1", -1, Bounds[2], false, false));
        }

        /// <summary>
        /// Sets default properties
        /// </summary>
        public void SetAssetProperties(List<AssetProperty> properties)
        {
            if (AssetProperties == null)
                return;

            foreach (AssetProperty property in properties)
            {
                int index = AssetProperties.FindIndex(x => x.Name == property.Name);
                if (index == -1)
                    continue;

                AssetProperties[index] = property;
            }
        }

        /// <summary>
        /// Shifts all the tiles by the given amount
        /// </summary>
        /// <param name="amount">Amount to shift</param>
        public void ShiftTiles(int amount)
        {
            ShiftTiles(amount, 0);
        }

        /// <summary>
        /// Shifts all the tiles by the given amount
        /// </summary>
        /// <param name="amount">Amount to shift</param>
        /// <param name="index">Shift tiles that are greater than or equal to the given index</param>
        public void ShiftTiles(int amount, int index)
        {
            foreach (Tile tile in Tiles)
                if (tile.TileID >= index + Offset)
                    tile.TileID += amount;
        }

        /// <summary>
        /// Replaces a given target id, with the source id
        /// </summary>
        /// <param name="sourceID">The new tile id</param>
        /// <param name="targetID">The tile id to replace</param>
        public void ReplaceTiles(int sourceID, int targetID)
        {
            foreach (Tile tile in Tiles)
                if (tile.TileID == targetID)
                    tile.TileID = sourceID;
        }

        /// <summary>
        /// Gets the tile id from the given bytes (9 bit value)
        /// </summary>
        /// <param name="byte1">The upper byte</param>
        /// <param name="byte2">The lower byte</param>
        /// <returns></returns>
        public static int GetTileID(byte byte1, byte byte2)
        {
            bool[] bits = new bool[9];
            bits[0] = (byte1 & (1 << 0)) != 0;
            bits[1] = (byte1 & (1 << 1)) != 0;
            bits[2] = (byte1 & (1 << 2)) != 0;
            bits[3] = (byte1 & (1 << 3)) != 0;
            bits[4] = (byte1 & (1 << 4)) != 0;
            bits[5] = (byte1 & (1 << 5)) != 0;
            bits[6] = (byte1 & (1 << 6)) != 0;
            bits[7] = (byte1 & (1 << 7)) != 0;
            bits[8] = (byte2 & (1 << 0)) != 0;
            int[] result = new int[1];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0];
        }

        /// <summary>
        /// Gets tile attribute flags (0 = false, 1 = true)
        /// </summary>
        /// <param name="byte1">The byte to retrieve flag bits from</param>
        /// <returns>A string representation of the tile data</returns>
        public static string GetTileFlags(byte byte1)
        {
            string flags = "";
            flags += (byte1 & (1 << 1)) != 0 ? "1" : "0"; // X flip
            flags += (byte1 & (1 << 2)) != 0 ? "1" : "0"; // Y flip
            flags += (byte1 & (1 << 3)) != 0 ? "1" : "0"; // Palette index
            flags += (byte1 & (1 << 4)) != 0 ? "1" : "0"; // Priority
            return flags == "0000" ? string.Empty : flags;
        }

        /// <summary>
        /// Gets two bytes whcih represent the tile attributes, and the tile id
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        public static byte[] GetTileBytes(Tile tile)
        {
            int id = tile.TileID;
            bool[] bits = new bool[16];
            bits[0] = (id & (1 << 0)) != 0;
            bits[1] = (id & (1 << 1)) != 0;
            bits[2] = (id & (1 << 2)) != 0;
            bits[3] = (id & (1 << 3)) != 0;
            bits[4] = (id & (1 << 4)) != 0;
            bits[5] = (id & (1 << 5)) != 0;
            bits[6] = (id & (1 << 6)) != 0;
            bits[7] = (id & (1 << 7)) != 0;
            bits[8] = (id & (1 << 8)) != 0;
            bits[9] = tile.FlipX;
            bits[10] = tile.FlipY;
            bits[11] = !tile.UseBGPalette;
            bits[12] = tile.Priority;
            bits[13] = false;
            bits[14] = false;
            bits[15] = false;
            byte[] result = new byte[2];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string GetInfo(List<GameAsset> assets)
        {
            int length = GetTilemapData(false, false, true).Length;
            int actualLength = ActualLength / (UseTileAttributes ? 2 : 1);
            return "ID: " + DataStartString + " | Tile Count: " + Tiles.Count + "/" + actualLength + " tiles | Length: " + length + "/" + Length + " bytes | Compression: " + EnumMethods.GetDescription(CompressionType) + " | Offset: " + Offset;
        }

        /// <summary>
        /// Sets asset status
        /// </summary>
        public override void SetStatus(List<GameAsset> assets)
        {
            int length = GetTilemapData(false, false, true).Length;
            StatusType = Disable ? StatusType.Disabled : Length < length ? StatusType.Overflow : StatusType.Good;
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex, bool over)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Rows; row++)
            {
                string line = hex ? "" : UseTileAttributes ? ".dw " : ".db ";
                for (int col = 0; col < Columns; col++)
                {
                    byte b = (byte)Tiles[row * Columns + col].TileID;
                    byte[] bytes = GetTileBytes(Tiles[row * Columns + col]);
                    line += (hex ? "" : "$") + (UseTileAttributes ? bytes[1].ToString("X2") + (hex ? " " : "") + bytes[0].ToString("X2") : b.ToString("X2")) + " ";
                }
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets tilemap data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="pad">Padding with zeros, if the data is smaller than the original</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetTilemapData(bool getRawData, bool pad, bool over)
        {
            List<byte> bytes = new List<byte>();
            if (UseTileAttributes)
                foreach (Tile tile in Tiles)
                    bytes.AddRange(GetTileBytes(tile));
            else
                foreach (Tile tile in Tiles)
                    bytes.Add((byte)tile.TileID);

            return getRawData ? bytes.ToArray() : GetExportData(bytes, pad, over);
        }
    }
}
