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
using System.Windows.Forms;
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class ColorEditControl : UserControl
    {
        /// <summary>
        /// Events
        /// </summary>
        public event ColorShiftedHandler ColorShifted;
        public delegate void ColorShiftedHandler();
        public event SelectedColorChangedHandler SelectedColorChanged;
        public delegate void SelectedColorChangedHandler();

        /// <summary>
        /// Fields
        /// </summary>
        private int _index = 0;
        private bool _initialized = false;
        private bool _bgPaletteSelected = true;
        private ColorControl _selected = null;

        /// <summary>
        /// Properties
        /// </summary>
        public bool BGPaletteSelected { get { return _bgPaletteSelected; } set { _bgPaletteSelected = value; pnlColor_Click(null, GetEmptyMouseEvent()); UpdateUI(); } }
        public List<Color> BGPalette { get; private set; } = new List<Color>();
        public List<Color> SPRPalette { get; private set; } = new List<Color>();
        public List<Color> BGImport { get; private set; } = new List<Color>();
        public List<Color> SPRImport { get; private set; } = new List<Color>();

        /// <summary>
        /// Constructors
        /// </summary>
        public ColorEditControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Menu item click
        /// </summary>
        private void mnuMain_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            ToolStripMenuItem ctrl = sender as ToolStripMenuItem;
            if (ctrl.Name == mnuRemoveColor.Name)
            {
                if (_bgPaletteSelected)
                    BGImport[_index] = Color.Transparent;
                else
                    SPRImport[_index] = Color.Transparent;
            }
            else if (ctrl.Name == mnuMoveColor.Name)
            {
                int index = GetAvailableIndex(_bgPaletteSelected);
                if (index == -1)
                {
                    MessageBox.Show("There are no available slots to move the color to.");
                    return;
                }

                Color color = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
                if (_bgPaletteSelected)
                {
                    BGImport[_index] = Color.Transparent;
                    SPRImport[index] = color;
                }
                else
                {
                    SPRImport[_index] = Color.Transparent;
                    BGImport[index] = color;
                }
            }
            else if (ctrl.Name == mnuCopyColor.Name)
            {
                int index = GetAvailableIndex(_bgPaletteSelected);
                if (index == -1)
                {
                    MessageBox.Show("There are no available slots to copy the color to.");
                    return;
                }

                Color color = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
                if (_bgPaletteSelected)
                    SPRImport[index] = color;
                else
                    BGImport[index] = color;
            }

            UpdateUI();
            ColorShifted?.Invoke();
        }

        /// <summary>
        /// Shift button click
        /// </summary>
        private void btnShift_Click(object sender, EventArgs e)
        {
            if (_selected == null || !(sender is Button))
                return;

            int shift = 0;
            Button button = sender as Button;
            if (button.Name == btnLeft.Name && _index > 0)
                shift = -1;
            else if (button.Name == btnRight.Name && _index < 15)
                shift = 1;

            if (shift == 0)
                return;

            int source = _index;
            Color sourceColor = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];
            _index += shift;
            Color targetColor = _bgPaletteSelected ? BGImport[_index] : SPRImport[_index];

            if (_bgPaletteSelected)
            {
                BGImport[source] = targetColor;
                BGImport[_index] = sourceColor;
            }
            else
            {
                SPRImport[source] = targetColor;
                SPRImport[_index] = sourceColor;
            }

            pnlColor_Click(Controls.Find("pnlColor" + _index, true)[0], GetEmptyMouseEvent());
            UpdateUI();
            ColorShifted?.Invoke();
        }

        /// <summary>
        /// Color click
        /// </summary>
        private void pnlColor_Click(object sender, MouseEventArgs e)
        {
            if (_selected != null)
                _selected.Selected = false;

            if (sender == null)
            {
                _selected = null;
                _index = 0;
                return;
            }

            _selected = sender as ColorControl;
            _selected.Selected = true;
            _index = Convert.ToInt32(_selected.Tag);
            SelectedColorChanged?.Invoke();

            if (_selected != null && e.Button == MouseButtons.Right)
                mnuMain.Show(Cursor.Position);
        }

        /// <summary>
        /// Sets the palette control's color palette
        /// </summary>
        /// <param name="import">The imported colors to match against a palette</param>
        /// <param name="bgPalette">The background palette</param>
        /// <param name="sprPalette">The sprite palette</param>
        public void SetPalette(List<Color> import, List<Color> bgPalette, List<Color> sprPalette)
        {
            List<Color> sprImport = new List<Color>();
            if (import.Count > 16)
                sprImport.AddRange(import.GetRange(16, import.Count - 16));

            BGImport = Match(new List<Color>(import.GetRange(0, import.Count > 16 ? 16 : import.Count).ToArray()), bgPalette);;
            SPRImport = Match(new List<Color>((sprImport.Count > 0 ? sprImport : import).ToArray()), sprPalette);
            BGPalette = new List<Color>(bgPalette.ToArray());
            SPRPalette = new List<Color>(sprPalette.ToArray());

            if (_selected != null)
            {
                _selected.Selected = false;
                _selected = null;
            }
            
            _initialized = true;
            UpdateUI();
        }

        /// <summary>
        /// Updates UI
        /// </summary>
        private void UpdateUI()
        {
            if (!_initialized)
                return;

            List<Color> import = _bgPaletteSelected ? BGImport : SPRImport;
            List<Color> palette = _bgPaletteSelected ? BGPalette : SPRPalette;

            for (int i = 0; i < 16; i++)
                SetColorPanel(i, import[i]);

            for (int j = 0; j < 16; j++)
                SetColorPanel(j + 16, palette[j]);
        }

        /// <summary>
        /// Matches import colors to palettes
        /// </summary>
        public void Match()
        {
            BGImport = Match(new List<Color>(BGImport), BGPalette);
            SPRImport = Match(new List<Color>(SPRImport), SPRPalette);
            UpdateUI();
        }

        /// <summary>
        /// Matches import colors to palettes
        /// </summary>
        /// <param name="import">Import colors to match</param>
        /// <param name="palette">Colors in the palette</param>
        /// <returns>A list of rearranged colors</returns>
        private List<Color> Match(List<Color> import, List<Color> palette)
        {
            List<Color> matches = new List<Color>();
            for (int i = 0; i < 16; i++)
                matches.Add(Color.Transparent);

            foreach (Color color in import)
            {
                for (int i = 0; i < palette.Count; i++)
                {
                    if (palette[i].ToArgb() == color.ToArgb())
                    {
                        matches[i] = color;
                        break;
                    }
                }
            }

            List<Color> unmatched = new List<Color>();
            foreach (Color color in import)
            {
                if (matches.Find(x => x.ToArgb() == color.ToArgb()) == Color.Empty)
                    unmatched.Add(color);
            }

            foreach (Color color in unmatched)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    if (matches[i] == Color.Transparent)
                    {
                        matches[i] = color;
                        break;
                    }
                }
            }

            return matches;
        }

        /// <summary>
        /// Fills given colors to 16 colors
        /// </summary>
        /// <param name="colors">Palette to fill</param>
        private List<Color> Fill(List<Color> colors)
        {
            if (colors == null)
                return colors;

            for (int i = colors.Count; i < 16; i++)
                BGImport.Add(Color.Transparent);

            return colors;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetAvailableIndex(bool bgPalette)
        {
            for (int i = 0; i < (bgPalette ? SPRImport : BGImport).Count; i++)
                if ((bgPalette ? SPRImport : BGImport)[i].ToArgb() == Color.Transparent.ToArgb())
                    return i;

            return -1;
        }

        /// <summary>
        /// Sets the indexed color panel's color
        /// </summary>
        /// <param name="index">The color panel index</param>
        /// <param name="color">The backcolor to set</param>
        private void SetColorPanel(int index, Color color)
        {
            Control panel = (Controls.Find("pnlColor" + index, true)[0] as Panel);
            panel.BackColor = color;
            ttMain.SetToolTip(panel, panel.BackColor == Color.Transparent ? "" : GetTooltip(panel.BackColor));
        }

        /// <summary>
        /// Gets color tooltip
        /// </summary>
        /// <param name="col">The color to get string of</param>
        /// <returns>A color string</returns>
        private string GetTooltip(Color col)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RGB: " + col.R + ", " + col.G + ", " + col.B);
            sb.AppendLine("RGB Hex: $" + col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2"));
            sb.AppendLine("SMS Hex: $" + Palette.GetColor(col).ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// Gets empty mouse event arguments
        /// </summary>
        /// <returns>Empty mouse event arguments</returns>
        private MouseEventArgs GetEmptyMouseEvent()
        {
            return new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
        }
    }
}
