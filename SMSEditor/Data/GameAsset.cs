// 
// Dev SMS
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
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMSEditor.Data
{
    /// <summary>
    /// Inherited game object id
    /// </summary>
    [Serializable]
    public class GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public StatusType StatusType { get; set; } = StatusType.Good;                                               // Status used for this asset, if any
        public CompressionType CompressionType { get; set; } = CompressionType.None;                                // Compression used for this asset, if any
        public int ID { get; set; } = -1;                                                                           // Unique ID or byte position in ROM data
        public int Position { get; set; } = -1;                                                                     // Alternate position in ROM data
        public int Offset { get; set; } = 0;                                                                        // Generic offset value, typically for rendering purposes
        public string Name { get; set; } = "";                                                                      // The name of the asset
        public int Length { get; set; } = 0;                                                                        // The size, in bytes, of the asset in the ROM (Compressed or otherwise)
        public int ActualLength { get; set; } = 0;                                                                  // The size, in bytes, of the asset in the ROM (Without compression)
        public bool Override { get; set; } = false;                                                                 // If force writing bytes when exporting, over the original length limit
        public bool Disable { get; set; } = false;                                                                  // If disabling asset's resource write
        public string DataStartString { get { return ID + " (" + ID.ToString("X") + ")"; } }                        // Quality of life string for data position start
        public string DataEndString { get { return (ID + Length).ToString("X") + " (" + (ID + Length) + ")"; } }    // Quality of life string for data position end
        public List<AssetProperty> AssetProperties { get; set; } = new List<AssetProperty>();                       // Custom properties that can be written
        public int Location { get { return Position < 0 ? ID : Position; } }                                        

        /// <summary>
        /// Constructors
        /// </summary>
        public GameAsset() { AssetProperties = new List<AssetProperty>(); }
        public GameAsset(int id, string name) { ID = id; Name = name; }

        /// <summary>
        /// Makes sure the given bytes (For export) are either truncated by the original asset length, 
        /// padded if not enough bytes, or overridden if the length is bigger than the original asset length
        /// Also handles compression of exported bytes
        /// </summary>
        /// <param name="bytes">The bytes to export</param>
        /// <returns>A finalized array of bytes</returns>
        public byte[] GetExportData(List<byte> bytes, bool pad)
        {
            if (CompressionType == CompressionType.PSRLEPlanar4)
            {
                byte[] compressed = Compression.CompressPSRLEPlanar4(bytes.ToArray());
                bytes.Clear();
                bytes.AddRange(compressed);
            }
            else if (CompressionType == CompressionType.PSRLEPlanar2)
            {
                byte[] compressed = Compression.CompressPSRLEPlanar2(bytes.ToArray());
                bytes.Clear();
                bytes.AddRange(compressed);
            }
            else if (CompressionType == CompressionType.PSRLELinear)
            {
                byte[] compressed = Compression.CompressPSRLELinear(bytes.ToArray());
                bytes.Clear();
                bytes.AddRange(compressed);
            }

            if (pad && bytes.Count < Length)
            {
                int amount = Length - bytes.Count;
                for (int i = 0; i < amount; i++)
                    bytes.Add(0);
            }
            else if (!Override && bytes.Count > Length)
                bytes = bytes.GetRange(0, Length);

            return bytes.ToArray();
        }

        /// <summary>
        /// Get the given property's value
        /// </summary>
        /// <param name="name">Name of the property to get the value of</param>
        /// <returns>Property value</returns>
        public byte GetPropertyValue(string name)
        {
            AssetProperty property = AssetProperties.Find(x => x.Name == name);
            return property == null ? (byte)0 : property.Value;
        }

        /// <summary>
        /// Sets the given property's value
        /// </summary>
        /// <param name="name">Name of the property to set</param>
        /// <param name="value">The value of the property</param>
        public void SetPropertyValue(string name, byte value)
        {
            AssetProperty property = AssetProperties.Find(x => x.Name == name);
            if (property != null)
                property.Value = value;
        }

        /// <summary>
        /// Asset information changed
        /// </summary>
        public virtual string GetInfo()
        {
            return string.Empty;
        }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>The name of the game asset</returns>
        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// Deep copy of object
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Deep clone of object
        /// </summary>
        /// <param name="obj">Object to clone</param>
        /// <returns>A deep copy of a given object</returns>
        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }

    /// <summary>
    /// Asset property
    /// </summary>
    [Serializable]
    public class AssetProperty
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string Name { get; set; } = "";
        public int Position { get; set; } = -1;
        public byte Value { get; set; } = 0;
        public bool Disable { get; set; } = false;
        public bool CanBeRemoved { get; set; } = true;

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetProperty() { }
        public AssetProperty(string name, int position, byte value, bool disabled = false, bool canBeRemoved = true)
        {
            Name = name;
            Position = position;
            Value = value;
            Disable = disabled;
            CanBeRemoved = CanBeRemoved;
        }
    }
}