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
using System.Windows.Forms;
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Forms
{
    public partial class PropertiesForm : Form
    {
        // Properties
        public int Position { get { return (int)nudPosition.Value; } }
        public int Columns { get { return (int)nudColumns.Value; } }
        public int Rows { get { return (int)nudRows.Value; } }
        public byte[] Rect { get { return new byte[] { (byte)nudBoundsY0.Value, (byte)nudBoundsX0.Value, (byte)nudBoundsY1.Value, (byte)nudBoundsX1.Value }; } }

        public PropertiesForm(GameAsset asset)
        {
            InitializeComponent();

            if (asset is Tileset)
            {
                Tileset tileset = (asset as Tileset);
                Text = tileset.Name + " Properties";
                nudPosition.Value = tileset.Position;
                nudColumns.Enabled = false;
                nudRows.Enabled = false;
                nudBoundsX0.Enabled = false;
                nudBoundsY0.Enabled = false;
                nudBoundsX1.Enabled = false;
                nudBoundsY1.Enabled = false;
                nudColumnsPosition.Enabled = false;
                nudRowsPosition.Enabled = false;
                nudBoundsX0Position.Enabled = false;
                nudBoundsY0Position.Enabled = false;
                nudBoundsX1Position.Enabled = false;
                nudBoundsY1Position.Enabled = false;
            }
            else if (asset is Tilemap)
            {
                Tilemap tilemap = (asset as Tilemap);
                Text = tilemap.Name + " Properties";
                nudPosition.Value = tilemap.Position;
                nudColumns.Value = tilemap.AssetProperties[0].Value;
                nudRows.Value = tilemap.AssetProperties[1].Value;
                nudBoundsX0.Value = tilemap.AssetProperties[2].Value;
                nudBoundsY0.Value = tilemap.AssetProperties[3].Value;
                nudBoundsX1.Value = tilemap.AssetProperties[4].Value;
                nudBoundsY1.Value = tilemap.AssetProperties[5].Value;
                nudColumnsPosition.Value = tilemap.AssetProperties[0].Position;
                nudRowsPosition.Value = tilemap.AssetProperties[1].Position;
                nudBoundsX0Position.Value = tilemap.AssetProperties[2].Position;
                nudBoundsY0Position.Value = tilemap.AssetProperties[3].Position;
                nudBoundsX1Position.Value = tilemap.AssetProperties[4].Position;
                nudBoundsY1Position.Value = tilemap.AssetProperties[5].Position;
            }
        }

        /// <summary>
        /// Apply button click
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cancel button click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<AssetProperty> GetTilemapProperties()
        {
            List<AssetProperty> properties = new List<AssetProperty>();
            properties.Add(new AssetProperty("Columns", (int)nudColumnsPosition.Value, (byte)nudColumns.Value, false, false));
            properties.Add(new AssetProperty("Rows", (int)nudRowsPosition.Value, (byte)nudRows.Value, false, false));
            properties.Add(new AssetProperty("Bounds X0", (int)nudBoundsX0Position.Value, (byte)nudBoundsX0.Value, false, false));
            properties.Add(new AssetProperty("Bounds Y0", (int)nudBoundsY0Position.Value, (byte)nudBoundsY0.Value, false, false));
            properties.Add(new AssetProperty("Bounds X1", (int)nudBoundsX1Position.Value, (byte)nudBoundsX1.Value, false, false));
            properties.Add(new AssetProperty("Bounds Y1", (int)nudBoundsY1Position.Value, (byte)nudBoundsY1.Value, false, false));
            return properties;
        }
    }
}
