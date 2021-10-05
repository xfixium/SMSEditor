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

namespace SMSEditor.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class Tile
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get; set; }                     // 9 bit tile index max value of 512
        public bool UseBGPalette { get; set; } = true;      // If using the background palette or sprite palette
        public bool Priority { get; set; } = false;         // If drawn in front of sprite or behind
        public bool FlipX { get; set; } = false;            // If flipped horizontally
        public bool FlipY { get; set; } = false;            // If flipped vertically
        public bool Bit14 { get; set; } = false;            // Unused bit 14
        public bool Bit15 { get; set; } = false;            // Unused bit 15
        public bool Bit16 { get; set; } = false;            // Unused bit 16
        public string Flags { get; set; } = "";             // Quality of life string, used to display the flags on a tile

        /// <summary>
        /// Constructors
        /// </summary>
        public Tile() { }
        public Tile(int tileID) { TileID = tileID; }
        public Tile(int tileID, FlipType flipType)
        {
            TileID = tileID;
            switch (flipType)
            {
                case FlipType.Horizontal: FlipX = true; break;
                case FlipType.Vertical: FlipY = true; break;
                case FlipType.Both: FlipX = true; FlipY = true; break;
                default: break;
            }
        }

        /// <summary>
        /// Creates clone
        /// </summary>
        /// <returns>Tile copy/returns>
        public Tile Clone()
        {
            return (Tile)MemberwiseClone();
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string ToString()
        {
            string palette = UseBGPalette ? "Background" : "Sprite";
            return "ID: " + TileID.ToString() + " | HFlip: " + FlipX + " | VFlip: " + FlipY + " | Priority: " + Priority + " | Palette: " + palette +
                " | Bit 14: " + Bit14 + " | Bit 15: " + Bit15 + " | Bit 16: " + Bit16;
        }
    }
}
