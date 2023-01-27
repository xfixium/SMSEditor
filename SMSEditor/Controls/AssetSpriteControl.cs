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
    public partial class AssetSpriteControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;
        private int _spriteID = -1;

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetSpriteControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Context menu item click
        /// </summary>
        private void mnuContextMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save asset button click
        /// </summary>
        private void btnAsset_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == btnSpriteSave.Name)
                SaveSprite();
            else if (ctrl.Name == btnSpriteRemove.Name)
                RemoveSprite();
            else if (ctrl.Name == btnSpriteTilemapAdd.Name && cbSpriteTilemap.SelectedItem != null)
                AddTilemap();
            else if (ctrl.Name == btnSpriteTilemapMoveUp.Name && lstSpriteTilemaps.SelectedItem != null)
                MoveTilemapUp();
            else if (ctrl.Name == btnSpriteTilemapMoveDown.Name && lstSpriteTilemaps.SelectedItem != null)
                MoveTilemapDown();
            else if (ctrl.Name == btnSpriteTilemapRemove.Name && lstSpriteTilemaps.SelectedItem != null)
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
            if (ctrl.Name == lstSprites.Name && lstSprites.SelectedItem != null)
                SetSpriteData(_project.GetSprite((lstSprites.SelectedItem as GameAsset).ID));
            else if (ctrl.Name == lstSpriteTilemaps.Name)
                UpdateImage();

            OnInfoChanged(GetSpriteData());
        }

        /// <summary>
        /// Asset property selection changed
        /// </summary>
        private void cbAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            Control ctrl = sender as Control;
            if (ctrl.Name == cbSpriteBGPalette.Name || ctrl.Name == cbSpriteSPRPalette.Name)
                SetPalettes();
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(Project project)
        {
            _project = project;
            if (!HasData)
                return;

            foreach (ComboBox ctrl in new List<ComboBox>() { cbSpriteTilemap })
            {
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Tilemaps.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            UpdateAssets();

            lstSprites.Items.Clear();
            lstSprites.Items.AddRange(_project.Sprites.Cast<GameAsset>().OrderBy(x => x.Name).ToArray());
            foreach (ListBox ctrl in new List<ListBox>() { lstSprites })
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
        }

        /// <summary>
        /// Saves a new sprite, or updates an existing one
        /// </summary>
        private void SaveSprite()
        {
            if (!HasData)
                return;

            Sprite sprite = GetSpriteData();
            if (sprite.Name.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the sprite.");
                return;
            }

            if (sprite.TilemapIDs == null || sprite.TilemapIDs.Count <= 0)
            {
                MessageBox.Show("Please add at least one tilemap to the sprite.");
                return;
            }

            if (_project.Sprites.Find(x => x.Name.ToLower() == sprite.Name.ToLower()) != null)
            {
                _project.Sprites[_project.Sprites.FindIndex(x => x.Name.ToLower() == sprite.Name.ToLower())] = sprite.DeepClone();
                lstSprites.Items[lstSprites.SelectedIndex] = sprite.DeepClone();
            }
            else
            {
                sprite.ID = _project.Sprites.Count <= 0 ? 0 : _project.Sprites.Max(x => x.ID) + 1;
                _project.Sprites.Add(sprite);
                LoadData(_project);
                lstSprites.SelectedItem = sprite;
            }

            OnAssetsChanged();
        }

        /// <summary>
        /// Removes a selected sprite
        /// </summary>
        private void RemoveSprite()
        {
            if (!HasData || lstSprites.SelectedItem == null)
                return;

            if (MessageBox.Show("Are you sure you want to remove sprite: " + txtSpriteName.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _project.RemoveSprite((lstSprites.SelectedItem as GameAsset).ID);
            LoadData(_project);
            OnAssetsChanged();
        }

        /// <summary>
        /// Loads selected sprite data to UI
        /// </summary>
        private Sprite GetSpriteData()
        {
            try
            {
                if (!HasData)
                {
                    pnlSpriteImage.Image = null;
                    return null;
                }

                Sprite sprite = new Sprite();
                sprite.Name = txtSpriteName.Text;
                sprite.BGPaletteID = (cbSpriteBGPalette.SelectedItem as GameAsset).ID;
                sprite.SPRPaletteID = (cbSpriteSPRPalette.SelectedItem as GameAsset).ID;
                sprite.ID = _spriteID;
                foreach (object tilemap in lstSpriteTilemaps.Items)
                    sprite.TilemapIDs.Add((tilemap as Tilemap).ID);

                return sprite;
            }
            catch
            {
                pnlSpriteImage.Image = null;
                return null;
            }
        }

        /// <summary>
        /// Loads selected sprite data to UI
        /// </summary>
        private void SetSpriteData(Sprite sprite)
        {
            try
            {
                if (!HasData)
                    return;

                txtSpriteName.Text = sprite.Name;
                cbSpriteBGPalette.SelectedItem = ItemByID(sprite.BGPaletteID, cbSpriteBGPalette);
                if (cbSpriteBGPalette.SelectedItem == null && cbSpriteBGPalette.Items.Count > 0)
                    cbSpriteBGPalette.SelectedIndex = 0;
                cbSpriteSPRPalette.SelectedItem = ItemByID(sprite.SPRPaletteID, cbSpriteSPRPalette);
                if (cbSpriteSPRPalette.SelectedItem == null && cbSpriteSPRPalette.Items.Count > 0)
                    cbSpriteSPRPalette.SelectedIndex = 0;
                _spriteID = sprite.ID;
                object selected = lstSpriteTilemaps.SelectedItem;
                lstSpriteTilemaps.Items.Clear();
                foreach (int tilemapID in sprite.TilemapIDs)
                    lstSpriteTilemaps.Items.Add(_project.GetTilemap(tilemapID, true) as GameAsset);

                if (selected != null && lstSpriteTilemaps.Items.Contains(selected))
                    lstSpriteTilemaps.SelectedItem = selected;
                else if (lstSpriteTilemaps.Items.Count > 0)
                    lstSpriteTilemaps.SelectedIndex = 0;

                UpdateImage();
            }
            catch
            {
                pnlSpriteImage.Image = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddTilemap()
        {
            if (!HasData)
                return;

            int id = (cbSpriteTilemap.SelectedItem as GameAsset).ID;
            Tilemap tilemap = _project.GetTilemap(id, true);
            lstSpriteTilemaps.Items.Add(tilemap);
            lstSpriteTilemaps.SelectedItem = tilemap;
        }

        /// <summary>
        /// Moves selected tilemap up the list
        /// </summary>
        private void MoveTilemapUp()
        {
            if (!HasData || lstSpriteTilemaps.SelectedIndex <= 0)
                return;

            int oldindex = lstSpriteTilemaps.SelectedIndex;
            int newIndex = oldindex - 1;
            Tilemap item = lstSpriteTilemaps.Items[oldindex] as Tilemap;
            lstSpriteTilemaps.Items.RemoveAt(oldindex);
            lstSpriteTilemaps.Items.Insert(newIndex, item);
            lstSpriteTilemaps.SelectedIndex = newIndex;
        }

        /// <summary>
        /// Moves selected tilemap down the list
        /// </summary>
        private void MoveTilemapDown()
        {
            if (!HasData || lstSpriteTilemaps.SelectedIndex < 0 || lstSpriteTilemaps.SelectedIndex >= lstSpriteTilemaps.Items.Count - 1)
                return;

            int oldindex = lstSpriteTilemaps.SelectedIndex;
            int newIndex = oldindex + 1;
            Tilemap item = lstSpriteTilemaps.Items[oldindex] as Tilemap;
            lstSpriteTilemaps.Items.RemoveAt(oldindex);
            lstSpriteTilemaps.Items.Insert(newIndex, item);
            lstSpriteTilemaps.SelectedIndex = newIndex;
        }

        /// <summary>
        /// Removes the selected tilemap
        /// </summary>
        private void RemoveTilemap()
        {
            if (!HasData)
                return;

            lstSpriteTilemaps.Items.Remove(lstSpriteTilemaps.SelectedItem);
            if (lstSpriteTilemaps.Items.Count > 0)
                lstSpriteTilemaps.SelectedIndex = 0;
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
            foreach (ComboBox ctrl in new List<ComboBox>() { cbSpriteBGPalette, cbSpriteSPRPalette })
            {
                var colors = Palette.Empty;
                PaletteControl paletteCtrl = ctrl.Name == cbSpriteBGPalette.Name ? pnlSpriteBGPalette : pnlSpriteSPRPalette;
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
        /// Trigger info changed event handler
        /// </summary>
        public void OnInfoChanged()
        {
            OnInfoChanged(lstSprites.SelectedItem == null ? null : GetSpriteData());
        }

        /// <summary>
        /// Updates the sprite image
        /// </summary>
        private void UpdateImage()
        {
            try
            {
                Palette bgPalette = GetPalette(cbSpriteBGPalette);
                Palette sprPalette = GetPalette(cbSpriteSPRPalette);
                Tilemap tilemap = lstSpriteTilemaps.SelectedItem == null ? null : lstSpriteTilemaps.SelectedItem as Tilemap;
                Tileset tileset = _project.GetTileset(tilemap == null ? -1 : tilemap.TilesetID, true);
                if (tilemap == null || tileset == null || bgPalette == null || sprPalette == null)
                {
                    pnlSpriteImage.Image = null;
                    return;
                }

                pnlSpriteBGPalette.SetPalette(bgPalette.Colors);
                pnlSpriteSPRPalette.SetPalette(sprPalette.Colors);
                pnlSpriteImage.Image = BitmapUtility.GetSpriteImage(tileset, tilemap, bgPalette, sprPalette);
            }
            catch
            {
                pnlSpriteImage.Image = null;
            }
        }

        /// <summary>
        /// Updates asset references
        /// </summary>
        public void UpdateAssets()
        {
            foreach (ComboBox ctrl in new List<ComboBox>() { cbSpriteBGPalette, cbSpriteSPRPalette })
            {
                object selected = ctrl.SelectedItem;
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Palettes.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (selected != null && ctrl.Items.Contains(selected))
                    ctrl.SelectedItem = selected;
                else
                    ctrl.SelectedIndex = 0;
            }

            foreach (ComboBox ctrl in new List<ComboBox>() { cbSpriteTilemap })
            {
                ctrl.Items.Clear();
                ctrl.Items.AddRange(_project.Tilemaps.Cast<GameAsset>().OrderBy(x => x.ID).ToArray());
                if (ctrl.Items.Count > 0)
                    ctrl.SelectedIndex = 0;
            }

            SetPalettes();
        }
    }
}
