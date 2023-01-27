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
using System.Windows.Forms;
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class AssetTilemapControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;
        private int _actualLength = 0;
        private byte[] _bounds = new byte[] { 0, 0, 0, 0 };

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetTilemapControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save asset button click
        /// </summary>
        private void btnAsset_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == btnTilemapValidate.Name)
                ValidateTilemap(false);
            else if (ctrl.Name == btnTilemapSave.Name)
                SaveTilemap();
            else if (ctrl.Name == btnTilemapRemove.Name)
                RemoveTilemap();
        }

        /// <summary>
        /// Asset selection changed
        /// </summary>
        private void lstAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == lstTilemaps.Name && lstTilemaps.SelectedItem != null)
                SetTilemapData(_project.GetTilemap((lstTilemaps.SelectedItem as GameAsset).ID, true));

            OnInfoChanged();
        }

        /// <summary>
        /// Asset property selection changed
        /// </summary>
        private void cbAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == cbTilemapBGPalette.Name || ctrl.Name == cbTilemapSPRPalette.Name || ctrl.Name == cbTilemapTileset.Name)
                SetPalettes();
            else if (ctrl.Name == cbTilemapCompression.Name)
                nudTilemapLength.Enabled = cbTilemapCompression.SelectedIndex > 0;
        }

        /// <summary>
        /// Asset ID value changed
        /// </summary>
        private void nudAssetID_ValueChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl.Name == nudTilemapID.Name)
                nudTilemapHex.Value = nudTilemapID.Value;
            else if (ctrl.Name == nudTilemapHex.Name)
                nudTilemapID.Value = nudTilemapHex.Value;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            foreach (ComboBox ctrl in new List<ComboBox>() { cbTilemapCompression })
            {
                ctrl.ValueMember = "Value";
                ctrl.DisplayMember = "Description";
                ctrl.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType), false);
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            UpdateAssets();
            pnlTilemapImage.Image = null;
            lstTilemaps.Items.Clear();
            lstTilemaps.Items.AddRange(_project.Tilemaps.Cast<GameAsset>().Where(x => x.ID > -1).OrderBy(x => x.ID).ToArray());
            foreach (ListBox ctrl in new List<ListBox>() { lstTilemaps })
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
        }

        /// <summary>
        /// Get data from the rom, with the given tilemap parameters
        /// </summary>
        private bool ValidateTilemap(bool save)
        {
            try
            {
                if (!HasData)
                    return false;

                pnlTilemapImage.Tag = null;
                pnlTilemapImage.Image = null;
                Tilemap tilemap = GetTilemapData();
                if (save && tilemap.Name.Trim() == "")
                {
                    MessageBox.Show("Please enter a name for the tilemap.");
                    return false;
                }

                if (tilemap.PlaceHolder)
                    tilemap.SetPlaceholderTiles();
                else
                    _project.LoadTilemapData(tilemap);
                SetTilemapData(tilemap);
                return true;
            }
            catch
            {
                MessageBox.Show("Validation failed, could not retrieve asset safely. Change asset properties, and try again.");
                return false;
            }
        }

        /// <summary>
        /// Saves a new tilemap, or updates an existing one
        /// </summary>
        private void SaveTilemap()
        {
            if (!HasData || !ValidateTilemap(true))
                return;

            Tilemap tilemap = GetTilemapData();
            if (tilemap.TilesetID <= -1)
            {
                MessageBox.Show("Please aassign a tileset to the tilemap.");
                return;
            }

            if (_project.Tilemaps.Find(x => x.ID == tilemap.ID) != null)
            {
                _project.Tilemaps[_project.Tilemaps.FindIndex(x => x.ID == tilemap.ID)] = tilemap.DeepClone();
                lstTilemaps.Items[lstTilemaps.SelectedIndex] = tilemap.DeepClone();
            }
            else
            {
                _project.Tilemaps.Add(tilemap);
                LoadData(_project);
                lstTilemaps.SelectedItem = tilemap;
            }

            Tilemap edit = _project.TilemapEdits.Find(x => x.ID == tilemap.ID);
            if (edit != null)
                edit.Update(tilemap);

            OnAssetsChanged();
        }

        /// <summary>
        /// Removes a selected tilemap
        /// </summary>
        private void RemoveTilemap()
        {
            if (!HasData)
                return;

            if (MessageBox.Show("Are you sure you want to remove tilemap: " + txtTilemapName.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _project.RemoveTilemap((int)nudTilemapID.Value);
            LoadData(_project);
            OnAssetsChanged();
        }

        /// <summary>
        /// Loads selected tilemap data to UI
        /// </summary>
        private Tilemap GetTilemapData()
        {
            try
            {
                if (!HasData)
                {
                    pnlTilemapImage.Image = null;
                    return null;
                }

                Tilemap tilemap = new Tilemap();
                tilemap.ID = (int)nudTilemapID.Value;
                tilemap.Name = txtTilemapName.Text;
                tilemap.Columns = (int)nudTilemapColumns.Value;
                tilemap.Rows = (int)nudTilemapRows.Value;
                tilemap.Offset = (int)nudTilemapOffset.Value;
                tilemap.Bounds[0] = _bounds[0];
                tilemap.Bounds[1] = _bounds[1];
                tilemap.Bounds[2] = _bounds[2];
                tilemap.Bounds[3] = _bounds[3];
                tilemap.CompressionType = GetCompressionType(cbTilemapCompression);
                tilemap.UseTileAttributes = chkTilemapUseAttributes.Checked;
                tilemap.VerticalOrientation = chkVerticalOrientation.Checked;
                tilemap.Length = tilemap.CompressionType == CompressionType.None ? (tilemap.Columns * tilemap.Rows) * (tilemap.UseTileAttributes ? 2 : 1) : (int)nudTilemapLength.Value;
                tilemap.TilesetID = cbTilemapTileset.SelectedItem == null ? tilemap.TilesetID : (cbTilemapTileset.SelectedItem as GameAsset).ID;
                tilemap.Tiles = pnlTilemapImage.Tag == null ? tilemap.Tiles : (pnlTilemapImage.Tag as Tilemap).Tiles.DeepClone();
                tilemap.BGPaletteID = cbTilemapBGPalette.SelectedItem == null ? -1 : (cbTilemapBGPalette.SelectedItem as GameAsset).ID;
                tilemap.SPRPaletteID = cbTilemapSPRPalette.SelectedItem == null ? -1 : (cbTilemapSPRPalette.SelectedItem as GameAsset).ID;
                tilemap.ActualLength = _actualLength;
                tilemap.PlaceHolder = chkTilemapPlaceholder.Checked;
                return tilemap;
            }
            catch
            {
                pnlTilemapImage.Image = null;
                return null;
            }
        }

        /// <summary>
        /// Loads selected tilemap data to UI
        /// </summary>
        private void SetTilemapData(Tilemap tilemap)
        {
            try
            {
                if (!HasData)
                {
                    pnlTilemapImage.Image = null;
                    return;
                }

                nudTilemapID.Value = tilemap.ID;
                txtTilemapName.Text = tilemap.Name;
                nudTilemapColumns.Value = tilemap.Columns;
                nudTilemapRows.Value = tilemap.Rows;
                nudTilemapOffset.Value = tilemap.Offset;
                _bounds[0] = tilemap.Bounds[0];
                _bounds[1] = tilemap.Bounds[1];
                _bounds[2] = tilemap.Bounds[2];
                _bounds[3] = tilemap.Bounds[3];
                SetCompressionType(cbTilemapCompression, tilemap.CompressionType);
                nudTilemapLength.Value = tilemap.Length;
                nudTilemapLength.Enabled = tilemap.CompressionType != CompressionType.None;
                chkTilemapUseAttributes.Checked = tilemap.UseTileAttributes;
                chkVerticalOrientation.Checked = tilemap.VerticalOrientation;
                cbTilemapTileset.SelectedItem = ItemByID(tilemap.TilesetID, cbTilemapTileset);
                if (cbTilemapTileset.SelectedItem == null && cbTilemapTileset.Items.Count > 0)
                    cbTilemapTileset.SelectedIndex = 0;
                cbTilemapBGPalette.SelectedItem = ItemByID(tilemap.BGPaletteID, cbTilemapBGPalette);
                if (cbTilemapBGPalette.SelectedItem == null && cbTilemapBGPalette.Items.Count > 0)
                    cbTilemapBGPalette.SelectedIndex = 0;
                cbTilemapSPRPalette.SelectedItem = ItemByID(tilemap.SPRPaletteID, cbTilemapBGPalette);
                if (cbTilemapSPRPalette.SelectedItem == null && cbTilemapSPRPalette.Items.Count > 0)
                    cbTilemapSPRPalette.SelectedIndex = 0;
                pnlTilemapImage.Tag = tilemap.DeepClone();
                chkTilemapPlaceholder.Checked = tilemap.PlaceHolder;
                _actualLength = tilemap.ActualLength;
                SetPalettes();
            }
            catch
            {
                pnlTilemapImage.Image = null;
                return;
            }
        }

        /// <summary>
        /// Gets the currently selected palette
        /// </summary>
        private Palette GetPalette(ComboBox ctrl)
        {
            if (ctrl.SelectedItem == null)
                return null;
            else if (ctrl.SelectedIndex < 2)
                return (ctrl.SelectedItem as Palette);
            else
                return _project.GetPalette((ctrl.SelectedItem as GameAsset).ID, true);
        }

        /// <summary>
        /// Sets palette colors
        /// </summary>
        private void SetPalettes()
        {
            try
            {
                foreach (ComboBox ctrl in new List<ComboBox>() { cbTilemapBGPalette, cbTilemapSPRPalette })
                {
                    var colors = Palette.Empty;
                    PaletteControl paletteCtrl = ctrl.Name == cbTilemapBGPalette.Name ? pnlTilemapBGPalette : pnlTilemapSPRPalette;
                    if (ctrl.SelectedItem == null)
                        paletteCtrl.SetPalette(Palette.Empty);
                    else if (ctrl.SelectedIndex < 2)
                    {
                        colors = (ctrl.SelectedItem as Palette).Colors;
                        paletteCtrl.SetPalette(colors);
                    }
                    else
                    {
                        var palette = _project.GetPalette((ctrl.SelectedItem as GameAsset).ID, true);
                        colors = palette == null ? colors : palette.Colors;
                        paletteCtrl.SetPalette(colors);
                    }
                }

                if (cbTilemapTileset.SelectedItem == null)
                {
                    pnlTilemapImage.Image = null;
                    return;
                }

                Palette bgPalette = GetPalette(cbTilemapBGPalette);
                Palette sprPalette = GetPalette(cbTilemapSPRPalette);
                Tileset tileset = _project.GetTileset((cbTilemapTileset.SelectedItem as GameAsset).ID, true);
                Tilemap tilemap = pnlTilemapImage.Tag as Tilemap;
                if (tilemap == null || tileset == null || bgPalette == null || sprPalette == null)
                    pnlTilemapImage.Image = null;
                else
                    pnlTilemapImage.Image = BitmapUtility.GetSpriteImage(tileset, tilemap, bgPalette, sprPalette);
            }
            catch
            {
                pnlTilemapImage.Image = null;
                return;
            }
        }

        /// <summary>
        /// Trigger info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            OnInfoChanged(lstTilemaps.SelectedItem == null ? null : GetTilemapData());
        }

        /// <summary>
        /// Updates assets
        /// </summary>
        public void UpdateAssets()
        {
            foreach (ComboBox ctrl in new List<ComboBox>() { cbTilemapBGPalette, cbTilemapSPRPalette })
            {
                object selected = ctrl.SelectedItem;
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Palettes.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (selected != null && ctrl.Items.Contains(selected))
                    ctrl.SelectedItem = selected;
                else
                    ctrl.SelectedIndex = 0;
            }

            foreach (ComboBox ctrl in new List<ComboBox>() { cbTilemapTileset })
            {
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Tilesets.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            SetPalettes();
        }
    }
}
