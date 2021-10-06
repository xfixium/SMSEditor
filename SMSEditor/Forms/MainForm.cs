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
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using SMSEditor.Data;

namespace SMSEditor.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Project _project = null;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _project != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            tabMain.TabPages.Remove(tabRomImage);
            tabMain.TabPages.Remove(tabHexView);
            tabMain.TabPages.Remove(tabOutputMap);
        }

        /// <summary>
        /// Open project menu click
        /// </summary>
        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SMS Editor Project File|*.smsed";
                ofd.Title = "Open Project";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    _project = null;
                    _project = (Project)formatter.Deserialize(fs);
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Open ROM menu click
        /// </summary>
        private void mnuOpenROM_Click(object sender, EventArgs e)
        {
            if (_project != null)
            {
                if (MessageBox.Show("Overwrite the original source ROM data? This may break any asset definitions you may have already created.", "Open ROM", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Master System ROM|*.sms";
                ofd.Title = "Open ROM";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                if (_project == null)
                {
                    _project = new Project(ofd.FileName);
                    LoadData();
                }
                else
                {
                    _project.LoadRomData(ofd.FileName);
                }
            }
        }

        /// <summary>
        /// Save menu click
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!HasData)
            {
                MessageBox.Show("Open a ROM (.sms) or SMS Editor project file (.smsed) first.");
                return;
            }
            using (SaveFileDialog form = new SaveFileDialog())
            {
                form.Filter = "SMS Editor Project File (.smsed)|*.smsed";
                form.Title = "Save Project";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(form.FileName, FileMode.Create))
                    {
                        _project.Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                        formatter.Serialize(fs, _project);
                    }
                }
            }
        }

        /// <summary>
        /// Export menu item click
        /// </summary>
        private void mnuExport_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem menu) || !HasData)
                return;

            if (menu.Name == mnuExportBinarySMS.Name)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Sega Master System File|*.sms";
                    dialog.Title = "Export To Game Binary";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        _project.ExportToBinary(dialog.FileName);
                }
            }
        }

        /// <summary>
        /// Exit menu item click
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// About menu item click
        /// </summary>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm dialog = new AboutForm())
            {
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Main selected tab changed
        /// </summary>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabSprites)
                pnlSprites.OnInfoChanged();
            else if (tabMain.SelectedTab == tabPalettes)
                pnlPalettes.OnInfoChanged();
            else if (tabMain.SelectedTab == tabTilesets)
                pnlTilesets.OnInfoChanged();
            else if (tabMain.SelectedTab == tabTilemaps)
                pnlTilemaps.OnInfoChanged();
            else if (tabMain.SelectedTab == tabSpriteEdits)
                pnlSpriteEdit.OnInfoChanged();
            else if (tabMain.SelectedTab == tabDataEntries)
                pnlDataInjection.OnInfoChanged();
        }

        /// <summary>
        /// Sprite assets changed
        /// </summary>
        private void pnlSprites_AssetsChanged()
        {
            pnlSpriteEdit.UpdateAssets();
        }

        /// <summary>
        /// Palette assets changed
        /// </summary>
        private void pnlPalettes_AssetsChanged()
        {
            pnlSprites.UpdateAssets();
            pnlTilesets.UpdateAssets();
            pnlTilemaps.UpdateAssets();
        }

        /// <summary>
        /// Tileset assets changed
        /// </summary>
        private void pnlTilesets_AssetsChanged()
        {
            pnlSprites.UpdateAssets();
            pnlTilemaps.UpdateAssets();
        }

        /// <summary>
        /// Tilemap assets changed
        /// </summary>
        private void pnlTilemaps_AssetsChanged()
        {
            pnlSprites.UpdateAssets();
        }

        /// <summary>
        /// Sets status bar object information
        /// </summary>
        /// <param name="name">Name of the resource</param>
        /// <param name="info">The information to display</param>
        private void pnlAssets_InfoChanged(GameAsset asset)
        {
            tsslAssetName.Visible = tsslInfo.Visible = tsslStatus.Visible = true;
            tsslAssetName.Text = asset == null ? "Asset ID (None)" : asset.Name + ":";
            tsslInfo.Text = asset == null ? "No Information" : asset.GetInfo(asset is Sprite ? pnlSpriteEdit.SpriteAssets : null) + " | Status:";
            tsslStatus.ForeColor = asset.StatusType == StatusType.Good ? Color.RoyalBlue : asset.StatusType == StatusType.Disabled ? Color.DarkGray : Color.Red;
            tsslStatus.Text = asset.StatusType.ToString();
        }

        /// <summary>
        /// Loads project data for each control
        /// </summary>
        private void LoadData()
        {
            pnlSprites.LoadData(_project);
            pnlPalettes.LoadData(_project);
            pnlTilesets.LoadData(_project);
            pnlTilemaps.LoadData(_project);
            pnlSpriteEdit.LoadData(_project);
            pnlDataInjection.LoadData(_project);
            pnlRomImage.LoadData(_project);
            pnlRomHex.LoadData(_project);
            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
            tabMain.Visible = true;
        }
    }
}
