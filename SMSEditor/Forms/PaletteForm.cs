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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSEditor.Data;
using SMSEditor.Controls;

namespace SMSEditor.Forms
{
    public partial class PaletteForm : Form
    {
        // Fields
        private Project _project = null;
        private Palette _palette = null;
        private Point _lastPosition = Point.Empty;

        // Properties
        private bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="parent"></param>
        public PaletteForm(Project project)
        {
            InitializeComponent();
            _project = project;
            LoadData();
        }

        /// <summary>
        /// Palette selection changed
        /// </summary>
        private void lstPalettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || lstPalettes.SelectedItem == null)
                return;

            _palette = _project.GetPalette((lstPalettes.SelectedItem as GameAsset).ID);
            pnlPaletteEdit.SetPalette(_palette.Colors);
            tssInformation.Text = _palette.GetInfo(null);
            chkDisable.Checked = _palette.Disable;
            chkOverride.Checked = _palette.Override;
        }

        /// <summary>
        /// Color swatch mouse move
        /// </summary>
        private void pnlColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location != _lastPosition)
            {
                Color color = (sender as ImageControl).GetColorUnderMouse();
                bool showColor = color.ToArgb() != SystemColors.Control.ToArgb();
                ttMain.SetToolTip(pnlColorPicker, showColor ? GetColorString(color) : "");
                _lastPosition = e.Location;
            }
        }

        /// <summary>
        /// Palette color picker click
        /// </summary>
        private void pnlColorPicker_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ImageControl) || _palette == null)
                return;

            Color color = (sender as ImageControl).GetColorUnderMouse();
            color = color.A < 255 || color.ToArgb() == SystemColors.Control.ToArgb() ? Color.White : color;
            if (pnlPaletteEdit.SelectedIndex != -1)
            {
                if (_palette.Colors.Count <= 0)
                    _palette.Colors.AddRange(_palette.Colors.ToArray());

                _palette.Colors[pnlPaletteEdit.SelectedIndex] = color;
                pnlPaletteEdit.SetPalette(_palette.Colors);
                _project.SetPalette(_palette);
            }
        }

        /// <summary>
        /// Palette edit palette changed
        /// </summary>
        private void pnlPaletteEdit_PaletteChanged()
        {
            _palette.Colors = pnlPaletteEdit.Colors;
        }

        /// <summary>
        /// Override original length check changed
        /// </summary>
        private void chkOverride_CheckedChanged(object sender, EventArgs e)
        {
            _palette.Override = chkOverride.Checked;
        }

        /// <summary>
        /// Disable palette edit check changed
        /// </summary>
        private void chkDisable_CheckedChanged(object sender, EventArgs e)
        {
            _palette.Disable = chkDisable.Checked;
        }

        /// <summary>
        /// Loads various data
        /// </summary>
        private void LoadData()
        {
            if (!HasData)
                return;

            foreach (ListBox lst in new List<ListBox>() { lstPalettes })
            {
                lst.Items.Clear();
                foreach (GameAsset obj in _project.Palettes.OrderBy(x => x.ID))
                    lst.Items.Add(obj);
            }
            foreach (ListBox lst in new List<ListBox>() { lstPalettes })
                if (lst.Items.Count > 0)
                    lst.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets color tooltip
        /// </summary>
        /// <param name="col">The color to get string of</param>
        /// <returns>A color string</returns>
        private string GetColorString(Color col)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RGB: " + col.R + ", " + col.G + ", " + col.B);
            sb.AppendLine("RGB Hex: $" + col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2"));
            sb.AppendLine("SMS Hex: $" + Palette.GetColor(col).ToString("X2"));
            return sb.ToString();
        }
    }
}
