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
    [Serializable]
    public class PixelTile
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TilesetID { get; set; } = -1;                  // TilesetID for the pixel tile
        public List<int> Pixels { get; set; } = new List<int>();  // Pixel data
        public bool UseBGPalette { get; set; } = true;            // If using the background palette or sprite palette

        public PixelTile() { }
        public PixelTile(int tilesetID, int[] pixels) { TilesetID = tilesetID; Pixels = new List<int>(pixels); }
        public PixelTile(int tilesetID, List<int> pixels) { TilesetID = tilesetID; Pixels = pixels; }
    }
}
