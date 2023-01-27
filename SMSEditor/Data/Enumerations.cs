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
using System.ComponentModel;
using System.Collections.Generic;

namespace SMSEditor.Data
{
    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum CompressionType : int
    {
        [Description("None")]
        None = 0,
        [Description("PS RLE Planar 4")]
        PSRLEPlanar4 = 1,
        [Description("PS RLE Linear")]
        PSRLELinear = 2,
        [Description("PS RLE Planar 2")]
        PSRLEPlanar2 = 3,
        [Description("Sonic 1")]
        Sonic1 = 4,
    }

    /// <summary>
    /// Describes the flip direction types
    /// </summary>
    public enum FlipType
    {
        None,
        Horizontal,
        Vertical,
        Both
    }

    /// <summary>
    /// Describes status types
    /// </summary>
    public enum StatusType
    {
        [Description("Good")]
        Good,
        [Description("Error")]
        Error,
        [Description("Overflow")]
        Overflow,
        [Description("Disabled")]
        Disabled
    }

    /// <summary>
    /// Describes tile attribute edit type
    /// </summary>
    public enum TileEditType
    {
        [Description("Tile ID")]
        TileID,
        [Description("Horizontal Flip")]
        XFlip,
        [Description("Vertical Flip")]
        YFlip,
        [Description("Priority")]
        Priority,
        [Description("Palette Index")]
        PaletteIndex,
        //Bit14,
        //Bit15,
        //Bit16
    }

    /// <summary>
    /// Describes bits per pixel types
    /// </summary>
    public enum BppType
    {
        one,
        Two,
        Three,
        Four
    }

    /// <summary>
    /// Gets a list of enumeration values, using the description as the display member
    /// </summary>
    public static class EnumMethods
    {
        /// <summary>
        /// Gets an enumerations decription attribute
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static string GetDescription(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false).Length <= 0)
                return "";
            return (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false)[0] as DescriptionAttribute).Description;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="valueSorted"></param>
        /// <returns></returns>
        public static List<dynamic> GetEnumCollection(Type enumType, bool valueSorted = true)
        {
            if (valueSorted)
            {
                return Enum.GetValues(enumType)
                        .Cast<Enum>()
                        .Select(value => new
                        {
                            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                            value
                        })
                        .OrderBy(item => item.value)
                        .ToList<dynamic>();
            }
            else
            {
                return Enum.GetValues(enumType)
                        .Cast<Enum>()
                        .Select(value => new
                        {
                            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                            value
                        })
                        .OrderBy(item => item.Description)
                        .ToList<dynamic>();
            }
        }
    }
}