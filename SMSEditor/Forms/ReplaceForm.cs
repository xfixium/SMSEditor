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

using System.Drawing;
using System.Windows.Forms;

namespace SMSEditor.Forms
{
    public partial class ReplaceForm : Form
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int SourceTileID { get { return pnlSource.TileID; } }
        public int TargetTileID { get { return pnlTarget.TileID; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public ReplaceForm(Bitmap tileset, int tileCount)
        {
            InitializeComponent();
            pnlSource.Image = (Bitmap)tileset.Clone();
            pnlTarget.Image = (Bitmap)tileset.Clone();
            pnlSource.TileCount = tileCount;
            pnlTarget.TileCount = tileCount;
        }

        /// <summary>
        /// Image scale changed
        /// </summary>
        private void pnlTileSelect_ScaleChanged(object sender)
        {
            if ((sender as Control).Name == pnlSource.Name)
                pnlTarget.ImageScale = pnlSource.ImageScale;
            else
                pnlSource.ImageScale = pnlTarget.ImageScale;
        }


        /// <summary>
        /// Source tiles scroll changed
        /// </summary>
        private void pnlSource_Scroll(object sender, ScrollEventArgs e)
        {
            pnlTarget.AutoScrollPosition = new Point(-pnlSource.AutoScrollPosition.X, -pnlSource.AutoScrollPosition.Y);
        }

        /// <summary>
        /// Target tiles scroll changed
        /// </summary>
        private void pnlTarget_Scroll(object sender, ScrollEventArgs e)
        {
            pnlSource.AutoScrollPosition = new Point(-pnlTarget.AutoScrollPosition.X, -pnlTarget.AutoScrollPosition.Y);
        }

        /// <summary>
        /// Tiles selection changed
        /// </summary>
        private void pnlTarget_TileSelectionChanged()
        {
            pnlSource.TileID = pnlTarget.TileID;
            pnlSource.Selection = pnlTarget.Selection;
        }

        /// <summary>
        /// Show tile grid check changed
        /// </summary>
        private void chkTilesetUseGrid_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlSource.UseGrid = chkTilesetUseGrid.Checked;
            pnlTarget.UseGrid = chkTilesetUseGrid.Checked;
        }

        /// <summary>
        /// Show tile indexes check changed
        /// </summary>
        private void chkTilesetIndexed_CheckedChanged(object sender, System.EventArgs e)
        {
            pnlSource.Indexed = chkTilesetIndexed.Checked;
            pnlTarget.Indexed = chkTilesetIndexed.Checked;
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cancel button click
        /// </summary>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
