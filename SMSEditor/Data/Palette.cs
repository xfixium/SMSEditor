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
    /// Palette object that represents colors used by the tileset (Usually 32 colors total, 16 Background, 16 Sprite) 
    /// Some data may only have 8 colors, these are typically padded to 32 colors using black, or another palette for display
    /// </summary>
    [Serializable]
    public class Palette : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int SpriteID { get; set; } = -1;                                 // Optional sprite id, if creating alternates using the same asset
        public int PartialPaletteID { get; set; } = -1;                         // Peltte id that combines with this palette at the offset 
        public List<Color> Colors { get; set; } = new List<Color>();            // Palette colors
        public static List<Color> Empty { get { return new List<Color>(); } }   // Empty colors

        /// <summary>
        /// Constructors
        /// </summary>
        public Palette() { }
        public Palette(int id) { ID = id; }
        public Palette(int id, string name, List<Color> colors) { ID = id; Name = name; Colors = colors; }
        public Palette(int id, string name, int length, int offset = 0, int partialPaletteID = -1)
        {
            ID = id;
            Name = name;
            Length = length;
            Offset = offset;
            PartialPaletteID = partialPaletteID;
        }

        /// <summary>
        /// Updates the palette with the given palette
        /// </summary>
        /// <param name="palette">The palette to update with</param>
        public void Update(Palette palette)
        {
            Name = palette.Name;
            Length = palette.Length;
            Offset = palette.Offset;
            ActualLength = palette.ActualLength;
            CompressionType = palette.CompressionType;
            PartialPaletteID = palette.PartialPaletteID;
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        public static List<Palette> GetDefaultPalettes()
        {
            List<Color> bgDefaultColors = new List<Color>();
            bgDefaultColors.Add(Color.FromArgb(255, 0, 0, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 255, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 85, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 170, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 255, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 170, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 0, 0, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 255, 170));
            bgDefaultColors.Add(Color.FromArgb(255, 170, 85, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 255, 170, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 85, 0, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 85, 255, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 0, 170, 255));
            bgDefaultColors.Add(Color.FromArgb(255, 0, 255, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 0, 170, 0));
            bgDefaultColors.Add(Color.FromArgb(255, 0, 255, 255));

            List<Color> sprDefaultColors = new List<Color>();
            sprDefaultColors.Add(Color.FromArgb(255, 13, 230, 223));
            sprDefaultColors.Add(Color.FromArgb(255, 255, 255, 255));
            sprDefaultColors.Add(Color.FromArgb(255, 85, 85, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 255, 170, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 255, 0, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 170, 0, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 0, 0, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 0, 0, 255));
            sprDefaultColors.Add(Color.FromArgb(255, 0, 255, 255));
            sprDefaultColors.Add(Color.FromArgb(255, 0, 255, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 255, 255, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 0, 170, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 170, 170, 255));
            sprDefaultColors.Add(Color.FromArgb(255, 170, 85, 255));
            sprDefaultColors.Add(Color.FromArgb(255, 85, 0, 0));
            sprDefaultColors.Add(Color.FromArgb(255, 170, 170, 0));

            List<Palette> defaultPalettes = new List<Palette>();
            defaultPalettes.Add(new Palette(-3, "BG Default", bgDefaultColors));
            defaultPalettes.Add(new Palette(-2, "SPR Default", sprDefaultColors));
            return defaultPalettes;
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        public static List<Color> GetColors(byte[] data)
        {
            List<Color> colors = new List<Color>();
            foreach (byte b in data)
                colors.Add(GetColor(b));
            return colors;
        }

        /// <summary>
        /// Gets a color from the given byte 00BBGGRR 2 bits per color channel (6 bit, first 2 bits are ignored)
        /// </summary>
        /// <param name="b">Color byte value</param>
        /// <returns>A .net color</returns>
        public static Color GetColor(byte b)
        {
            List<byte> rgb = new List<byte>();
            Dictionary<byte, byte> _colorValues = new Dictionary<byte, byte> { { 0, 0 }, { 1, 85 }, { 2, 170 }, { 3, 255 } };
            for (int i = 0; i < 6; i += 2)
            {
                byte[] channel = new byte[1];
                bool[] bits = new bool[2];
                bits[0] = (b & (1 << i)) != 0 ? true : false;
                bits[1] = (b & (1 << (i + 1))) != 0 ? true : false;
                BitArray arr = new BitArray(bits);
                arr.CopyTo(channel, 0);
                rgb.Add(channel[0]);
            }
            return Color.FromArgb(_colorValues[rgb[0]], _colorValues[rgb[1]], _colorValues[rgb[2]]);
        }

        /// <summary>
        /// Gets a 6 bit SMS color value from a .net color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetColor(Color color)
        {
            try
            {
                byte[] value = new byte[1];
                List<bool> bgr = new List<bool>();
                bgr.AddRange(GetColorBits(color.R));
                bgr.AddRange(GetColorBits(color.G));
                bgr.AddRange(GetColorBits(color.B));
                bgr.AddRange(new bool[] { false, false });
                BitArray arr = new BitArray(bgr.ToArray());
                arr.CopyTo(value, 0);
                return value[0];
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string GetInfo(List<GameAsset> assets)
        {
            return "ID: " + DataStartString + " | Length: " + Length + " bytes | Compression: " + EnumMethods.GetDescription(CompressionType) + " | Offset: " + Offset;
        }

        /// <summary>
        /// Sets asset status
        /// </summary>
        public override void SetStatus(List<GameAsset> assets)
        {
            StatusType = Disable ? StatusType.Disabled : StatusType.Good;
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex, bool over)
        {
            StringBuilder sb = new StringBuilder();
            if (!hex)
                sb.Append(".db ");
            byte[] data = GetPaletteData(true, false, over);
            foreach (byte b in data)
                sb.Append((hex ? "" : "$") + b.ToString("X2") + " ");
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Gets palette data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="pad">Padding with zeros, if the data is smaller than the original</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetPaletteData(bool getRawData, bool pad, bool over)
        {
            List<byte> bytes = new List<byte>();
            foreach (Color color in Colors.GetRange(Override ? 0 : Offset, Override ? Colors.Count : Length))
            {
                bytes.Add(GetColor(color));
            }
            return getRawData ? bytes.ToArray() : GetExportData(bytes, pad, over);
        }

        /// <summary>
        /// Gets bits of a given to bit color channel
        /// </summary>
        /// <param name="value">The color channel byte value</param>
        /// <returns>A bit array representing a value of 0, 1, 2, or 3</returns>
        private static bool[] GetColorBits(byte value)
        {
            switch (value)
            {
                case 85: return new bool[] { true, false };
                case 170: return new bool[] { false, true };
                case 255: return new bool[] { true, true };
                default: return new bool[] { false, false };
            }
        }
    }
}
