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
using System.Collections.Generic;

namespace SMSEditor.Data
{
    /// <summary>
    /// Utility class that combines palettes, tilesets, and tilemaps, as they are represented within the game
    /// </summary>
    [Serializable]
    public class Sprite : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int BGPaletteID { get; set; } = -1;                      // Background palette ID for this Sprite
        public int SPRPaletteID { get; set; } = -1;                     // Sprite palette ID for this Sprite
        public List<int> TilemapIDs { get; set; } = new List<int>();    // Tilemaps for the Sprite (Frames)

        /// <summary>
        /// Consrtuctors
        /// </summary>
        public Sprite() { }
        public Sprite(string name) { Name = name; }
        public Sprite(string name, int bgPaletteID, int sprPaletteID, List<int> tilemapIds)
        {
            Name = name;
            BGPaletteID = bgPaletteID;
            SPRPaletteID = sprPaletteID;
            TilemapIDs = tilemapIds;
        }

        /// <summary>
        /// Creates deep copy
        /// </summary>
        /// <returns>Graphic copy/returns>
        public Sprite Clone()
        {
            return (Sprite)MemberwiseClone();
        }

        /// <summary>
        /// Gets asset information
        /// </summary>
        /// <param name="frame">The currently selected tilemap (frame)</param>
        /// <param name="tilesetID">The tileset of the selected tilemap</param>
        /// <returns></returns>
        public override string GetInfo()
        {
            return "ID: " + ID + " | BG Palette: " + BGPaletteID + " (" + BGPaletteID.ToString("X") + ") | SPR Palette: " + SPRPaletteID + " (" + SPRPaletteID.ToString("X") + ")";
        }
    }
}
