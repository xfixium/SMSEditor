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
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using SMSEditor.Data;
using SMSEditor.Controls;

namespace SMSEditor.Forms
{
    public partial class CompareForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private int _frame = 0;
        private int _spriteID = -1;
        private Project _project = null;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _project != null && _spriteID > -1; } }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="project">Project data </param>
        /// <param name="spriteID">The selected sprite</param>
        public CompareForm(Project project, int spriteID)
        {
            InitializeComponent();
            _project = project;
            _spriteID = spriteID;
            UpdateImages();
        }

        /// <summary>
        /// Sprite panel scale changed
        /// </summary>
        private void pnlSprite_ScaleChanged(object sender)
        {
            if (!HasData)
                return;

            ImageControl ctrl = sender as ImageControl;
            if (ctrl.Name == pnlOriginalSprite.Name)
                pnlEditedSprite.ImageScale = ctrl.ImageScale;
            else if (ctrl.Name == pnlEditedSprite.Name)
                pnlOriginalSprite.ImageScale = ctrl.ImageScale;
        }

        /// <summary>
        /// Frame button click
        /// </summary>
        private void btnFrame_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is Button button))
                return;

            Sprite sprite = _project.GetSprite(_spriteID);
            if (sprite == null)
                return;

            if (button.Name == btnPreviousFrame.Name)
                _frame--;
            else if (button.Name == btnNextFrame.Name)
                _frame++;

            if (_frame < 0)
                _frame = 0;

            if (_frame >= sprite.TilemapIDs.Count)
                _frame = sprite.TilemapIDs.Count - 1;

            UpdateImages();
        }

        /// <summary>
        /// Export sprite image button click
        /// </summary>
        private void btnExportImage_Click(object sender, EventArgs e)
        {
            SpriteData ogSprite = GetSpriteData(true);
            SpriteData editSprite = GetSpriteData(false);
            if (ogSprite == null || editSprite == null)
            {
                MessageBox.Show("Needed data was not found, the Sprite was not exported.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = ogSprite.Name;
                dialog.Filter = "PNG Image File|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap image = new Bitmap(ogSprite.Tilemap.Size.Width + editSprite.Tilemap.Size.Width, ogSprite.Tilemap.Size.Height))
                    {
                        using (Graphics gfx = Graphics.FromImage(image))
                        {
                            gfx.DrawImageUnscaled(pnlOriginalSprite.Image, Point.Empty);
                            gfx.DrawImageUnscaled(pnlEditedSprite.Image, new Point(ogSprite.Tilemap.Size.Width, 0));
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ok button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Updates sprite images
        /// </summary>
        private void UpdateImages()
        {
            if (!HasData)
                return;

            SpriteData ogSprite = GetSpriteData(true);
            SpriteData editSprite = GetSpriteData(false);
            pnlOriginalSprite.Image = BitmapUtility.GetSpriteImage(ogSprite.Tileset, ogSprite.Tilemap, ogSprite.BGPalette, ogSprite.SPRPalette);
            pnlEditedSprite.Image = BitmapUtility.GetSpriteImage(editSprite.Tileset, editSprite.Tilemap, editSprite.BGPalette, editSprite.SPRPalette);
        }

        /// <summary>
        /// Gets sprite assests
        /// </summary>
        /// <param name="getOriginal">If getting original data, not edited</param>
        /// <returns>Sprite data</returns>
        private SpriteData GetSpriteData(bool getOriginal)
        {
            Sprite sprite = _project.GetSprite(_spriteID);
            if (sprite == null)
                return null;

            Tilemap tilemap = _project.GetTilemap(sprite.TilemapIDs[_frame], getOriginal);
            Tileset tileset = _project.GetTileset(tilemap.TilesetID, getOriginal);
            Palette bgPalette = _project.GetPalette(sprite.BGPaletteID, getOriginal);
            Palette sprPalette = _project.GetPalette(sprite.SPRPaletteID, getOriginal);
            return new SpriteData(sprite.Name, tilemap, tileset, bgPalette, sprPalette);
        }

        /// <summary>
        /// Original sprite scroll changed
        /// </summary>
        private void pnlOriginalSprite_Scroll(object sender, ScrollEventArgs e)
        {
            pnlEditedSprite.AutoScrollPosition = new Point(-pnlOriginalSprite.AutoScrollPosition.X, -pnlOriginalSprite.AutoScrollPosition.Y);
        }

        /// <summary>
        /// Edited sprite scroll changed
        /// </summary>
        private void pnlEditedSprite_Scroll(object sender, ScrollEventArgs e)
        {
            pnlOriginalSprite.AutoScrollPosition = new Point(-pnlEditedSprite.AutoScrollPosition.X, -pnlEditedSprite.AutoScrollPosition.Y);
        }
    }

    /// <summary>
    /// Sprite data light weight class to store assets the sprite uses
    /// </summary>
    public sealed class SpriteData
    {
        public string Name { get; }
        public Tilemap Tilemap { get; }
        public Tileset Tileset { get; }
        public Palette BGPalette { get; }
        public Palette SPRPalette { get; }

        public SpriteData(string name, Tilemap tilemap, Tileset tileset, Palette bgPalette, Palette sprPalette)
        {
            Name = name;
            Tilemap = tilemap;
            Tileset = tileset;
            BGPalette = bgPalette;
            SPRPalette = sprPalette;
        }
    }
}
