namespace SMSEditor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenROM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuValidateOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslAssetName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSprites = new System.Windows.Forms.TabPage();
            this.tabPalettes = new System.Windows.Forms.TabPage();
            this.tabTilesets = new System.Windows.Forms.TabPage();
            this.tabTilemaps = new System.Windows.Forms.TabPage();
            this.tabSpriteEdits = new System.Windows.Forms.TabPage();
            this.tabDataEntries = new System.Windows.Forms.TabPage();
            this.tabRomImage = new System.Windows.Forms.TabPage();
            this.tabHexView = new System.Windows.Forms.TabPage();
            this.tabOutputMap = new System.Windows.Forms.TabPage();
            this.lblStarting = new System.Windows.Forms.Label();
            this.mnuExportBinarySMS = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSprites = new SMSEditor.Controls.AssetSpriteControl();
            this.pnlPalettes = new SMSEditor.Controls.AssetPaletteControl();
            this.pnlTilesets = new SMSEditor.Controls.AssetTilesetControl();
            this.pnlTilemaps = new SMSEditor.Controls.AssetTilemapControl();
            this.pnlSpriteEdit = new SMSEditor.Controls.AssetEditControl();
            this.pnlDataInjection = new SMSEditor.Controls.AssetDataEntryControl();
            this.pnlRomImage = new SMSEditor.Controls.RomImageControl();
            this.pnlRomHex = new SMSEditor.Controls.RomHexControl();
            this.mnuMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSprites.SuspendLayout();
            this.tabPalettes.SuspendLayout();
            this.tabTilesets.SuspendLayout();
            this.tabTilemaps.SuspendLayout();
            this.tabSpriteEdits.SuspendLayout();
            this.tabDataEntries.SuspendLayout();
            this.tabRomImage.SuspendLayout();
            this.tabHexView.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(840, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuOpenROM,
            this.mnuSave,
            this.mnuSeparator1,
            this.mnuExportBinarySMS,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenProject.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenProject.Text = "&Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuOpenROM
            // 
            this.mnuOpenROM.Image = global::SMSEditor.Properties.Resources.open;
            this.mnuOpenROM.Name = "mnuOpenROM";
            this.mnuOpenROM.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenROM.Text = "Open ROM";
            this.mnuOpenROM.Click += new System.EventHandler(this.mnuOpenROM_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::SMSEditor.Properties.Resources.save;
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(186, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::SMSEditor.Properties.Resources.exit;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(186, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuValidateOutput});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(46, 20);
            this.mnuTools.Text = "&Tools";
            this.mnuTools.Visible = false;
            // 
            // mnuValidateOutput
            // 
            this.mnuValidateOutput.Name = "mnuValidateOutput";
            this.mnuValidateOutput.Size = new System.Drawing.Size(180, 22);
            this.mnuValidateOutput.Text = "Validate Output";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAssetName,
            this.tsslInfo,
            this.tsslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 617);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(840, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslAssetName
            // 
            this.tsslAssetName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslAssetName.Name = "tsslAssetName";
            this.tsslAssetName.Size = new System.Drawing.Size(78, 17);
            this.tsslAssetName.Text = "Asset (None)";
            this.tsslAssetName.Visible = false;
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(89, 17);
            this.tsslInfo.Text = "No Information";
            this.tsslInfo.Visible = false;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(42, 17);
            this.tsslStatus.Text = "Status";
            this.tsslStatus.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblStarting);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMain.Size = new System.Drawing.Size(840, 593);
            this.pnlMain.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSprites);
            this.tabMain.Controls.Add(this.tabPalettes);
            this.tabMain.Controls.Add(this.tabTilesets);
            this.tabMain.Controls.Add(this.tabTilemaps);
            this.tabMain.Controls.Add(this.tabSpriteEdits);
            this.tabMain.Controls.Add(this.tabDataEntries);
            this.tabMain.Controls.Add(this.tabRomImage);
            this.tabMain.Controls.Add(this.tabHexView);
            this.tabMain.Controls.Add(this.tabOutputMap);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(8, 8);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(824, 577);
            this.tabMain.TabIndex = 0;
            this.tabMain.Visible = false;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabSprites
            // 
            this.tabSprites.BackColor = System.Drawing.SystemColors.Control;
            this.tabSprites.Controls.Add(this.pnlSprites);
            this.tabSprites.Location = new System.Drawing.Point(4, 22);
            this.tabSprites.Name = "tabSprites";
            this.tabSprites.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprites.Size = new System.Drawing.Size(816, 551);
            this.tabSprites.TabIndex = 1;
            this.tabSprites.Text = "Sprites";
            // 
            // tabPalettes
            // 
            this.tabPalettes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPalettes.Controls.Add(this.pnlPalettes);
            this.tabPalettes.Location = new System.Drawing.Point(4, 22);
            this.tabPalettes.Name = "tabPalettes";
            this.tabPalettes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPalettes.Size = new System.Drawing.Size(816, 551);
            this.tabPalettes.TabIndex = 2;
            this.tabPalettes.Text = "Palettes";
            // 
            // tabTilesets
            // 
            this.tabTilesets.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilesets.Controls.Add(this.pnlTilesets);
            this.tabTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabTilesets.Name = "tabTilesets";
            this.tabTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesets.Size = new System.Drawing.Size(816, 551);
            this.tabTilesets.TabIndex = 3;
            this.tabTilesets.Text = "Tilesets";
            // 
            // tabTilemaps
            // 
            this.tabTilemaps.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemaps.Controls.Add(this.pnlTilemaps);
            this.tabTilemaps.Location = new System.Drawing.Point(4, 22);
            this.tabTilemaps.Name = "tabTilemaps";
            this.tabTilemaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemaps.Size = new System.Drawing.Size(816, 551);
            this.tabTilemaps.TabIndex = 4;
            this.tabTilemaps.Text = "Tilemaps";
            // 
            // tabSpriteEdits
            // 
            this.tabSpriteEdits.BackColor = System.Drawing.SystemColors.Control;
            this.tabSpriteEdits.Controls.Add(this.pnlSpriteEdit);
            this.tabSpriteEdits.Location = new System.Drawing.Point(4, 22);
            this.tabSpriteEdits.Name = "tabSpriteEdits";
            this.tabSpriteEdits.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpriteEdits.Size = new System.Drawing.Size(816, 551);
            this.tabSpriteEdits.TabIndex = 5;
            this.tabSpriteEdits.Text = "Sprite Edits";
            // 
            // tabDataEntries
            // 
            this.tabDataEntries.BackColor = System.Drawing.SystemColors.Control;
            this.tabDataEntries.Controls.Add(this.pnlDataInjection);
            this.tabDataEntries.Location = new System.Drawing.Point(4, 22);
            this.tabDataEntries.Name = "tabDataEntries";
            this.tabDataEntries.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataEntries.Size = new System.Drawing.Size(816, 551);
            this.tabDataEntries.TabIndex = 6;
            this.tabDataEntries.Text = "Data Entries";
            // 
            // tabRomImage
            // 
            this.tabRomImage.BackColor = System.Drawing.SystemColors.Control;
            this.tabRomImage.Controls.Add(this.pnlRomImage);
            this.tabRomImage.Location = new System.Drawing.Point(4, 22);
            this.tabRomImage.Name = "tabRomImage";
            this.tabRomImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabRomImage.Size = new System.Drawing.Size(816, 551);
            this.tabRomImage.TabIndex = 7;
            this.tabRomImage.Text = "ROM Image";
            // 
            // tabHexView
            // 
            this.tabHexView.BackColor = System.Drawing.SystemColors.Control;
            this.tabHexView.Controls.Add(this.pnlRomHex);
            this.tabHexView.Location = new System.Drawing.Point(4, 22);
            this.tabHexView.Name = "tabHexView";
            this.tabHexView.Padding = new System.Windows.Forms.Padding(3);
            this.tabHexView.Size = new System.Drawing.Size(816, 551);
            this.tabHexView.TabIndex = 8;
            this.tabHexView.Text = "Hex View";
            // 
            // tabOutputMap
            // 
            this.tabOutputMap.BackColor = System.Drawing.SystemColors.Control;
            this.tabOutputMap.Location = new System.Drawing.Point(4, 22);
            this.tabOutputMap.Name = "tabOutputMap";
            this.tabOutputMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutputMap.Size = new System.Drawing.Size(816, 551);
            this.tabOutputMap.TabIndex = 9;
            this.tabOutputMap.Text = "Output Map";
            // 
            // lblStarting
            // 
            this.lblStarting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStarting.Location = new System.Drawing.Point(8, 8);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(824, 577);
            this.lblStarting.TabIndex = 1;
            this.lblStarting.Text = "From the File menu, select Open ROM for a new project, select Open Project for an" +
    " existing one.";
            this.lblStarting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuExportBinarySMS
            // 
            this.mnuExportBinarySMS.Image = global::SMSEditor.Properties.Resources.export_bin;
            this.mnuExportBinarySMS.Name = "mnuExportBinarySMS";
            this.mnuExportBinarySMS.Size = new System.Drawing.Size(186, 22);
            this.mnuExportBinarySMS.Text = "Create ROM (.sms)";
            this.mnuExportBinarySMS.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // pnlSprites
            // 
            this.pnlSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprites.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSprites.Location = new System.Drawing.Point(3, 3);
            this.pnlSprites.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSprites.Name = "pnlSprites";
            this.pnlSprites.Size = new System.Drawing.Size(810, 545);
            this.pnlSprites.TabIndex = 0;
            this.pnlSprites.AssetsChanged += new SMSEditor.Controls.AssetControl.AssetsChangedHandler(this.pnlSprites_AssetsChanged);
            this.pnlSprites.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalettes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPalettes.Location = new System.Drawing.Point(3, 3);
            this.pnlPalettes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(810, 545);
            this.pnlPalettes.TabIndex = 0;
            this.pnlPalettes.AssetsChanged += new SMSEditor.Controls.AssetControl.AssetsChangedHandler(this.pnlPalettes_AssetsChanged);
            this.pnlPalettes.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlTilesets
            // 
            this.pnlTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesets.Location = new System.Drawing.Point(3, 3);
            this.pnlTilesets.Name = "pnlTilesets";
            this.pnlTilesets.Size = new System.Drawing.Size(810, 545);
            this.pnlTilesets.TabIndex = 0;
            this.pnlTilesets.AssetsChanged += new SMSEditor.Controls.AssetControl.AssetsChangedHandler(this.pnlTilesets_AssetsChanged);
            this.pnlTilesets.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlTilemaps
            // 
            this.pnlTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemaps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTilemaps.Location = new System.Drawing.Point(3, 3);
            this.pnlTilemaps.Name = "pnlTilemaps";
            this.pnlTilemaps.Size = new System.Drawing.Size(810, 545);
            this.pnlTilemaps.TabIndex = 0;
            this.pnlTilemaps.AssetsChanged += new SMSEditor.Controls.AssetControl.AssetsChangedHandler(this.pnlTilemaps_AssetsChanged);
            this.pnlTilemaps.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlSpriteEdit
            // 
            this.pnlSpriteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSpriteEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlSpriteEdit.Name = "pnlSpriteEdit";
            this.pnlSpriteEdit.Size = new System.Drawing.Size(810, 545);
            this.pnlSpriteEdit.TabIndex = 0;
            this.pnlSpriteEdit.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlDataInjection
            // 
            this.pnlDataInjection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataInjection.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataInjection.Location = new System.Drawing.Point(3, 3);
            this.pnlDataInjection.Name = "pnlDataInjection";
            this.pnlDataInjection.Size = new System.Drawing.Size(810, 545);
            this.pnlDataInjection.TabIndex = 0;
            this.pnlDataInjection.InfoChanged += new SMSEditor.Controls.AssetControl.InfoChangedHandler(this.pnlAssets_InfoChanged);
            // 
            // pnlRomImage
            // 
            this.pnlRomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRomImage.Location = new System.Drawing.Point(3, 3);
            this.pnlRomImage.Name = "pnlRomImage";
            this.pnlRomImage.Size = new System.Drawing.Size(810, 545);
            this.pnlRomImage.TabIndex = 0;
            // 
            // pnlRomHex
            // 
            this.pnlRomHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRomHex.Location = new System.Drawing.Point(3, 3);
            this.pnlRomHex.Name = "pnlRomHex";
            this.pnlRomHex.Size = new System.Drawing.Size(810, 545);
            this.pnlRomHex.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 639);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(856, 678);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Editor";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSprites.ResumeLayout(false);
            this.tabPalettes.ResumeLayout(false);
            this.tabTilesets.ResumeLayout(false);
            this.tabTilemaps.ResumeLayout(false);
            this.tabSpriteEdits.ResumeLayout(false);
            this.tabDataEntries.ResumeLayout(false);
            this.tabRomImage.ResumeLayout(false);
            this.tabHexView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslAssetName;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenROM;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSprites;
        private System.Windows.Forms.TabPage tabPalettes;
        private System.Windows.Forms.TabPage tabTilesets;
        private System.Windows.Forms.TabPage tabTilemaps;
        private System.Windows.Forms.TabPage tabSpriteEdits;
        private System.Windows.Forms.TabPage tabDataEntries;
        private Controls.AssetSpriteControl pnlSprites;
        private Controls.AssetPaletteControl pnlPalettes;
        private Controls.AssetTilesetControl pnlTilesets;
        private Controls.AssetTilemapControl pnlTilemaps;
        private Controls.AssetEditControl pnlSpriteEdit;
        private Controls.AssetDataEntryControl pnlDataInjection;
        private System.Windows.Forms.TabPage tabRomImage;
        private System.Windows.Forms.TabPage tabHexView;
        private Controls.RomImageControl pnlRomImage;
        private Controls.RomHexControl pnlRomHex;
        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuValidateOutput;
        private System.Windows.Forms.TabPage tabOutputMap;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinarySMS;
    }
}

