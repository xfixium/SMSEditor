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
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Forms
{
    public partial class ImportForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private List<Tilemap> _tilemaps = new List<Tilemap>();
        private Project _project = null;
        private Bitmap _image = null;
        private Palette _bgPalette = null;
        private Palette _sprPalette = null;
        private FlipType _flipType = FlipType.None;
        private int _frame = 0;
        private bool _initalizing = true;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="parent">Parent form that contains the project data</param>
        /// <param name="image">The image being used for the import</param>
        /// <param name="tilemapIDs">The tilemaps that are going to be edited via the import</param>
        /// <param name="importColors">The colors used by the image</param>
        /// <param name="bgPalette">Background palette</param>
        /// <param name="sprPalette">Sprite palette</param>
        public ImportForm(Project parent, Bitmap image, List<int> tilemapIDs, List<Color> importColors, Palette bgPalette, Palette sprPalette)
        {
            InitializeComponent();
            _project = parent;
            _bgPalette = bgPalette;
            _sprPalette = sprPalette;
            _image = image;
            SetPalette(importColors);
            SetTilemaps(tilemapIDs);
            GetTiles();
            cbFlipOptions.SelectedIndex = 0;
            pnlImage.Image = image;
            _initalizing = false;
        }

        /// <summary>
        /// Palette radio button check changed
        /// </summary>
        private void radPalette_CheckedChanged(object sender, EventArgs e)
        {
            pnlPalettes.BGPaletteSelected = radBGPalette.Checked;
        }

        /// <summary>
        /// Flip options combobox selection changed
        /// </summary>
        private void cbFlipOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || _image == null)
                return;

            switch (cbFlipOptions.SelectedIndex)
            {
                case 0: _flipType = FlipType.None; break;
                case 1: _flipType = FlipType.Horizontal; break;
                case 2: _flipType = FlipType.Vertical; break;
                case 3: _flipType = FlipType.Both; break;
            }

            if (!_initalizing)
                GetTiles();
        }

        /// <summary>
        /// Check changed
        /// </summary>
        private void chkOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (!HasData || _image == null)
                return;

            if ((sender as Control).Name == chkShowIndexes.Name)
            {
                pnlTiles.Indexed = chkShowIndexes.Checked;
                return;
            }

            GetTiles();
        }

        /// <summary>
        /// Set all palette button click
        /// </summary>
        private void btnSetAllPalette_Click(object sender, EventArgs e)
        {
            pnlTiles.SetPaletteAll((sender as Control).Name == btnSetAllBGPalette.Name);
        }

        /// <summary>
        /// Frame button click
        /// </summary>
        private void btnFrame_Click(object sender, EventArgs e)
        {
            if (!(sender is Button button) || !HasData || _image == null)
                return;

            if (button.Name == btnPreviousFrame.Name)
                _frame--;
            else if (button.Name == btnNextFrame.Name)
                _frame++;

            if (_frame < 0)
                _frame = 0;

            if (_frame >= _tilemaps.Count)
                _frame = _tilemaps.Count - 1;

            pnlImage.Index = _frame;
            pnlTiles.SelectedTilesetID = _tilemaps[_frame].TilesetID;
            UpdateInfo();
        }

        /// <summary>
        /// Color indexes have shifted
        /// </summary>
        private void pnlColors_ColorShifted()
        {
            pnlTiles.UpdateTiles(pnlPalettes.BGImport, pnlPalettes.SPRImport, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
            UpdateInfo();
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (Tilemap tilemap in _tilemaps)
            {
                List<PixelTile> pixelTiles = pnlTiles.GetPixelTiles(tilemap.TilesetID, true);
                foreach (Tile tile in tilemap.Tiles)
                    for (int i = 0; i < pixelTiles.Count; i++)
                        if (tile.TileID == i + tilemap.Offset)
                            tile.UseBGPalette = pixelTiles[i].UseBGPalette;

                tilemap.SetStatus(null);
                _project.SetTilemap(tilemap);
                var tileset = _project.GetTileset(tilemap.TilesetID, true).DeepClone();
                tileset.Pixels = BitmapUtility.PixelTilesToSMSTiles(pixelTiles, pnlPalettes.BGImport, pnlPalettes.SPRImport);
                tileset.SetStatus(null);
                _project.SetTileset(tileset);
            }

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
        /// Sets the editor tilemaps based on the original tilemaps
        /// </summary>
        /// <param name="tilemapIDs">Tilemaps to edit</param>
        private void SetTilemaps(List<int> tilemapIDs)
        {
            foreach (int tilemapID in tilemapIDs)
            {
                Tilemap tilemap = _project.GetTilemap(tilemapID);
                if (tilemap == null)
                    continue;

                _tilemaps.Add(tilemap.DeepClone());
            }
        }

        /// <summary>
        /// Sets tilesets and related controls
        /// </summary>
        private void GetTiles()
        {
            try
            {
                if (_tilemaps.Count <= 0)
                    return;

                // Reset
                int index = 0;
                _frame = 0;
                pnlTiles.SelectedTilesetID = _tilemaps[_frame].TilesetID;
                pnlTiles.Clear();
                pnlImage.Frames.Clear();

                // TODO: Optimize this junk
                // Consolidate bitmaps
                Dictionary<int, List<int>> imageData = new Dictionary<int, List<int>>();
                foreach (Tilemap tilemap in _tilemaps)
                {
                    Rectangle rect = new Rectangle(new Point(index, _image.Height - tilemap.Size.Height), tilemap.Size);
                    if (imageData.ContainsKey(tilemap.TilesetID))
                        imageData[tilemap.TilesetID].AddRange(BitmapUtility.GetPixelTilesLinear(_image, rect));
                    else
                    {
                        List<int> pixels = new List<int>();
                        pixels.AddRange(BitmapUtility.GetPixelTilesLinear(_image, rect));
                        imageData.Add(tilemap.TilesetID, pixels);
                    }
                    pnlImage.Frames.Add(new Rectangle(new Point(index, _image.Height - tilemap.Size.Height), tilemap.Size));
                    index += tilemap.Size.Width;
                }

                // Create tilesets and tiles
                foreach (Tilemap tilemap in _tilemaps)
                {
                    Tileset tileset = _project.GetTileset(tilemap.TilesetID, true);
                    if (tileset == null)
                        continue;

                    List<int> pixels = imageData[tilemap.TilesetID];
                    using (Bitmap tiles = BitmapUtility.PixelsToBitmap(pixels.ToArray(), 8, (pixels.Count / 64) * 8))
                    {
                        tilemap.Tiles.Clear();
                        List<PixelTile> pixelTiles = BitmapUtility.GetPixelTiles(tiles, tilemap.TilesetID, pnlPalettes.BGImport[0], chkAllowDuplicates.Checked, chkIgnoreEmpty.Checked, _flipType);
                        var position = GetFramePosition(tilemap.ID, tilemap.TilesetID);
                        var framePixels = imageData[tilemap.TilesetID].GetRange(position, tilemap.Columns * tilemap.Rows * 64);
                        using (Bitmap frame = BitmapUtility.PixelsToBitmap(framePixels.ToArray(), 8, (framePixels.Count / 64) * 8))
                        {
                            tilemap.Tiles = BitmapUtility.GetTilesFromImage(pixelTiles, frame, tilemap.Offset + tileset.Offset, _flipType);
                        }

                        // If the tiles weren't already added to the control, add it
                        if (pnlTiles.PixelTiles.Find(x => x.TilesetID == tilemap.TilesetID) == null)
                            pnlTiles.PixelTiles.AddRange(pixelTiles);
                    }
                }

                // Update
                pnlImage.Index = _frame;
                pnlColors_ColorShifted();
            }
            catch
            {
                MessageBox.Show("There was an issue importing the image. Make sure the image is the correct size.");
            }
        }

        /// <summary>
        /// Gets the pixel position of a given tilemap, within tileset pixel data that has been consolidated
        /// </summary>
        /// <param name="tilemapID">The tilemap to get the position for</param>
        /// <param name="tilesetID">The tileset to match to</param>
        /// <returns>Pixel position in the pixel data</returns>
        private int GetFramePosition(int tilemapID, int tilesetID)
        {
            List<Tilemap> tilemaps = _tilemaps.FindAll(x => x.TilesetID == tilesetID);
            int position = 0;
            foreach (Tilemap tilemap in tilemaps)
            {
                if (tilemap.ID == tilemapID)
                    break;

                position = tilemap.Size.Width * tilemap.Size.Height + (position);
            }

            return position;
        }

        /// <summary>
        /// Gets the selected palette
        /// </summary>
        /// <returns>The selected palette</returns>
        private Palette GetPalette()
        {
            return radBGPalette.Checked ? _bgPalette : _sprPalette;
        }

        /// <summary>
        /// Sets the palettes to the imported colors, tries to match them initially
        /// </summary>
        private void SetPalette(List<Color> importColors)
        {
            pnlPalettes.SetPalette(importColors, _bgPalette.Colors, _sprPalette.Colors);
            UpdateInfo();
        }

        /// <summary>
        /// Updates the tileset image and info data
        /// </summary>
        private void UpdateInfo()
        {
            if (!HasData || _tilemaps.Count <= 0)
                return;

            int tilesetID = _tilemaps[_frame].TilesetID;
            Tileset original = _project.GetTileset(tilesetID, true).DeepClone();
            Tileset compiled = original.DeepClone();
            List<PixelTile> pixelTiles = pnlTiles.GetPixelTiles(original.ID, false);
            compiled.Override = true;
            compiled.Pixels = BitmapUtility.PixelTilesToSMSTiles(pixelTiles, pnlPalettes.BGImport, pnlPalettes.SPRImport);
            var bytes = compiled.GetTilesetData(false, false, compiled.Override);
            StatusType status = original.Length < bytes.Length || original.TileCount < pixelTiles.Count ? StatusType.Overflow : StatusType.Good;
            tsslAsset.Text = original.Name + ":";
            sslTileset.Text = "ID: " + original.DataStartString + " | Tile Count: " + pixelTiles.Count + "/" + original.TileCount + " tiles | Length: " + bytes.Length + "/" + original.Length + " bytes | Status:";
            sslStatus.Text = EnumMethods.GetDescription(status);
            sslStatus.ForeColor = status == StatusType.Good ? Color.RoyalBlue : Color.Red;
        }
    }
}
