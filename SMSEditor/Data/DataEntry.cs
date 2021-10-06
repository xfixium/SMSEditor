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
    /// Data entry object, this allows for cutom data injection into the ROM
    /// </summary>
    [Serializable]
    public class DataEntry : GameAsset
    {
        public bool Overwrite { get; set; } = true;               // If overwriting data at the data entry's position, or inserting it
        public List<byte> Data { get; set; } = new List<byte>();  // Data to write
        public string Comments { get; set; } = string.Empty;      // Comments for the data entry

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string GetInfo(List<GameAsset> assets)
        {
            return "ID: " + ID + " | " + Data.Count + " byte(s) | Overwrite: " + (Overwrite ? "Yes" : "No") + " | Disabled: " + (Disable ? "Yes" : "No");
        }

        /// <summary>
        /// Sets asset status
        /// </summary>
        public override void SetStatus(List<GameAsset> assets)
        {
            StatusType = Disable ? StatusType.Disabled : StatusType.Good;
        }
    }
}
