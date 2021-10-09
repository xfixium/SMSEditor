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
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class AssetTilesetControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;
        private int _actualLength = 0;

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetTilesetControl()
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
            if (ctrl.Name == btnTilesetValidate.Name)
                ValidateTileset(false);
            else if (ctrl.Name == btnTilesetSave.Name)
                SaveTileset();
            else if (ctrl.Name == btnTilesetRemove.Name)
                RemoveTileset();
        }

        /// <summary>
        /// Asset selection changed
        /// </summary>
        private void lstAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == lstTilesets.Name && lstTilesets.SelectedItem != null)
                SetTilesetData(_project.GetTileset((lstTilesets.SelectedItem as GameAsset).ID, true));

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
            if (ctrl.Name == cbTilesetPalette.Name)
                SetPalette();
        }

        /// <summary>
        /// Asset ID value changed
        /// </summary>
        private void nudAssetID_ValueChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl.Name == nudTilesetID.Name)
                nudTilesetHex.Value = nudTilesetID.Value;
            else if (ctrl.Name == nudTilesetHex.Name)
                nudTilesetID.Value = nudTilesetHex.Value;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            foreach (ComboBox ctrl in new List<ComboBox>() { cbTilesetCompression })
            {
                ctrl.ValueMember = "Value";
                ctrl.DisplayMember = "Description";
                ctrl.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType), false);
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            UpdateAssets();
            pnlTilesetImage.Image = null;
            lstTilesets.Items.Clear();
            lstTilesets.Items.AddRange(_project.Tilesets.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
            foreach (ListBox ctrl in new List<ListBox>() { lstTilesets })
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
        }

        /// <summary>
        /// Get data from the rom, with the given tileset parameters
        /// </summary>
        private bool ValidateTileset(bool save)
        {
            try
            {
                if (!HasData)
                    return false;

                pnlTilesetImage.Tag = null;
                pnlTilesetImage.Image = null;
                Tileset tileset = GetTilesetData();
                if (save && tileset.Name.Trim() == "")
                {
                    MessageBox.Show("Please enter a name for the tileset.");
                    return false;
                }

                _project.LoadTilesetData(tileset);
                SetTilesetData(tileset);
                return true;
            }
            catch
            {
                MessageBox.Show("Validation failed, could not retrieve asset safely. Change asset properties, and try again.");
                return false;
            }
        }

        /// <summary>
        /// Saves a new tileset, or updates an existing one
        /// </summary>
        private void SaveTileset()
        {
            if (!HasData || !ValidateTileset(true))
                return;

            Tileset tileset = GetTilesetData();
            if (_project.Tilesets.Find(x => x.ID == tileset.ID) != null)
            {
                _project.Tilesets[_project.Tilesets.FindIndex(x => x.ID == tileset.ID)] = tileset.DeepClone();
                lstTilesets.Items[lstTilesets.SelectedIndex] = tileset.DeepClone();
            }
            else
            {
                _project.Tilesets.Add(tileset);
                LoadData(_project);
                lstTilesets.SelectedItem = tileset;
            }

            Tileset edit = _project.TilesetEdits.Find(x => x.ID == tileset.ID);
            if (edit != null)
                edit.Update(tileset);

            OnAssetsChanged();
        }

        /// <summary>
        /// Removes a selected tileset
        /// </summary>
        private void RemoveTileset()
        {
            if (!HasData)
                return;

            if (MessageBox.Show("Are you sure you want to remove tileset: " + txtTilesetName.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _project.RemoveTileset((int)nudTilesetID.Value);
            LoadData(_project);
            OnAssetsChanged();
        }

        /// <summary>
        /// Sets tileset from UI data
        /// </summary>
        /// <returns></returns>
        private Tileset GetTilesetData()
        {
            try
            {
                if (!HasData)
                {
                    pnlTilesetImage.Image = null;
                    return null;
                }

                Tileset tileset = new Tileset();
                tileset.ID = (int)nudTilesetID.Value;
                tileset.Name = txtTilesetName.Text;
                tileset.Length = (int)nudTilesetLength.Value;
                tileset.Offset = (int)nudTilesetOffset.Value;
                tileset.Masked = chkTilesetMasked.Checked;
                tileset.CompressionType = GetCompressionType(cbTilesetCompression);
                tileset.Pixels = pnlTilesetImage.Tag == null ? tileset.Pixels : (pnlTilesetImage.Tag as Tileset).Pixels.DeepClone();
                tileset.PaletteID = cbTilesetPalette.SelectedItem == null ? -1 : (cbTilesetPalette.SelectedItem as GameAsset).ID;
                tileset.ActualLength = _actualLength;
                return tileset;
            }
            catch
            {
                pnlTilesetImage.Image = null;
                return null;
            }
        }

        /// <summary>
        /// Loads UI with given tileset data
        /// </summary>
        private void SetTilesetData(Tileset tileset)
        {
            try
            {
                if (!HasData || tileset.Pixels.Count <= 0)
                {
                    pnlTilesetImage.Image = null;
                    return;
                }

                nudTilesetID.Value = tileset.ID;
                txtTilesetName.Text = tileset.Name;
                nudTilesetLength.Value = tileset.Length;
                nudTilesetOffset.Value = tileset.Offset;
                chkTilesetMasked.Checked = tileset.Masked;
                SetCompressionType(cbTilesetCompression, tileset.CompressionType);
                pnlTilesetImage.Tag = tileset.DeepClone();
                cbTilesetPalette.SelectedItem = ItemByID(tileset.PaletteID, cbTilesetPalette);
                if (cbTilesetPalette.SelectedItem == null && cbTilesetPalette.Items.Count > 0)
                    cbTilesetPalette.SelectedIndex = 0;
                _actualLength = tileset.ActualLength;

                Palette palette = GetPalette();
                if (tileset == null || palette == null)
                    pnlTilesetImage.Image = null;
                else
                    pnlTilesetImage.Image = BitmapUtility.GetTilesetImage(tileset, palette, 16);
            }
            catch
            {
                pnlTilesetImage.Image = null;
                return;
            }
        }

        /// <summary>
        /// Gets the currently selected palette
        /// </summary>
        private Palette GetPalette()
        {
            if (cbTilesetPalette.SelectedItem == null)
                return null;
            else if (cbTilesetPalette.SelectedIndex < 2)
                return (cbTilesetPalette.SelectedItem as Palette);
            else
                return _project.GetPalette((cbTilesetPalette.SelectedItem as GameAsset).ID, true);
        }

        /// <summary>
        /// Sets palette colors, independent of any existing tileset data
        /// </summary>
        private void SetPalette()
        {
            try
            {
                var colors = Palette.Empty;
                if (cbTilesetPalette.SelectedItem == null)
                    pnlTilesetPalette.SetPalette(Palette.Empty);
                else if (cbTilesetPalette.SelectedIndex < 2)
                {
                    colors = (cbTilesetPalette.SelectedItem as Palette).Colors;
                    pnlTilesetPalette.SetPalette(colors);
                }
                else
                {
                    var palette = _project.GetPalette((cbTilesetPalette.SelectedItem as GameAsset).ID, true);
                    colors = palette == null ? colors : palette.Colors;
                    pnlTilesetPalette.SetPalette(colors);
                }

                Tileset tileset = lstTilesets.SelectedItem == null ? null : _project.GetTileset((lstTilesets.SelectedItem as GameAsset).ID, true);
                pnlTilesetImage.Image = tileset == null ? null : BitmapUtility.GetTilesetImage(tileset.Pixels, 255, colors, 16, tileset.Offset);
            }
            catch
            {
                pnlTilesetImage.Image = null;
                return;
            }
        }

        /// <summary>
        /// Trigger info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            OnInfoChanged(lstTilesets.SelectedItem == null ? null : GetTilesetData());
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        public void ExportTileset()
        {
            if (!HasData || lstTilesets.SelectedItem == null)
                return;

            Tileset tileset = _project.GetTileset((lstTilesets.SelectedItem as GameAsset).ID, true);
            Palette palette = _project.GetPalette(tileset.PaletteID, true);
            if (tileset == null || palette == null)
            {
                MessageBox.Show("Needed data was not found, the Tileset was not exported.");
                return;
            }

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Tileset Image";
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = tileset.Name;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap image = BitmapUtility.GetTilesetImage(tileset, palette, 16))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. The file may be in use in another application.");
            }
        }

        /// <summary>
        /// Updates assets
        /// </summary>
        public void UpdateAssets()
        {
            foreach (ComboBox ctrl in new List<ComboBox>() { cbTilesetPalette })
            {
                object selected = ctrl.SelectedItem;
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Palettes.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (selected != null && ctrl.Items.Contains(selected))
                    ctrl.SelectedItem = selected;
                else
                    ctrl.SelectedIndex = 0;
                SetPalette();
            }
        }
    }
}
