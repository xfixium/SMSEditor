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
    public partial class AssetPaletteControl : AssetControl
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
        public AssetPaletteControl()
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
            if (ctrl.Name == btnPaletteValidate.Name)
                ValidatePalette(false);
            else  if (ctrl.Name == btnPaletteSave.Name)
                SavePalette();
            else if (ctrl.Name == btnPaletteRemove.Name)
                RemovePalette();
        }

        /// <summary>
        /// Asset selection changed
        /// </summary>
        private void lstAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == lstPalettes.Name && lstPalettes.SelectedItem != null)
                SetPaletteData(_project.GetPalette((lstPalettes.SelectedItem as GameAsset).ID, true));

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
            if (ctrl.Name == cbPalettePartial.Name)
                SetPalette();
        }

        /// <summary>
        /// Asset ID value changed
        /// </summary>
        private void nudAssetID_ValueChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl.Name == nudPaletteID.Name)
                nudPaletteHex.Value = nudPaletteID.Value;
            else if (ctrl.Name == nudPaletteHex.Name)
                nudPaletteID.Value = nudPaletteHex.Value;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            foreach (ComboBox ctrl in new List<ComboBox>() { cbPalettePartial })
            {
                ctrl.Items.Clear();
                ctrl.Items.Add(new GameAsset(-1, "None"));
                ctrl.Items.AddRange(_project.Palettes.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            foreach (ComboBox ctrl in new List<ComboBox>() { cbPaletteCompression })
            {
                ctrl.ValueMember = "Value";
                ctrl.DisplayMember = "Description";
                ctrl.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType), false);
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            lstPalettes.Items.Clear();
            lstPalettes.Items.AddRange(_project.Palettes.Cast<GameAsset>().Where(x => x.ID >= 0).OrderBy(x => x.ID).ToArray());
            foreach (ListBox ctrl in new List<ListBox>() { lstPalettes })
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
        }

        /// <summary>
        /// Get data from the rom, with the given palette parameters
        /// </summary>
        private bool ValidatePalette(bool save)
        {
            try
            {
                if (!HasData)
                    return false;

                Palette palette = GetPaletteData();
                if (save && palette.Name.Trim() == "")
                {
                    MessageBox.Show("Please enter a name for the palette.");
                    return false;
                }

                _project.LoadPaletteData(palette);
                SetPaletteData(palette);
                return true;
            }
            catch
            {
                MessageBox.Show("Validation failed, could not retrieve asset safely. Change asset properties, and try again.");
                return false;
            }
        }

        /// <summary>
        /// Saves a new palette, or updates an existing one
        /// </summary>
        private void SavePalette()
        {
            if (!HasData || !ValidatePalette(true))
                return;

            Palette palette = GetPaletteData();            
            if (_project.Palettes.Find(x => x.ID == palette.ID) != null)
            {
                _project.Palettes[_project.Palettes.FindIndex(x => x.ID == palette.ID)] = palette.DeepClone();
                lstPalettes.Items[lstPalettes.SelectedIndex] = palette.DeepClone();
            }
            else
            {
                _project.Palettes.Add(palette);
                lstPalettes.Items.Clear();
                LoadData(_project);
                lstPalettes.SelectedItem = palette;
            }

            Palette edit = _project.PaletteEdits.Find(x => x.ID == palette.ID);
            if (edit != null)
                edit.Update(palette);

            OnAssetsChanged();
        }

        /// <summary>
        /// Removes a selected palette
        /// </summary>
        private void RemovePalette()
        {
            if (!HasData)
                return;

            if (MessageBox.Show("Are you sure you want to remove palette: " + txtPaletteName.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _project.RemovePalette((int)nudPaletteID.Value);
            lstPalettes.Items.Clear();
            LoadData(_project);
            OnAssetsChanged();
        }

        /// <summary>
        /// Gets palette from UI data
        /// </summary>
        private Palette GetPaletteData()
        {
            try
            {
                if (!HasData)
                    return null;

                Palette palette = new Palette();
                palette.ID = (int)nudPaletteID.Value;
                palette.Name = txtPaletteName.Text;
                palette.Length = (int)nudPaletteLength.Value;
                palette.Offset = (int)nudPaletteOffset.Value;
                palette.PartialPaletteID = cbPalettePartial.SelectedItem == null ? palette.PartialPaletteID : (cbPalettePartial.SelectedItem as GameAsset).ID;
                palette.CompressionType = GetCompressionType(cbPaletteCompression);
                palette.Colors = pnlPaletteColors.Colors;
                palette.ActualLength = _actualLength;
                return palette;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Loads selected palette data to UI
        /// </summary>
        private void SetPaletteData(Palette palette)
        {
            try
            {
                if (!HasData || palette == null)
                    return;

                nudPaletteID.Value = palette.ID;
                txtPaletteName.Text = palette.Name;
                nudPaletteLength.Value = palette.Length;
                nudPaletteOffset.Value = palette.Offset;
                cbPalettePartial.SelectedItem = ItemByID(palette.PartialPaletteID, cbPalettePartial);
                SetCompressionType(cbPaletteCompression, palette.CompressionType);
                pnlPaletteColors.SetPalette(palette.Colors);
                Palette partial = _project.GetPalette((cbPalettePartial.SelectedItem as GameAsset).ID, true);
                pnlPalettePartial.SetPalette(partial == null ? Palette.Empty : partial.Colors);
                _actualLength = palette.ActualLength;
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Trigger info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            OnInfoChanged(lstPalettes.SelectedItem == null ? null : GetPaletteData());
        }

        /// <summary>
        /// Sets palette colors, independent of any existing tileset data
        /// </summary>
        private void SetPalette()
        {
            if (cbPalettePartial.SelectedItem == null)
                pnlPalettePartial.SetPalette(Palette.Empty);
            else
            {
                Palette palette = _project.GetPalette((cbPalettePartial.SelectedItem as GameAsset).ID, true);
                pnlPalettePartial.SetPalette(palette == null ? Palette.Empty : palette.Colors);
            }
        }
    }
}
