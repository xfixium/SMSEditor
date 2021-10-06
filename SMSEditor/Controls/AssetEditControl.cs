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
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using SMSEditor.Data;
using SMSEditor.Forms;

namespace SMSEditor.Controls
{
    public partial class AssetEditControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;
        private Sprite _sprite = null;
        private Palette _bgPalette = null;
        private Palette _sprPalette = null;
        private Tileset _tileset = null;
        private Tilemap _tilemap = null;
        private Palette _selectedPalette = null;
        private int _frame = 0;
        private bool _loading = false;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _project != null; } }
        private bool HasAssets { get { return _sprite != null && _bgPalette != null && _sprPalette != null && _tileset != null && _tilemap != null; } }
        public List<GameAsset> SpriteAssets
        {
            get
            {
                if (_tileset == null || _tilemap == null)
                    return null;

                List<GameAsset> assets = new List<GameAsset>();
                assets.Add(_bgPalette);
                assets.Add(_sprPalette);
                assets.Add(_tileset);
                assets.Add(_tilemap);
                return assets;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public AssetEditControl()
        {
            InitializeComponent();
            cbTileEdit.ValueMember = "Value";
            cbTileEdit.DisplayMember = "Description";
            cbTileEdit.DataSource = EnumMethods.GetEnumCollection(typeof(TileEditType));
            if (cbTileEdit.Items.Count > 0)
                cbTileEdit.SelectedIndex = 0;
        }

        /// <summary>
        /// Palette edit menu item click
        /// </summary>
        private void btnEditPalettes_Click(object sender, EventArgs e)
        {
            using (PaletteForm dialog = new PaletteForm(_project))
            {
                dialog.ShowDialog();
                lstSprites_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Frame button click
        /// </summary>
        private void btnFrame_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is Button button) || _sprite == null)
                return;

            if (button.Name == btnPreviousFrame.Name)
                _frame--;
            else if (button.Name == btnNextFrame.Name)
                _frame++;

            if (_frame < 0)
                _frame = 0;

            if (_frame >= _sprite.TilemapIDs.Count)
                _frame = _sprite.TilemapIDs.Count - 1;

            _tilemap = _project.GetTilemap(_sprite.TilemapIDs[_frame]);
            _tileset = _project.GetTileset(_tilemap.TilesetID);
            _loading = true;
            nudTilemapColumns.Value = _tilemap.Columns;
            nudTilemapRows.Value = _tilemap.Rows;
            _loading = false;
            UpdateImages();
        }

        /// <summary>
        /// Sprite selection changed
        /// </summary>
        private void lstSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _loading = true;
                if (!HasData || lstSprites.SelectedItem == null)
                {
                    _loading = false;
                    return;
                }
                   
                _frame = 0;
                _sprite = _project.GetSprite((lstSprites.SelectedItem as GameAsset).ID);
                if (_sprite.TilemapIDs.Count <= 0)
                {
                    _loading = false;
                    return;
                }

                _bgPalette = _project.GetPalette(_sprite.BGPaletteID);
                _sprPalette = _project.GetPalette(_sprite.SPRPaletteID);
                _tilemap = _project.GetTilemap(_sprite.TilemapIDs[_frame]);
                _tileset = _project.GetTileset(_tilemap.TilesetID);
                _selectedPalette = radBackgroundPalette.Checked ? _bgPalette : _sprPalette;
                btnPreviousFrame.Enabled = _sprite.TilemapIDs.Count > 1;
                btnNextFrame.Enabled = _sprite.TilemapIDs.Count > 1;
                chkDisableBGPalette.Checked = _bgPalette.Disable;
                chkDisableSPRPalette.Checked = _sprPalette.Disable;
                chkDisableTileset.Checked = _tileset.Disable;
                chkDisableTilemap.Checked = _tilemap.Disable;
                chkTilesetOverride.Checked = _tileset.Override;
                chkTilemapOverride.Checked = _tilemap.Override;
                nudTilemapColumns.Value = _tilemap.Columns;
                nudTilemapRows.Value = _tilemap.Rows;
                pnlTile.Clear();
                UpdateImages();
                _loading = false;
            }
            catch
            {
                _loading = false;
                return;
            }
        }

        /// <summary>
        /// Context menu item click
        /// </summary>
        private void mnuContextMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HasData || lstSprites.SelectedItem == null)
                    return;

                bool edited = mnuEditedData.Checked;

                // Image options
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Name == mnuImageExportAll.Name)
                    ExportAllSprites();
                else if (item.Name == mnuImageExportSprite.Name)
                    ExportSprite();
                else if (item.Name == mnuImageExportTileset.Name)
                    ExportTileset();

                // Address decimal options
                else if (item.Name == mnuAddrDecCopyBGPalette.Name && _bgPalette != null)
                    Clipboard.SetText(_bgPalette.ID.ToString());
                else if (item.Name == mnuAddrDecCopySPRPalette.Name && _sprPalette != null)
                    Clipboard.SetText(_sprPalette.ID.ToString());
                else if (item.Name == mnuAddrDecCopyTileset.Name && _tileset != null)
                    Clipboard.SetText(_tileset.ID.ToString());
                else if (item.Name == mnuAddrDecCopyTilemap.Name && _tilemap != null)
                    Clipboard.SetText(_tilemap.ID.ToString());

                // Address hexidecimal options
                else if (item.Name == mnuAddrHexCopyBGPalette.Name && _bgPalette != null)
                    Clipboard.SetText(_bgPalette.ID.ToString("X"));
                else if (item.Name == mnuAddrHexCopySPRPalette.Name && _sprPalette != null)
                    Clipboard.SetText(_sprPalette.ID.ToString("X"));
                else if (item.Name == mnuAddrHexCopyTileset.Name && _tileset != null)
                    Clipboard.SetText(_tileset.ID.ToString("X"));
                else if (item.Name == mnuAddrHexCopyTilemap.Name && _tilemap != null)
                    Clipboard.SetText(_tilemap.ID.ToString("X"));

                // Data binary options
                else if (item.Name == mnuDataBinExportBGPalette.Name && _bgPalette != null)
                {
                    Palette palette = edited ? _bgPalette.DeepClone() : _project.GetPalette(_bgPalette.ID, true);
                    palette.Override = mnuDataOverrideLength.Checked;
                    ExportData(palette.GetPaletteData(mnuDataIgnoreCompression.Checked, false), palette.Name);
                }
                else if (item.Name == mnuDataBinExportSPRPalette.Name && _sprPalette != null)
                {
                    Palette palette = edited ? _sprPalette.DeepClone() : _project.GetPalette(_sprPalette.ID, true);
                    palette.Override = mnuDataOverrideLength.Checked;
                    ExportData(palette.GetPaletteData(mnuDataIgnoreCompression.Checked, false), palette.Name);
                }
                else if (item.Name == mnuDataBinExportTileset.Name && _tileset != null)
                {
                    Tileset tileset = edited ? _tileset.DeepClone() : _project.GetTileset(_tileset.ID, true);
                    tileset.Override = mnuDataOverrideLength.Checked;
                    ExportData(tileset.GetTilesetData(mnuDataIgnoreCompression.Checked, false), tileset.Name);
                }
                else if (item.Name == mnuDataBinExportTilemap.Name && _tilemap != null)
                {
                    Tilemap tilemap = edited ? _tilemap.DeepClone() : _project.GetTilemap(_tilemap.ID, true);
                    tilemap.Override = mnuDataOverrideLength.Checked;
                    ExportData(tilemap.GetTilemapData(mnuDataIgnoreCompression.Checked, false), tilemap.Name);
                }

                // Data hexidecimal options
                else if (item.Name == mnuDataHexCopyBGPalette.Name && _bgPalette != null)
                    Clipboard.SetText(edited ? _bgPalette.GetASMString(true) : _project.GetPalette(_bgPalette.ID, true).GetASMString(true));
                else if (item.Name == mnuDataHexCopySPRPalette.Name && _sprPalette != null)
                    Clipboard.SetText(edited ? _sprPalette.GetASMString(true) : _project.GetPalette(_sprPalette.ID, true).GetASMString(true));
                else if (item.Name == mnuDataHexCopyTileset.Name && _tileset != null)
                    Clipboard.SetText(edited ? _tileset.GetASMString(true) : _project.GetTileset(_tileset.ID, true).GetASMString(true));
                else if (item.Name == mnuDataHexCopyTilemap.Name && _tilemap != null)
                    Clipboard.SetText(edited ? _tilemap.GetASMString(true) : _project.GetTilemap(_tilemap.ID, true).GetASMString(true));

                // Data assembly options
                else if (item.Name == mnuDataAsmCopyBGPalette.Name && _bgPalette != null)
                    Clipboard.SetText(edited ? _bgPalette.GetASMString(false) : _project.GetPalette(_bgPalette.ID, true).GetASMString(false));
                else if (item.Name == mnuDataAsmCopySPRPalette.Name && _sprPalette != null)
                    Clipboard.SetText(edited ? _sprPalette.GetASMString(false) : _project.GetPalette(_sprPalette.ID, true).GetASMString(false));
                else if (item.Name == mnuDataAsmCopyTileset.Name && _tileset != null)
                    Clipboard.SetText(edited ? _tileset.GetASMString(false) : _project.GetTileset(_tileset.ID, true).GetASMString(false));
                else if (item.Name == mnuDataAsmCopyTilemap.Name && _tilemap != null)
                    Clipboard.SetText(edited ? _tilemap.GetASMString(false) : _project.GetTilemap(_tilemap.ID, true).GetASMString(false));
            }
            catch
            {

            }
        }

        /// <summary>
        /// Checkbox changed
        /// </summary>
        private void chkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!HasData || _loading)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == chkDisableBGPalette.Name)
            {
                _bgPalette.Disable = chkDisableBGPalette.Checked;
                SetStatus(_bgPalette);
                _project.SetPalette(_bgPalette);
            }
            else if (ctrl.Name == chkDisableSPRPalette.Name)
            {
                _sprPalette.Disable = chkDisableSPRPalette.Checked;
                SetStatus(_sprPalette);
                _project.SetPalette(_sprPalette);
            }
            else if (ctrl.Name == chkDisableTileset.Name)
            {
                _tileset.Disable = chkDisableTileset.Checked;
                SetStatus(_tileset);
                _project.SetTileset(_tileset);
            }
            else if (ctrl.Name == chkDisableTilemap.Name)
            {
                _tilemap.Disable = chkDisableTilemap.Checked;
                SetStatus(_tilemap);
                _project.SetTilemap(_tilemap);
            }
            else if (ctrl.Name == chkTilesetOverride.Name)
            {
                _tileset.Override = chkTilesetOverride.Checked;
                _project.SetTileset(_tileset);
            }
            else if (ctrl.Name == chkTilemapOverride.Name)
            {
                _tilemap.Override = chkTilemapOverride.Checked;
                _project.SetTilemap(_tilemap);
            }
            else if (ctrl.Name == chkTilesetUseGrid.Name)
                pnlTileset.UseGrid = chkTilesetUseGrid.Checked;
            else if (ctrl.Name == chkTilesUseGrid.Name)
            {
                pnlTiles.UseGrid = chkTilesUseGrid.Checked;
                pnlTilemap.UseGrid = chkTilesUseGrid.Checked;
            }
            else if (ctrl.Name == chkTilesetIndexed.Name)
                pnlTileset.Indexed = chkTilesetIndexed.Checked;
            else if (ctrl.Name == chkTilemapIndexed.Name)
            {
                pnlTiles.Indexed = chkTilemapIndexed.Checked;
                pnlTilemap.Indexed = chkTilemapIndexed.Checked;
            }
            else if (ctrl.Name == chkShowIndexesWithOffset.Name)
            {
                pnlTiles.UseOffset = chkShowIndexesWithOffset.Checked;
                pnlTilemap.UseOffset = chkShowIndexesWithOffset.Checked;
                SetIndexes();
            }
            else if (ctrl.Name == chkHighlighter.Name)
            {
                pnlTilemap.Highlight = chkHighlighter.Checked;
                lblHighlighterCountValue.Text = pnlTilemap.HighlightCount.ToString();
            }
            else if (ctrl.Name == radBackgroundPalette.Name)
            {
                _selectedPalette = _bgPalette;
                UpdateImages();
            }
            else if (ctrl.Name == radSpritePalette.Name)
            {
                _selectedPalette = _sprPalette;
                UpdateImages();
            }
        }

        /// <summary>
        /// Sprite options menu opening
        /// </summary>
        private void mnuSpriteOptions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lstSprites.SelectedIndex = lstSprites.IndexFromPoint(lstSprites.PointToClient(Cursor.Position));
            if (lstSprites.SelectedItem == null)
                e.Cancel = true;
        }

        /// <summary>
        /// Tab selection changed
        /// </summary>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabSpriteEditMain.SelectedTab.Name == tabSprite.Name && _sprite != null)
                OnInfoChanged(_sprite);
            else if (tabSpriteEditMain.SelectedTab.Name == tabTileset.Name && _tileset != null)
                OnInfoChanged(_tileset);
            else if (tabSpriteEditMain.SelectedTab.Name == tabTilemap.Name && _tilemap != null)
                OnInfoChanged(_tilemap);
        }

        /// <summary>
        /// Revert button click
        /// </summary>
        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is Button button))
                return;

            if (MessageBox.Show("Are you sure you want to revert? All changes will be lost.", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (button.Name == btnSpriteRevert.Name && _sprite != null)
                _project.RevertSprite(_sprite.ID);
            else if (button.Name == btnRevertTileset.Name && _tileset != null)
                _project.RevertAsset(_tileset.ID);
            else if (button.Name == btnRevertTilemap.Name && _tilemap != null)
                _project.RevertAsset(_tilemap.ID);
            else if (button.Name == btnSpriteRevertPalette.Name && _selectedPalette != null)
                _project.RevertAsset(_selectedPalette.ID);

            _sprite = _project.GetSprite(_sprite.ID);
            _bgPalette = _project.GetPalette(_bgPalette.ID);
            _sprPalette = _project.GetPalette(_sprPalette.ID);
            _tileset = _project.GetTileset(_tileset.ID);
            _tilemap = _project.GetTilemap(_sprite.TilemapIDs[_frame]);
            SetStatus(_sprite);
            UpdateImages();
        }

        /// <summary>
        /// Compare sprite button click
        /// </summary>
        private void btnCompareSprite_Click(object sender, EventArgs e)
        {
            using (CompareForm form = new CompareForm(_project, _sprite.ID))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Import sprite button click
        /// </summary>
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (_sprite == null || _tileset == null || _tilemap == null)
            {
                MessageBox.Show("Select a Sprite to import new data to.");
                return;
            }

            string path = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG Image File|*.png";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                path = ofd.FileName;
            }

            Bitmap image;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                image = (Bitmap)Image.FromStream(fs);
            }

            if (image == null)
            {
                MessageBox.Show("There was an issue getting the image data.");
                return;
            }

            List<Color> importColors = BitmapUtility.GetColors(image);
            if (importColors.Count > 32)
            {
                MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                return;
            }

            if (importColors.Count > 16)
                MessageBox.Show("The image has more than 16 colors, extra colors will be placed into the sprite palette.");

            using (ImportForm form = new ImportForm(_project, image, _sprite.TilemapIDs, importColors, _bgPalette, _sprPalette))
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                lstSprites_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Diable sprite button click
        /// </summary>
        private void btnSpriteDisable_Click(object sender, EventArgs e)
        {
            if (!HasData || !HasAssets)
                return;

            chkDisableBGPalette.Checked = true;
            chkDisableSPRPalette.Checked = true;
            chkDisableTileset.Checked = true;
            chkDisableTilemap.Checked = true;
        }

        /// <summary>
        /// Tileset tile changed
        /// </summary>
        private void pnlTileset_TileChanged()
        {
            if (!HasData || _tileset == null)
                return;

            _tileset.Pixels = pnlTileset.Pixels;
            _project.SetTileset(_tileset);
            SetStatus(_tileset);
            UpdateImages();
        }

        /// <summary>
        /// Tileset tile selection changed
        /// </summary>
        private void pnlTileset_TileSelectionChanged()
        {
            if (!HasData || pnlTileset.TileID < 0 || _tileset == null)
                return;

            pnlTile.TargetColor = 255;
            pnlTile.SelectedTileID = pnlTileset.TileID;
            pnlTile.Palette = _selectedPalette.DeepClone().Colors;
            pnlTile.Pixels = _tileset.GetTilePixels(pnlTileset.TileID);
            pnlTile.Image = BitmapUtility.GetPixelTileImage(pnlTile.Pixels, pnlTile.Palette, pnlTile.ClientSize);
        }

        /// <summary>
        /// Deletes the selected tile from a tileset
        /// </summary>
        private void btnDeleteTile_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            int tileID = pnlTileset.TileID;
            pnlTileset.RemoveSelection();
            _project.SetTileset(_tileset);
            _tilemap.ShiftTiles(-1, tileID);
            _project.SetTilemap(_tilemap);
            SetStatus(_tileset);
            pnlTile.Clear();
            UpdateImages();
        }

        /// <summary>
        /// Deselects the selected tile from a tileset
        /// </summary>
        private void btnDeselectTile_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            pnlTileset.DeselectSelection();
            pnlTile.Clear();
        }

        /// <summary>
        /// Adds a blank tile to the beginning of the tileset
        /// </summary>
        private void btnAddTile_Click(object sender, EventArgs e)
        {
            if (!HasData || _tileset == null)
                return;

            _tileset.AddEmptyTile();
            _project.SetTileset(_tileset);
            _tilemap.ShiftTiles(1);
            _project.SetTilemap(_tilemap);
            SetStatus(_tileset);
            UpdateImages();
        }

        /// <summary>
        /// Tile pixel changed
        /// </summary>
        private void pnlTile_PixelChanged()
        {
            if (!HasData || _tileset == null)
                return;

            _tileset.SetTilePixels(pnlTile.SelectedTileID, pnlTile.Pixels);
            _project.SetTileset(_tileset);
            pnlTile.Image = BitmapUtility.GetPixelTileImage(pnlTile.Pixels, pnlTile.Palette, pnlTile.ClientSize);
            UpdateImages();
        }

        /// <summary>
        /// Tile palette selected color changed
        /// </summary>
        private void pnlTilePalette_SelectedColorChanged()
        {
            if (!HasData)
                return;

            pnlTile.SelectedColor = (byte)pnlTilePalette.SelectedIndex;
        }

        /// <summary>
        /// Swap selected the selected pixel with the select palette color
        /// </summary>
        private void btnSwapSelectedPixel_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            if (pnlTile.SelectedColor == 255)
            {
                MessageBox.Show("No swap color hs been selected. Select a color from the palette.");
                return;
            }

            if (pnlTile.TargetColor == 255)
            {
                MessageBox.Show("No target color hs been selected. Click on a tile pixel to select the color to be swapped.");
                return;
            }

            _tileset.SwapPixels(pnlTile.TargetColor, pnlTile.SelectedColor);
            _project.SetTileset(_tileset);
            pnlTileset_TileSelectionChanged();
            UpdateImages();
        }

        /// <summary>
        /// Properties button click
        /// </summary>
        private void btnProperties_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if ((ctrl.Name == btnTilemapProperties.Name && _tilemap != null) || (ctrl.Name == btnTilesetProperties.Name && _tileset != null))
            {
                if (ctrl.Name == btnTilemapProperties.Name)
                {
                    using (PropertiesForm form = new PropertiesForm(_tilemap))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _tilemap.Position = form.Position;
                            _tilemap.SetAssetProperties(form.GetTilemapProperties());
                            _project.SetTilemap(_tilemap);
                            UpdateImages();
                        }
                    }
                }
                else
                {
                    using (PropertiesForm form = new PropertiesForm(_tileset))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _tileset.Position = form.Position;
                            _project.SetTileset(_tileset);
                            UpdateImages();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Tilemap size changed
        /// </summary>
        private void nudTilemapColumnSize_ValueChanged(object sender, EventArgs e)
        {
            if (!HasData || _tilemap == null || _loading)
                return;

            _tilemap.Columns = (int)nudTilemapColumns.Value;
            _project.SetTilemap(_tilemap);
            SetStatus(_tilemap);
            UpdateImages();
        }

        /// <summary>
        /// Tilemap size changed
        /// </summary>
        private void nudTilemapRowSize_ValueChanged(object sender, EventArgs e)
        {
            if (!HasData || _tilemap == null || _loading)
                return;

            _tilemap.Rows = (int)nudTilemapRows.Value;
            _project.SetTilemap(_tilemap);
            SetStatus(_tilemap);
            UpdateImages();
        }

        /// <summary>
        /// Tile attribute edit selection changed
        /// </summary>
        private void cbTileAttributeEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || !HasAssets || cbTileEdit.SelectedItem == null)
                return;

            pnlTilemap.EditMode = (TileEditType)cbTileEdit.SelectedItem.GetType().GetProperty("value").GetValue(cbTileEdit.SelectedItem, null);
        }

        /// <summary>
        /// Tilemap tile selection changed
        /// </summary>
        private void pnlTiles_TileSelectionChanged()
        {
            if (_tilemap == null || _tileset == null || !HasData)
                return;

            pnlTilemap.TileID = pnlTiles.TileID + _tilemap.Offset;
            lblHighlighterCountValue.Text = pnlTilemap.HighlightCount.ToString();
            SetIndexes();
        }

        /// <summary>
        /// Tilemap tile changed
        /// </summary>
        private void pnlTilemap_TileChanged()
        {
            if (!HasData || !HasAssets)
                return;

            _tilemap.Tiles = pnlTilemap.Tiles;
            _project.SetTilemap(_tilemap);
            pnlSprite.Image = BitmapUtility.GetSpriteImage(_tileset, _tilemap, _bgPalette, _sprPalette);
            pnlTilemap.Image = BitmapUtility.GetSpriteImage(_tileset, _tilemap, _bgPalette, _sprPalette);
        }

        /// <summary>
        /// Replace tiles button click
        /// </summary>
        private void btnReplaceTiles_Click(object sender, EventArgs e)
        {
            if (!HasData || !HasAssets)
                return;

            using (ReplaceForm form = new ReplaceForm(BitmapUtility.GetTilesetImage(_tileset, _selectedPalette, 16), _tileset.TileCount))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _tilemap.ReplaceTiles(form.SourceTileID, form.TargetTileID);
                    _project.SetTilemap(_tilemap);
                    UpdateImages();
                }
            }
        }

        /// <summary>
        /// Loads various data
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            pnlTile.Clear();

            if (!HasData)
                return;

            foreach(Sprite sprite in _project.Sprites)
            {
                Palette bgPalette = _project.PaletteEdits.Find(x => x.ID == sprite.BGPaletteID);
                if (bgPalette != null)
                    bgPalette.SetStatus(null);

                Palette sprPalette = _project.PaletteEdits.Find(x => x.ID == sprite.SPRPaletteID);
                if (sprPalette != null)
                    sprPalette.SetStatus(null);

                foreach (int tilemapID in sprite.TilemapIDs)
                {
                    Tilemap tilemap = _project.TilemapEdits.Find(x => x.ID == tilemapID);
                    if (tilemap != null)
                        tilemap.SetStatus(null);

                    Tileset tileset = _project.TilesetEdits.Find(x => x.ID == (tilemap == null ? -1 : tilemap.TilesetID));
                    if (tileset != null)
                        tileset.SetStatus(null);

                    sprite.SetStatus(new List<GameAsset>() { bgPalette, sprPalette, tileset, tilemap });
                }
            }

            foreach (ListBox lst in new List<ListBox>() { lstSprites })
            {
                lst.Items.Clear();
                foreach (GameAsset obj in _project.Sprites.OrderBy(x => x.Name).ToArray())
                    lst.Items.Add(obj);
            }

            foreach (ListBox lst in new List<ListBox>() { lstSprites })
                if (lst.Items.Count > 0)
                    lst.SelectedIndex = 0;

            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Update image panels based on selections
        /// </summary>
        private void UpdateImages()
        {
            if (!HasData || !HasAssets)
                return;

            pnlSprite.Image = BitmapUtility.GetSpriteImage(_tileset, _tilemap, _bgPalette, _sprPalette);
            pnlTilemap.Image = BitmapUtility.GetSpriteImage(_tileset, _tilemap, _bgPalette, _sprPalette);
            pnlTilemap.SetTilemap(_tilemap.Tiles, _tilemap.Columns, _tilemap.Rows, _tilemap.Offset);
            pnlTilemap.Offset = _tilemap.Offset;
            pnlTileset.Image = BitmapUtility.GetTilesetImage(_tileset, _selectedPalette, 16);
            pnlTileset.SetTileset(_tileset.Pixels, _selectedPalette.Colors, _tileset.Offset);
            pnlTiles.Image = BitmapUtility.GetTilesetImage(_tileset, _selectedPalette, 6);
            pnlTiles.Offset = _tilemap.Offset;
            pnlTiles.TileCount = _tileset.TileCount + _tileset.Offset;
            pnlTilemap.TileID = pnlTiles.TileID;
            SetIndexes();
            pnlSpriteEditBGPalette.SetPalette(_bgPalette.Colors);
            txtSpriteEditBGPalette.Text = _bgPalette.Name;
            pnlSpriteEditSPRPalette.SetPalette(_sprPalette.Colors);
            txtSpriteEditSPRPalette.Text = _sprPalette.Name;
            pnlTilePalette.SetPalette(_selectedPalette.Colors);
            pnlTile.UpdateImage(_selectedPalette.Colors);
            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Exports all sprite images
        /// </summary>
        /// <param name="path">The target file path</param>
        public void ExportAllSprites()
        {
            if (MessageBox.Show("Are you sure you want to export all sprite images? This may take some time to process.", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string path = "";
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath;
                else
                    return;
            }

            bool edited = mnuEditedData.Checked;
            foreach (Sprite sprite in _project.Sprites)
            {
                List<Tilemap> tilemaps = new List<Tilemap>();
                foreach (int id in sprite.TilemapIDs)
                    tilemaps.Add(_project.GetTilemap(id, !edited));

                Palette bgPalette = _project.GetPalette(sprite.BGPaletteID, !edited);
                Palette sprPalette = _project.GetPalette(sprite.SPRPaletteID, !edited);
                foreach (Tilemap tilemap in tilemaps)
                {
                    try
                    {
                        using (Bitmap image = BitmapUtility.GetSpriteImageStrip(tilemaps, _project.GetTilesets(tilemaps, !edited), bgPalette, sprPalette))
                        {
                            image.Save(path + "\\" + sprite.Name + ".png", ImageFormat.Png);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("There was an issue exporting " + path + "\\" + sprite.Name + ".png. A file with the same name may be in use in another application.");
                    }
                }
            }
        }

        /// <summary>
        /// Exports a sprite image
        /// </summary>
        public void ExportSprite()
        {
            bool edited = mnuEditedData.Checked;
            List<Tilemap> tilemaps = new List<Tilemap>();
            foreach (int id in _sprite.TilemapIDs)
                tilemaps.Add(_project.GetTilemap(id, !edited));

            if (!HasAssets || tilemaps.Count <= 0)
            {
                MessageBox.Show("Needed data was not found, the Sprite was not exported.");
                return;
            }

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Sprite Image";
                    dialog.FileName = _sprite.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Palette bgPalette = _project.GetPalette(_bgPalette.ID, !edited);
                        Palette sprPalette = _project.GetPalette(_sprPalette.ID, !edited);
                        using (Bitmap image = BitmapUtility.GetSpriteImageStrip(tilemaps, _project.GetTilesets(tilemaps, !edited), bgPalette, sprPalette))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        public void ExportTileset()
        {
            if (!HasAssets || _tileset == null || _selectedPalette == null)
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
                    dialog.FileName = _tileset.Name;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        bool edited = mnuEditedData.Checked;
                        Palette palette = _project.GetPalette(_selectedPalette.ID, !edited);
                        Tileset tileset = _project.GetTileset(_tileset.ID, !edited);
                        using (Bitmap image = BitmapUtility.GetTilesetImage(tileset, palette, 16))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        public void ExportData(byte[] data, string filename)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Binary Data";
                dialog.Filter = "Binary File|*.bin";
                dialog.FileName = filename;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        using (BinaryWriter bw = new BinaryWriter(fs))
                        {
                            bw.Write(data);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sets display indexes with or without the offset
        /// </summary>
        private void SetIndexes()
        {
            if (!HasData || _tilemap == null)
                return;

            lblSelectedTileIDValue.Text = (pnlTiles.TileID + (chkShowIndexesWithOffset.Checked ? _tilemap.Offset : 0)).ToString();
        }

        /// <summary>
        /// External call to info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Update the asset status, and sprite status
        /// </summary>
        /// <param name="asset">The asset to update the status of</param>
        private void SetStatus(GameAsset asset)
        {
            if (asset == null)
                return;

            List<GameAsset> assets = new List<GameAsset>() { _bgPalette, _sprPalette, _tileset, _tilemap };
            if (!(asset is Sprite))
                asset.SetStatus(null);

            _sprite.SetStatus(assets);
            OnInfoChanged();
        }

        /// <summary>
        /// Updates any asset dependents
        /// </summary>
        public void UpdateAssets()
        {
            object asset = lstSprites.SelectedItem;
            foreach (ListBox lst in new List<ListBox>() { lstSprites })
            {
                lst.Items.Clear();
                foreach (GameAsset obj in _project.Sprites.OrderBy(x => x.Name).ToArray())
                    lst.Items.Add(obj);
            }

            asset = _project.Sprites.Find(x => x.ID == (asset as GameAsset).ID);
            lstSprites.SelectedItem = asset ?? (lstSprites.Items.Count > 0 ? lstSprites.Items[0] : asset);
            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
        }
    }
}
