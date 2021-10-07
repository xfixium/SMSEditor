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
    public partial class RomImageControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;
        private List<byte> _romImage = new List<byte>();

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public RomImageControl()
        {
            InitializeComponent();
            pnlRomImage.VScrollIncrememnt = 8;
        }

        /// <summary>
        /// Asset property selection changed
        /// </summary>
        private void cbAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == cbRomImageBGPalette.Name || ctrl.Name == cbRomImageSPRPalette.Name)
                SetPalettes();
            else if (ctrl.Name == radRomImageBGPalette.Name || ctrl.Name == radRomImageSPRPalette.Name)
                UpdateImage();
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            _romImage = _project.GetRomImage();
            UpdateAssets();
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
            foreach (ComboBox ctrl in new List<ComboBox>() { cbRomImageBGPalette, cbRomImageSPRPalette })
            {
                var colors = Palette.Empty;
                PaletteControl paletteCtrl = ctrl.Name == cbRomImageBGPalette.Name ? pnlRomImageBGPalette : pnlRomImageSPRPalette;
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

            UpdateImage();
        }

        /// <summary>
        /// Updates the sprite image
        /// </summary>
        private void UpdateImage()
        {
            Palette palette = radRomImageBGPalette.Checked ? GetPalette(cbRomImageBGPalette) : GetPalette(cbRomImageSPRPalette);
            if (palette == null)
            {
                pnlRomImage.Image = null;
                return;
            }

            pnlRomImage.Image = BitmapUtility.GetRomImage(_romImage, palette);
        }

        /// <summary>
        /// Updates asset references
        /// </summary>
        public void UpdateAssets()
        {
            foreach (ComboBox ctrl in new List<ComboBox>() { cbRomImageBGPalette, cbRomImageSPRPalette })
            {
                object selected = ctrl.SelectedItem;
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Palettes.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (selected != null && ctrl.Items.Contains(selected))
                    ctrl.SelectedItem = selected;
                else if (ctrl.Items.Count > 0 && ctrl.Name == cbRomImageBGPalette.Name)
                    ctrl.SelectedIndex = 0;
                else if (ctrl.Items.Count > 1 && ctrl.Name == cbRomImageSPRPalette.Name)
                    ctrl.SelectedIndex = 1;
            }

            SetPalettes();
        }
    }
}
