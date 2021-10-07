namespace SMSEditor.Controls
{
    partial class AssetEditControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetEditControl));
            this.tabSpriteEditMain = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.pnlSprite = new SMSEditor.Controls.ImageControl();
            this.pnlSpriteTools = new System.Windows.Forms.Panel();
            this.btnSpriteEnable = new System.Windows.Forms.Button();
            this.chkDisableSPRPalette = new System.Windows.Forms.CheckBox();
            this.chkDisableBGPalette = new System.Windows.Forms.CheckBox();
            this.btnSpriteDisable = new System.Windows.Forms.Button();
            this.btnEditPalette = new System.Windows.Forms.Button();
            this.txtSpriteEditSPRPalette = new System.Windows.Forms.TextBox();
            this.txtSpriteEditBGPalette = new System.Windows.Forms.TextBox();
            this.btnSpriteCompare = new System.Windows.Forms.Button();
            this.lblSpriteEditSPRPalette = new System.Windows.Forms.Label();
            this.pnlSpriteEditSPRPalette = new SMSEditor.Controls.PaletteControl();
            this.lblSpriteEditBGPalette = new System.Windows.Forms.Label();
            this.btnSpriteRevert = new System.Windows.Forms.Button();
            this.btnSpriteImport = new System.Windows.Forms.Button();
            this.pnlSpriteEditBGPalette = new SMSEditor.Controls.PaletteControl();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.pnlTileset = new SMSEditor.Controls.TilesetControl();
            this.pnlTilesetTools = new System.Windows.Forms.Panel();
            this.btnSpriteRevertPalette = new System.Windows.Forms.Button();
            this.chkDisableTileset = new System.Windows.Forms.CheckBox();
            this.btnTilesetProperties = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTilesetOverride = new System.Windows.Forms.CheckBox();
            this.btnAddTile = new System.Windows.Forms.Button();
            this.btnSwapSelectedPixel = new System.Windows.Forms.Button();
            this.pnlTilePalette = new SMSEditor.Controls.PaletteControl();
            this.lblSelectedPalette = new System.Windows.Forms.Label();
            this.radSpritePalette = new System.Windows.Forms.RadioButton();
            this.radBackgroundPalette = new System.Windows.Forms.RadioButton();
            this.lblTile = new System.Windows.Forms.Label();
            this.pnlTile = new SMSEditor.Controls.TileControl();
            this.chkTilesetUseGrid = new System.Windows.Forms.CheckBox();
            this.btnDeselectTile = new System.Windows.Forms.Button();
            this.btnDeleteTile = new System.Windows.Forms.Button();
            this.chkTilesetIndexed = new System.Windows.Forms.CheckBox();
            this.btnRevertTileset = new System.Windows.Forms.Button();
            this.tabTilemap = new System.Windows.Forms.TabPage();
            this.pnlTilemap = new SMSEditor.Controls.TilemapControl();
            this.pnlTilemapTools = new System.Windows.Forms.Panel();
            this.pnlTiles = new SMSEditor.Controls.TilesControl();
            this.pnlTilemapToolsContainer = new System.Windows.Forms.Panel();
            this.chkShowIndexesWithOffset = new System.Windows.Forms.CheckBox();
            this.chkDisableTilemap = new System.Windows.Forms.CheckBox();
            this.btnTilemapProperties = new System.Windows.Forms.Button();
            this.grpTilemapDivider = new System.Windows.Forms.GroupBox();
            this.chkTilemapOverride = new System.Windows.Forms.CheckBox();
            this.lblTilemapRows = new System.Windows.Forms.Label();
            this.lblTilemapColumns = new System.Windows.Forms.Label();
            this.nudTilemapRows = new System.Windows.Forms.NumericUpDown();
            this.nudTilemapColumns = new System.Windows.Forms.NumericUpDown();
            this.lblHighlighterCountValue = new System.Windows.Forms.Label();
            this.chkHighlighter = new System.Windows.Forms.CheckBox();
            this.lblTileEdit = new System.Windows.Forms.Label();
            this.cbTileEdit = new System.Windows.Forms.ComboBox();
            this.lblSelectedTileIDValue = new System.Windows.Forms.Label();
            this.btnReplaceTiles = new System.Windows.Forms.Button();
            this.lblSelectedTileID = new System.Windows.Forms.Label();
            this.chkTilesUseGrid = new System.Windows.Forms.CheckBox();
            this.chkTilemapIndexed = new System.Windows.Forms.CheckBox();
            this.btnRevertTilemap = new System.Windows.Forms.Button();
            this.grpSpriteList = new System.Windows.Forms.GroupBox();
            this.lstSprites = new SMSEditor.Controls.ListBoxControl();
            this.mnuSpriteOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditedData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImageExportSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageExportTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrDec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrDecCopyBGPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrDecCopySPRPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrDecCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrDecCopyTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrHexCopyBGPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrHexCopySPRPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrHexCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddrHexCopyTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataIgnoreCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataOverrideLength = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDataBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataBinExportBGPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataBinExportSPRPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataBinExportTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataBinExportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHexCopyBGPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHexCopySPRPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHexCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataHexCopyTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAsmCopyBGPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAsmCopySPRPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAsmCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAsmCopyTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSpriteListTools = new System.Windows.Forms.Panel();
            this.lblSpriteTilemap = new System.Windows.Forms.Label();
            this.btnPreviousFrame = new System.Windows.Forms.Button();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.tpnlSpriteEditMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabSpriteEditMain.SuspendLayout();
            this.tabSprite.SuspendLayout();
            this.pnlSpriteTools.SuspendLayout();
            this.tabTileset.SuspendLayout();
            this.pnlTilesetTools.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.pnlTilemapTools.SuspendLayout();
            this.pnlTilemapToolsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).BeginInit();
            this.grpSpriteList.SuspendLayout();
            this.mnuSpriteOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSpriteListTools.SuspendLayout();
            this.tpnlSpriteEditMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSpriteEditMain
            // 
            this.tabSpriteEditMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSpriteEditMain.Controls.Add(this.tabSprite);
            this.tabSpriteEditMain.Controls.Add(this.tabTileset);
            this.tabSpriteEditMain.Controls.Add(this.tabTilemap);
            this.tabSpriteEditMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSpriteEditMain.Location = new System.Drawing.Point(196, 3);
            this.tabSpriteEditMain.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tabSpriteEditMain.Name = "tabSpriteEditMain";
            this.tabSpriteEditMain.SelectedIndex = 0;
            this.tabSpriteEditMain.Size = new System.Drawing.Size(611, 538);
            this.tabSpriteEditMain.TabIndex = 1;
            this.tabSpriteEditMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabSprite
            // 
            this.tabSprite.BackColor = System.Drawing.SystemColors.Control;
            this.tabSprite.Controls.Add(this.pnlSprite);
            this.tabSprite.Controls.Add(this.pnlSpriteTools);
            this.tabSprite.Location = new System.Drawing.Point(4, 25);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprite.Size = new System.Drawing.Size(603, 509);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            // 
            // pnlSprite
            // 
            this.pnlSprite.AutoScroll = true;
            this.pnlSprite.AutoScrollMinSize = new System.Drawing.Size(425, 503);
            this.pnlSprite.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSprite.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSprite.Centered = true;
            this.pnlSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprite.HatchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.pnlSprite.HatchForeColor = System.Drawing.Color.White;
            this.pnlSprite.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSprite.Image = null;
            this.pnlSprite.ImageAlpha = 1F;
            this.pnlSprite.ImageScale = 1;
            this.pnlSprite.Location = new System.Drawing.Point(3, 3);
            this.pnlSprite.MinimumScale = 1;
            this.pnlSprite.Name = "pnlSprite";
            this.pnlSprite.Size = new System.Drawing.Size(425, 503);
            this.pnlSprite.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSprite.TabIndex = 0;
            this.pnlSprite.UseCanvas = false;
            this.pnlSprite.UseHatch = true;
            this.pnlSprite.UseMouseWheelScaling = true;
            // 
            // pnlSpriteTools
            // 
            this.pnlSpriteTools.Controls.Add(this.btnSpriteEnable);
            this.pnlSpriteTools.Controls.Add(this.chkDisableSPRPalette);
            this.pnlSpriteTools.Controls.Add(this.chkDisableBGPalette);
            this.pnlSpriteTools.Controls.Add(this.btnSpriteDisable);
            this.pnlSpriteTools.Controls.Add(this.btnEditPalette);
            this.pnlSpriteTools.Controls.Add(this.txtSpriteEditSPRPalette);
            this.pnlSpriteTools.Controls.Add(this.txtSpriteEditBGPalette);
            this.pnlSpriteTools.Controls.Add(this.btnSpriteCompare);
            this.pnlSpriteTools.Controls.Add(this.lblSpriteEditSPRPalette);
            this.pnlSpriteTools.Controls.Add(this.pnlSpriteEditSPRPalette);
            this.pnlSpriteTools.Controls.Add(this.lblSpriteEditBGPalette);
            this.pnlSpriteTools.Controls.Add(this.btnSpriteRevert);
            this.pnlSpriteTools.Controls.Add(this.btnSpriteImport);
            this.pnlSpriteTools.Controls.Add(this.pnlSpriteEditBGPalette);
            this.pnlSpriteTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpriteTools.Location = new System.Drawing.Point(428, 3);
            this.pnlSpriteTools.Name = "pnlSpriteTools";
            this.pnlSpriteTools.Size = new System.Drawing.Size(172, 503);
            this.pnlSpriteTools.TabIndex = 1;
            // 
            // btnSpriteEnable
            // 
            this.btnSpriteEnable.Location = new System.Drawing.Point(8, 120);
            this.btnSpriteEnable.Name = "btnSpriteEnable";
            this.btnSpriteEnable.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteEnable.TabIndex = 5;
            this.btnSpriteEnable.Text = "Enable Sprite Edit";
            this.btnSpriteEnable.UseVisualStyleBackColor = true;
            this.btnSpriteEnable.Click += new System.EventHandler(this.btnSpriteDisable_Click);
            // 
            // chkDisableSPRPalette
            // 
            this.chkDisableSPRPalette.AutoSize = true;
            this.chkDisableSPRPalette.Location = new System.Drawing.Point(8, 336);
            this.chkDisableSPRPalette.Name = "chkDisableSPRPalette";
            this.chkDisableSPRPalette.Size = new System.Drawing.Size(125, 17);
            this.chkDisableSPRPalette.TabIndex = 13;
            this.chkDisableSPRPalette.Text = "Disable Palette Edit";
            this.chkDisableSPRPalette.UseVisualStyleBackColor = true;
            this.chkDisableSPRPalette.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // chkDisableBGPalette
            // 
            this.chkDisableBGPalette.AutoSize = true;
            this.chkDisableBGPalette.Location = new System.Drawing.Point(8, 232);
            this.chkDisableBGPalette.Name = "chkDisableBGPalette";
            this.chkDisableBGPalette.Size = new System.Drawing.Size(125, 17);
            this.chkDisableBGPalette.TabIndex = 9;
            this.chkDisableBGPalette.Text = "Disable Palette Edit";
            this.chkDisableBGPalette.UseVisualStyleBackColor = true;
            this.chkDisableBGPalette.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnSpriteDisable
            // 
            this.btnSpriteDisable.Location = new System.Drawing.Point(8, 96);
            this.btnSpriteDisable.Name = "btnSpriteDisable";
            this.btnSpriteDisable.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteDisable.TabIndex = 4;
            this.btnSpriteDisable.Text = "Disable Sprite Edit";
            this.btnSpriteDisable.UseVisualStyleBackColor = true;
            this.btnSpriteDisable.Click += new System.EventHandler(this.btnSpriteDisable_Click);
            // 
            // btnEditPalette
            // 
            this.btnEditPalette.Location = new System.Drawing.Point(8, 72);
            this.btnEditPalette.Name = "btnEditPalette";
            this.btnEditPalette.Size = new System.Drawing.Size(160, 23);
            this.btnEditPalette.TabIndex = 3;
            this.btnEditPalette.Text = "Edit Palettes";
            this.btnEditPalette.UseVisualStyleBackColor = true;
            this.btnEditPalette.Click += new System.EventHandler(this.btnEditPalettes_Click);
            // 
            // txtSpriteEditSPRPalette
            // 
            this.txtSpriteEditSPRPalette.Location = new System.Drawing.Point(8, 272);
            this.txtSpriteEditSPRPalette.Name = "txtSpriteEditSPRPalette";
            this.txtSpriteEditSPRPalette.ReadOnly = true;
            this.txtSpriteEditSPRPalette.Size = new System.Drawing.Size(160, 22);
            this.txtSpriteEditSPRPalette.TabIndex = 11;
            // 
            // txtSpriteEditBGPalette
            // 
            this.txtSpriteEditBGPalette.Location = new System.Drawing.Point(8, 168);
            this.txtSpriteEditBGPalette.Name = "txtSpriteEditBGPalette";
            this.txtSpriteEditBGPalette.ReadOnly = true;
            this.txtSpriteEditBGPalette.Size = new System.Drawing.Size(160, 22);
            this.txtSpriteEditBGPalette.TabIndex = 7;
            // 
            // btnSpriteCompare
            // 
            this.btnSpriteCompare.Location = new System.Drawing.Point(8, 48);
            this.btnSpriteCompare.Name = "btnSpriteCompare";
            this.btnSpriteCompare.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteCompare.TabIndex = 2;
            this.btnSpriteCompare.Text = "Compare Sprite";
            this.btnSpriteCompare.UseVisualStyleBackColor = true;
            this.btnSpriteCompare.Click += new System.EventHandler(this.btnCompareSprite_Click);
            // 
            // lblSpriteEditSPRPalette
            // 
            this.lblSpriteEditSPRPalette.AutoSize = true;
            this.lblSpriteEditSPRPalette.Location = new System.Drawing.Point(8, 256);
            this.lblSpriteEditSPRPalette.Name = "lblSpriteEditSPRPalette";
            this.lblSpriteEditSPRPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSpriteEditSPRPalette.TabIndex = 10;
            this.lblSpriteEditSPRPalette.Text = "Sprite Palette:";
            this.lblSpriteEditSPRPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpriteEditSPRPalette
            // 
            this.pnlSpriteEditSPRPalette.Location = new System.Drawing.Point(8, 296);
            this.pnlSpriteEditSPRPalette.Name = "pnlSpriteEditSPRPalette";
            this.pnlSpriteEditSPRPalette.ReadOnly = false;
            this.pnlSpriteEditSPRPalette.Size = new System.Drawing.Size(160, 40);
            this.pnlSpriteEditSPRPalette.TabIndex = 12;
            // 
            // lblSpriteEditBGPalette
            // 
            this.lblSpriteEditBGPalette.AutoSize = true;
            this.lblSpriteEditBGPalette.Location = new System.Drawing.Point(8, 152);
            this.lblSpriteEditBGPalette.Name = "lblSpriteEditBGPalette";
            this.lblSpriteEditBGPalette.Size = new System.Drawing.Size(110, 13);
            this.lblSpriteEditBGPalette.TabIndex = 6;
            this.lblSpriteEditBGPalette.Text = "Background Palette:";
            this.lblSpriteEditBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpriteRevert
            // 
            this.btnSpriteRevert.Location = new System.Drawing.Point(8, 24);
            this.btnSpriteRevert.Name = "btnSpriteRevert";
            this.btnSpriteRevert.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteRevert.TabIndex = 1;
            this.btnSpriteRevert.Text = "Revert Sprite";
            this.btnSpriteRevert.UseVisualStyleBackColor = true;
            this.btnSpriteRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnSpriteImport
            // 
            this.btnSpriteImport.Location = new System.Drawing.Point(8, 0);
            this.btnSpriteImport.Name = "btnSpriteImport";
            this.btnSpriteImport.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteImport.TabIndex = 0;
            this.btnSpriteImport.Text = "Import Sprite Graphics";
            this.btnSpriteImport.UseVisualStyleBackColor = true;
            this.btnSpriteImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlSpriteEditBGPalette
            // 
            this.pnlSpriteEditBGPalette.Location = new System.Drawing.Point(8, 192);
            this.pnlSpriteEditBGPalette.Name = "pnlSpriteEditBGPalette";
            this.pnlSpriteEditBGPalette.ReadOnly = false;
            this.pnlSpriteEditBGPalette.Size = new System.Drawing.Size(160, 40);
            this.pnlSpriteEditBGPalette.TabIndex = 8;
            // 
            // tabTileset
            // 
            this.tabTileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileset.Controls.Add(this.pnlTileset);
            this.tabTileset.Controls.Add(this.pnlTilesetTools);
            this.tabTileset.Location = new System.Drawing.Point(4, 25);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(603, 509);
            this.tabTileset.TabIndex = 1;
            this.tabTileset.Text = "Tileset";
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(425, 503);
            this.pnlTileset.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileset.Centered = true;
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileset.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileset.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageAlpha = 1F;
            this.pnlTileset.ImageScale = 1;
            this.pnlTileset.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlTileset.Indexed = false;
            this.pnlTileset.Location = new System.Drawing.Point(3, 3);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(425, 503);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 0;
            this.pnlTileset.UseCanvas = false;
            this.pnlTileset.UseGrid = true;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = true;
            this.pnlTileset.TileSelectionChanged += new SMSEditor.Controls.TilesetControl.TileSelectionHandler(this.pnlTileset_TileSelectionChanged);
            this.pnlTileset.TilesChanged += new SMSEditor.Controls.TilesetControl.TilesChangedHandler(this.pnlTileset_TileChanged);
            // 
            // pnlTilesetTools
            // 
            this.pnlTilesetTools.Controls.Add(this.btnSpriteRevertPalette);
            this.pnlTilesetTools.Controls.Add(this.chkDisableTileset);
            this.pnlTilesetTools.Controls.Add(this.btnTilesetProperties);
            this.pnlTilesetTools.Controls.Add(this.groupBox1);
            this.pnlTilesetTools.Controls.Add(this.chkTilesetOverride);
            this.pnlTilesetTools.Controls.Add(this.btnAddTile);
            this.pnlTilesetTools.Controls.Add(this.btnSwapSelectedPixel);
            this.pnlTilesetTools.Controls.Add(this.pnlTilePalette);
            this.pnlTilesetTools.Controls.Add(this.lblSelectedPalette);
            this.pnlTilesetTools.Controls.Add(this.radSpritePalette);
            this.pnlTilesetTools.Controls.Add(this.radBackgroundPalette);
            this.pnlTilesetTools.Controls.Add(this.lblTile);
            this.pnlTilesetTools.Controls.Add(this.pnlTile);
            this.pnlTilesetTools.Controls.Add(this.chkTilesetUseGrid);
            this.pnlTilesetTools.Controls.Add(this.btnDeselectTile);
            this.pnlTilesetTools.Controls.Add(this.btnDeleteTile);
            this.pnlTilesetTools.Controls.Add(this.chkTilesetIndexed);
            this.pnlTilesetTools.Controls.Add(this.btnRevertTileset);
            this.pnlTilesetTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTilesetTools.Location = new System.Drawing.Point(428, 3);
            this.pnlTilesetTools.Name = "pnlTilesetTools";
            this.pnlTilesetTools.Size = new System.Drawing.Size(172, 503);
            this.pnlTilesetTools.TabIndex = 1;
            // 
            // btnSpriteRevertPalette
            // 
            this.btnSpriteRevertPalette.Location = new System.Drawing.Point(8, 228);
            this.btnSpriteRevertPalette.Name = "btnSpriteRevertPalette";
            this.btnSpriteRevertPalette.Size = new System.Drawing.Size(160, 23);
            this.btnSpriteRevertPalette.TabIndex = 13;
            this.btnSpriteRevertPalette.Text = "Revert Palette";
            this.btnSpriteRevertPalette.UseVisualStyleBackColor = true;
            this.btnSpriteRevertPalette.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // chkDisableTileset
            // 
            this.chkDisableTileset.AutoSize = true;
            this.chkDisableTileset.Location = new System.Drawing.Point(8, 138);
            this.chkDisableTileset.Name = "chkDisableTileset";
            this.chkDisableTileset.Size = new System.Drawing.Size(123, 17);
            this.chkDisableTileset.TabIndex = 6;
            this.chkDisableTileset.Text = "Disable Tileset Edit";
            this.chkDisableTileset.UseVisualStyleBackColor = true;
            this.chkDisableTileset.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnTilesetProperties
            // 
            this.btnTilesetProperties.Location = new System.Drawing.Point(8, 0);
            this.btnTilesetProperties.Name = "btnTilesetProperties";
            this.btnTilesetProperties.Size = new System.Drawing.Size(160, 23);
            this.btnTilesetProperties.TabIndex = 0;
            this.btnTilesetProperties.Text = "Tileset Properties";
            this.btnTilesetProperties.UseVisualStyleBackColor = true;
            this.btnTilesetProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-2, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 5);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // chkTilesetOverride
            // 
            this.chkTilesetOverride.AutoSize = true;
            this.chkTilesetOverride.Location = new System.Drawing.Point(8, 122);
            this.chkTilesetOverride.Name = "chkTilesetOverride";
            this.chkTilesetOverride.Size = new System.Drawing.Size(154, 17);
            this.chkTilesetOverride.TabIndex = 5;
            this.chkTilesetOverride.Text = "Override Original Length";
            this.chkTilesetOverride.UseVisualStyleBackColor = true;
            this.chkTilesetOverride.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnAddTile
            // 
            this.btnAddTile.Location = new System.Drawing.Point(8, 72);
            this.btnAddTile.Name = "btnAddTile";
            this.btnAddTile.Size = new System.Drawing.Size(160, 23);
            this.btnAddTile.TabIndex = 3;
            this.btnAddTile.Text = "Add Tile";
            this.btnAddTile.UseVisualStyleBackColor = true;
            this.btnAddTile.Click += new System.EventHandler(this.btnAddTile_Click);
            // 
            // btnSwapSelectedPixel
            // 
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(6, 456);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(162, 23);
            this.btnSwapSelectedPixel.TabIndex = 17;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            this.btnSwapSelectedPixel.Click += new System.EventHandler(this.btnSwapSelectedPixel_Click);
            // 
            // pnlTilePalette
            // 
            this.pnlTilePalette.Location = new System.Drawing.Point(4, 416);
            this.pnlTilePalette.Name = "pnlTilePalette";
            this.pnlTilePalette.ReadOnly = false;
            this.pnlTilePalette.Size = new System.Drawing.Size(168, 40);
            this.pnlTilePalette.TabIndex = 16;
            this.pnlTilePalette.SelectedColorChanged += new SMSEditor.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlTilePalette_SelectedColorChanged);
            // 
            // lblSelectedPalette
            // 
            this.lblSelectedPalette.AutoSize = true;
            this.lblSelectedPalette.Location = new System.Drawing.Point(8, 192);
            this.lblSelectedPalette.Name = "lblSelectedPalette";
            this.lblSelectedPalette.Size = new System.Drawing.Size(91, 13);
            this.lblSelectedPalette.TabIndex = 10;
            this.lblSelectedPalette.Text = "Selected Palette:";
            // 
            // radSpritePalette
            // 
            this.radSpritePalette.AutoSize = true;
            this.radSpritePalette.Location = new System.Drawing.Point(104, 208);
            this.radSpritePalette.Name = "radSpritePalette";
            this.radSpritePalette.Size = new System.Drawing.Size(55, 17);
            this.radSpritePalette.TabIndex = 12;
            this.radSpritePalette.Text = "Sprite";
            this.radSpritePalette.UseVisualStyleBackColor = true;
            this.radSpritePalette.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // radBackgroundPalette
            // 
            this.radBackgroundPalette.AutoSize = true;
            this.radBackgroundPalette.Checked = true;
            this.radBackgroundPalette.Location = new System.Drawing.Point(12, 208);
            this.radBackgroundPalette.Name = "radBackgroundPalette";
            this.radBackgroundPalette.Size = new System.Drawing.Size(87, 17);
            this.radBackgroundPalette.TabIndex = 11;
            this.radBackgroundPalette.TabStop = true;
            this.radBackgroundPalette.Text = "Background";
            this.radBackgroundPalette.UseVisualStyleBackColor = true;
            this.radBackgroundPalette.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Location = new System.Drawing.Point(8, 256);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(74, 13);
            this.lblTile.TabIndex = 14;
            this.lblTile.Text = "Selected Tile:";
            // 
            // pnlTile
            // 
            this.pnlTile.AutoScroll = true;
            this.pnlTile.AutoScrollMinSize = new System.Drawing.Size(144, 144);
            this.pnlTile.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTile.Centered = false;
            this.pnlTile.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTile.HatchForeColor = System.Drawing.Color.White;
            this.pnlTile.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTile.Image = null;
            this.pnlTile.ImageAlpha = 1F;
            this.pnlTile.ImageScale = 1;
            this.pnlTile.Location = new System.Drawing.Point(16, 272);
            this.pnlTile.MinimumScale = 1;
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Palette = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pnlTile.Palette")));
            this.pnlTile.Pixels = ((System.Collections.Generic.List<byte>)(resources.GetObject("pnlTile.Pixels")));
            this.pnlTile.SelectedColor = ((byte)(0));
            this.pnlTile.SelectedTileID = 0;
            this.pnlTile.Size = new System.Drawing.Size(144, 144);
            this.pnlTile.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTile.TabIndex = 15;
            this.pnlTile.TargetColor = ((byte)(0));
            this.pnlTile.UseCanvas = false;
            this.pnlTile.UseHatch = true;
            this.pnlTile.UseMouseWheelScaling = false;
            this.pnlTile.PixelChanged += new SMSEditor.Controls.TileControl.PixelChangedHandler(this.pnlTile_PixelChanged);
            // 
            // chkTilesetUseGrid
            // 
            this.chkTilesetUseGrid.AutoSize = true;
            this.chkTilesetUseGrid.Checked = true;
            this.chkTilesetUseGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetUseGrid.Location = new System.Drawing.Point(8, 172);
            this.chkTilesetUseGrid.Name = "chkTilesetUseGrid";
            this.chkTilesetUseGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetUseGrid.TabIndex = 8;
            this.chkTilesetUseGrid.Text = "Grid";
            this.chkTilesetUseGrid.UseVisualStyleBackColor = true;
            this.chkTilesetUseGrid.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnDeselectTile
            // 
            this.btnDeselectTile.Location = new System.Drawing.Point(8, 48);
            this.btnDeselectTile.Name = "btnDeselectTile";
            this.btnDeselectTile.Size = new System.Drawing.Size(160, 23);
            this.btnDeselectTile.TabIndex = 2;
            this.btnDeselectTile.Text = "Deselect Tile";
            this.btnDeselectTile.UseVisualStyleBackColor = true;
            this.btnDeselectTile.Click += new System.EventHandler(this.btnDeselectTile_Click);
            // 
            // btnDeleteTile
            // 
            this.btnDeleteTile.Location = new System.Drawing.Point(8, 96);
            this.btnDeleteTile.Name = "btnDeleteTile";
            this.btnDeleteTile.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteTile.TabIndex = 4;
            this.btnDeleteTile.Text = "Delete Tile";
            this.btnDeleteTile.UseVisualStyleBackColor = true;
            this.btnDeleteTile.Click += new System.EventHandler(this.btnDeleteTile_Click);
            // 
            // chkTilesetIndexed
            // 
            this.chkTilesetIndexed.AutoSize = true;
            this.chkTilesetIndexed.Location = new System.Drawing.Point(64, 172);
            this.chkTilesetIndexed.Name = "chkTilesetIndexed";
            this.chkTilesetIndexed.Size = new System.Drawing.Size(97, 17);
            this.chkTilesetIndexed.TabIndex = 9;
            this.chkTilesetIndexed.Text = "Show Indexes";
            this.chkTilesetIndexed.UseVisualStyleBackColor = true;
            this.chkTilesetIndexed.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnRevertTileset
            // 
            this.btnRevertTileset.Location = new System.Drawing.Point(8, 24);
            this.btnRevertTileset.Name = "btnRevertTileset";
            this.btnRevertTileset.Size = new System.Drawing.Size(160, 23);
            this.btnRevertTileset.TabIndex = 1;
            this.btnRevertTileset.Text = "Revert Tileset";
            this.btnRevertTileset.UseVisualStyleBackColor = true;
            this.btnRevertTileset.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // tabTilemap
            // 
            this.tabTilemap.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemap.Controls.Add(this.pnlTilemap);
            this.tabTilemap.Controls.Add(this.pnlTilemapTools);
            this.tabTilemap.Location = new System.Drawing.Point(4, 25);
            this.tabTilemap.Name = "tabTilemap";
            this.tabTilemap.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemap.Size = new System.Drawing.Size(603, 509);
            this.tabTilemap.TabIndex = 2;
            this.tabTilemap.Text = "Tilemap";
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.AutoScroll = true;
            this.pnlTilemap.AutoScrollMinSize = new System.Drawing.Size(425, 503);
            this.pnlTilemap.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemap.Centered = true;
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.EditMode = SMSEditor.Data.TileEditType.TileID;
            this.pnlTilemap.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemap.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemap.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemap.Highlight = false;
            this.pnlTilemap.Image = null;
            this.pnlTilemap.ImageAlpha = 1F;
            this.pnlTilemap.ImageScale = 1;
            this.pnlTilemap.Indexed = false;
            this.pnlTilemap.Location = new System.Drawing.Point(3, 3);
            this.pnlTilemap.MinimumScale = 1;
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Offset = 0;
            this.pnlTilemap.Placeholder = false;
            this.pnlTilemap.Size = new System.Drawing.Size(425, 503);
            this.pnlTilemap.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemap.TabIndex = 0;
            this.pnlTilemap.TileID = -1;
            this.pnlTilemap.UseCanvas = false;
            this.pnlTilemap.UseGrid = true;
            this.pnlTilemap.UseHatch = true;
            this.pnlTilemap.UseMouseWheelScaling = true;
            this.pnlTilemap.UseOffset = false;
            this.pnlTilemap.TileChanged += new SMSEditor.Controls.TilemapControl.TileChangedHandler(this.pnlTilemap_TileChanged);
            // 
            // pnlTilemapTools
            // 
            this.pnlTilemapTools.Controls.Add(this.pnlTiles);
            this.pnlTilemapTools.Controls.Add(this.pnlTilemapToolsContainer);
            this.pnlTilemapTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTilemapTools.Location = new System.Drawing.Point(428, 3);
            this.pnlTilemapTools.Name = "pnlTilemapTools";
            this.pnlTilemapTools.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlTilemapTools.Size = new System.Drawing.Size(172, 503);
            this.pnlTilemapTools.TabIndex = 2;
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(441, 618);
            this.pnlTiles.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = false;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 3;
            this.pnlTiles.Indexed = false;
            this.pnlTiles.Location = new System.Drawing.Point(8, 280);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(164, 223);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 0;
            this.pnlTiles.TileCount = 0;
            this.pnlTiles.TileID = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseGrid = true;
            this.pnlTiles.UseHatch = false;
            this.pnlTiles.UseMouseWheelScaling = false;
            this.pnlTiles.UseOffset = false;
            this.pnlTiles.TileSelectionChanged += new SMSEditor.Controls.TilesControl.TileSelectionHandler(this.pnlTiles_TileSelectionChanged);
            // 
            // pnlTilemapToolsContainer
            // 
            this.pnlTilemapToolsContainer.Controls.Add(this.chkShowIndexesWithOffset);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkDisableTilemap);
            this.pnlTilemapToolsContainer.Controls.Add(this.btnTilemapProperties);
            this.pnlTilemapToolsContainer.Controls.Add(this.grpTilemapDivider);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkTilemapOverride);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblTilemapRows);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblTilemapColumns);
            this.pnlTilemapToolsContainer.Controls.Add(this.nudTilemapRows);
            this.pnlTilemapToolsContainer.Controls.Add(this.nudTilemapColumns);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblHighlighterCountValue);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkHighlighter);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblTileEdit);
            this.pnlTilemapToolsContainer.Controls.Add(this.cbTileEdit);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblSelectedTileIDValue);
            this.pnlTilemapToolsContainer.Controls.Add(this.btnReplaceTiles);
            this.pnlTilemapToolsContainer.Controls.Add(this.lblSelectedTileID);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkTilesUseGrid);
            this.pnlTilemapToolsContainer.Controls.Add(this.chkTilemapIndexed);
            this.pnlTilemapToolsContainer.Controls.Add(this.btnRevertTilemap);
            this.pnlTilemapToolsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapToolsContainer.Location = new System.Drawing.Point(8, 0);
            this.pnlTilemapToolsContainer.Name = "pnlTilemapToolsContainer";
            this.pnlTilemapToolsContainer.Size = new System.Drawing.Size(164, 280);
            this.pnlTilemapToolsContainer.TabIndex = 0;
            // 
            // chkShowIndexesWithOffset
            // 
            this.chkShowIndexesWithOffset.AutoSize = true;
            this.chkShowIndexesWithOffset.Location = new System.Drawing.Point(0, 248);
            this.chkShowIndexesWithOffset.Name = "chkShowIndexesWithOffset";
            this.chkShowIndexesWithOffset.Size = new System.Drawing.Size(158, 17);
            this.chkShowIndexesWithOffset.TabIndex = 16;
            this.chkShowIndexesWithOffset.Text = "Show Tile IDs With Offset";
            this.chkShowIndexesWithOffset.UseVisualStyleBackColor = true;
            this.chkShowIndexesWithOffset.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // chkDisableTilemap
            // 
            this.chkDisableTilemap.AutoSize = true;
            this.chkDisableTilemap.Location = new System.Drawing.Point(0, 128);
            this.chkDisableTilemap.Name = "chkDisableTilemap";
            this.chkDisableTilemap.Size = new System.Drawing.Size(130, 17);
            this.chkDisableTilemap.TabIndex = 8;
            this.chkDisableTilemap.Text = "Disable Tilemap Edit";
            this.chkDisableTilemap.UseVisualStyleBackColor = true;
            this.chkDisableTilemap.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnTilemapProperties
            // 
            this.btnTilemapProperties.Location = new System.Drawing.Point(0, 0);
            this.btnTilemapProperties.Name = "btnTilemapProperties";
            this.btnTilemapProperties.Size = new System.Drawing.Size(160, 23);
            this.btnTilemapProperties.TabIndex = 0;
            this.btnTilemapProperties.Text = "Tilemap Properties";
            this.btnTilemapProperties.UseVisualStyleBackColor = true;
            this.btnTilemapProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // grpTilemapDivider
            // 
            this.grpTilemapDivider.Location = new System.Drawing.Point(-2, 152);
            this.grpTilemapDivider.Name = "grpTilemapDivider";
            this.grpTilemapDivider.Size = new System.Drawing.Size(176, 5);
            this.grpTilemapDivider.TabIndex = 9;
            this.grpTilemapDivider.TabStop = false;
            // 
            // chkTilemapOverride
            // 
            this.chkTilemapOverride.AutoSize = true;
            this.chkTilemapOverride.Location = new System.Drawing.Point(0, 112);
            this.chkTilemapOverride.Name = "chkTilemapOverride";
            this.chkTilemapOverride.Size = new System.Drawing.Size(154, 17);
            this.chkTilemapOverride.TabIndex = 7;
            this.chkTilemapOverride.Text = "Override Original Length";
            this.chkTilemapOverride.UseVisualStyleBackColor = true;
            this.chkTilemapOverride.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // lblTilemapRows
            // 
            this.lblTilemapRows.AutoSize = true;
            this.lblTilemapRows.Location = new System.Drawing.Point(80, 72);
            this.lblTilemapRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapRows.Name = "lblTilemapRows";
            this.lblTilemapRows.Size = new System.Drawing.Size(38, 13);
            this.lblTilemapRows.TabIndex = 5;
            this.lblTilemapRows.Text = "Rows:";
            this.lblTilemapRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapColumns
            // 
            this.lblTilemapColumns.AutoSize = true;
            this.lblTilemapColumns.Location = new System.Drawing.Point(0, 72);
            this.lblTilemapColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapColumns.Name = "lblTilemapColumns";
            this.lblTilemapColumns.Size = new System.Drawing.Size(55, 13);
            this.lblTilemapColumns.TabIndex = 3;
            this.lblTilemapColumns.Text = "Columns:";
            this.lblTilemapColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilemapRows
            // 
            this.nudTilemapRows.Location = new System.Drawing.Point(80, 88);
            this.nudTilemapRows.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapRows.Name = "nudTilemapRows";
            this.nudTilemapRows.Size = new System.Drawing.Size(72, 22);
            this.nudTilemapRows.TabIndex = 6;
            this.nudTilemapRows.ValueChanged += new System.EventHandler(this.nudTilemapRowSize_ValueChanged);
            // 
            // nudTilemapColumns
            // 
            this.nudTilemapColumns.Location = new System.Drawing.Point(0, 88);
            this.nudTilemapColumns.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapColumns.Name = "nudTilemapColumns";
            this.nudTilemapColumns.Size = new System.Drawing.Size(72, 22);
            this.nudTilemapColumns.TabIndex = 4;
            this.nudTilemapColumns.ValueChanged += new System.EventHandler(this.nudTilemapColumnSize_ValueChanged);
            // 
            // lblHighlighterCountValue
            // 
            this.lblHighlighterCountValue.AutoSize = true;
            this.lblHighlighterCountValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlighterCountValue.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblHighlighterCountValue.Location = new System.Drawing.Point(112, 265);
            this.lblHighlighterCountValue.Name = "lblHighlighterCountValue";
            this.lblHighlighterCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblHighlighterCountValue.TabIndex = 18;
            this.lblHighlighterCountValue.Text = "0";
            // 
            // chkHighlighter
            // 
            this.chkHighlighter.AutoSize = true;
            this.chkHighlighter.Location = new System.Drawing.Point(0, 264);
            this.chkHighlighter.Name = "chkHighlighter";
            this.chkHighlighter.Size = new System.Drawing.Size(113, 17);
            this.chkHighlighter.TabIndex = 17;
            this.chkHighlighter.Text = "Highlight Count:";
            this.chkHighlighter.UseVisualStyleBackColor = true;
            this.chkHighlighter.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // lblTileEdit
            // 
            this.lblTileEdit.AutoSize = true;
            this.lblTileEdit.Location = new System.Drawing.Point(0, 188);
            this.lblTileEdit.Name = "lblTileEdit";
            this.lblTileEdit.Size = new System.Drawing.Size(100, 13);
            this.lblTileEdit.TabIndex = 12;
            this.lblTileEdit.Text = "Tile Attribute Edit:";
            // 
            // cbTileEdit
            // 
            this.cbTileEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTileEdit.FormattingEnabled = true;
            this.cbTileEdit.Location = new System.Drawing.Point(0, 204);
            this.cbTileEdit.Name = "cbTileEdit";
            this.cbTileEdit.Size = new System.Drawing.Size(160, 21);
            this.cbTileEdit.TabIndex = 13;
            this.cbTileEdit.SelectedIndexChanged += new System.EventHandler(this.cbTileAttributeEdit_SelectedIndexChanged);
            // 
            // lblSelectedTileIDValue
            // 
            this.lblSelectedTileIDValue.AutoSize = true;
            this.lblSelectedTileIDValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTileIDValue.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSelectedTileIDValue.Location = new System.Drawing.Point(88, 231);
            this.lblSelectedTileIDValue.Name = "lblSelectedTileIDValue";
            this.lblSelectedTileIDValue.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedTileIDValue.TabIndex = 15;
            this.lblSelectedTileIDValue.Text = "0";
            // 
            // btnReplaceTiles
            // 
            this.btnReplaceTiles.Location = new System.Drawing.Point(0, 48);
            this.btnReplaceTiles.Name = "btnReplaceTiles";
            this.btnReplaceTiles.Size = new System.Drawing.Size(160, 23);
            this.btnReplaceTiles.TabIndex = 2;
            this.btnReplaceTiles.Text = "Replace Tiles";
            this.btnReplaceTiles.UseVisualStyleBackColor = true;
            this.btnReplaceTiles.Click += new System.EventHandler(this.btnReplaceTiles_Click);
            // 
            // lblSelectedTileID
            // 
            this.lblSelectedTileID.AutoSize = true;
            this.lblSelectedTileID.Location = new System.Drawing.Point(0, 232);
            this.lblSelectedTileID.Name = "lblSelectedTileID";
            this.lblSelectedTileID.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedTileID.TabIndex = 14;
            this.lblSelectedTileID.Text = "Selected Tile ID:";
            // 
            // chkTilesUseGrid
            // 
            this.chkTilesUseGrid.AutoSize = true;
            this.chkTilesUseGrid.Checked = true;
            this.chkTilesUseGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesUseGrid.Location = new System.Drawing.Point(0, 164);
            this.chkTilesUseGrid.Name = "chkTilesUseGrid";
            this.chkTilesUseGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesUseGrid.TabIndex = 10;
            this.chkTilesUseGrid.Text = "Grid";
            this.chkTilesUseGrid.UseVisualStyleBackColor = true;
            this.chkTilesUseGrid.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // chkTilemapIndexed
            // 
            this.chkTilemapIndexed.AutoSize = true;
            this.chkTilemapIndexed.Location = new System.Drawing.Point(48, 164);
            this.chkTilemapIndexed.Name = "chkTilemapIndexed";
            this.chkTilemapIndexed.Size = new System.Drawing.Size(109, 17);
            this.chkTilemapIndexed.TabIndex = 11;
            this.chkTilemapIndexed.Text = "Show Attributes";
            this.chkTilemapIndexed.UseVisualStyleBackColor = true;
            this.chkTilemapIndexed.CheckedChanged += new System.EventHandler(this.chkCheckBox_CheckedChanged);
            // 
            // btnRevertTilemap
            // 
            this.btnRevertTilemap.Location = new System.Drawing.Point(0, 24);
            this.btnRevertTilemap.Name = "btnRevertTilemap";
            this.btnRevertTilemap.Size = new System.Drawing.Size(160, 23);
            this.btnRevertTilemap.TabIndex = 1;
            this.btnRevertTilemap.Text = "Revert Tilemap";
            this.btnRevertTilemap.UseVisualStyleBackColor = true;
            this.btnRevertTilemap.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // grpSpriteList
            // 
            this.grpSpriteList.Controls.Add(this.lstSprites);
            this.grpSpriteList.Controls.Add(this.panel1);
            this.grpSpriteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSpriteList.Location = new System.Drawing.Point(0, 0);
            this.grpSpriteList.Margin = new System.Windows.Forms.Padding(0);
            this.grpSpriteList.Name = "grpSpriteList";
            this.grpSpriteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpSpriteList.Size = new System.Drawing.Size(196, 544);
            this.grpSpriteList.TabIndex = 0;
            this.grpSpriteList.TabStop = false;
            this.grpSpriteList.Text = "Select Sprite To Edit";
            // 
            // lstSprites
            // 
            this.lstSprites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSprites.ContextMenuStrip = this.mnuSpriteOptions;
            this.lstSprites.DisableHighlighting = false;
            this.lstSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSprites.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstSprites.FormattingEnabled = true;
            this.lstSprites.HorizontalExtent = 170;
            this.lstSprites.IntegralHeight = false;
            this.lstSprites.ItemHeight = 15;
            this.lstSprites.Location = new System.Drawing.Point(12, 42);
            this.lstSprites.Name = "lstSprites";
            this.lstSprites.Size = new System.Drawing.Size(172, 490);
            this.lstSprites.TabIndex = 1;
            this.lstSprites.TextOffsetX = 2;
            this.lstSprites.TextOffsetY = -1;
            this.lstSprites.SelectedIndexChanged += new System.EventHandler(this.lstSprites_SelectedIndexChanged);
            // 
            // mnuSpriteOptions
            // 
            this.mnuSpriteOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditedData,
            this.toolStripMenuItem4,
            this.mnuImage,
            this.mnuAddress,
            this.mnuData});
            this.mnuSpriteOptions.Name = "mnuInfo";
            this.mnuSpriteOptions.Size = new System.Drawing.Size(135, 98);
            this.mnuSpriteOptions.Opening += new System.ComponentModel.CancelEventHandler(this.mnuSpriteOptions_Opening);
            // 
            // mnuEditedData
            // 
            this.mnuEditedData.Checked = true;
            this.mnuEditedData.CheckOnClick = true;
            this.mnuEditedData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuEditedData.Name = "mnuEditedData";
            this.mnuEditedData.Size = new System.Drawing.Size(134, 22);
            this.mnuEditedData.Text = "Edited Data";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(131, 6);
            // 
            // mnuImage
            // 
            this.mnuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImageExportAll,
            this.toolStripMenuItem2,
            this.mnuImageExportSprite,
            this.mnuImageExportTileset});
            this.mnuImage.Name = "mnuImage";
            this.mnuImage.Size = new System.Drawing.Size(134, 22);
            this.mnuImage.Text = "Image";
            // 
            // mnuImageExportAll
            // 
            this.mnuImageExportAll.Image = global::SMSEditor.Properties.Resources.export_image;
            this.mnuImageExportAll.Name = "mnuImageExportAll";
            this.mnuImageExportAll.Size = new System.Drawing.Size(199, 22);
            this.mnuImageExportAll.Text = "Export All Sprite Images";
            this.mnuImageExportAll.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuImageExportSprite
            // 
            this.mnuImageExportSprite.Image = global::SMSEditor.Properties.Resources.export_image;
            this.mnuImageExportSprite.Name = "mnuImageExportSprite";
            this.mnuImageExportSprite.Size = new System.Drawing.Size(199, 22);
            this.mnuImageExportSprite.Text = "Export Sprite Image";
            this.mnuImageExportSprite.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuImageExportTileset
            // 
            this.mnuImageExportTileset.Image = global::SMSEditor.Properties.Resources.export_image;
            this.mnuImageExportTileset.Name = "mnuImageExportTileset";
            this.mnuImageExportTileset.Size = new System.Drawing.Size(199, 22);
            this.mnuImageExportTileset.Text = "Export Tileset Image";
            this.mnuImageExportTileset.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddress
            // 
            this.mnuAddress.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddrDec,
            this.mnuAddrHex});
            this.mnuAddress.Name = "mnuAddress";
            this.mnuAddress.Size = new System.Drawing.Size(134, 22);
            this.mnuAddress.Text = "Address";
            // 
            // mnuAddrDec
            // 
            this.mnuAddrDec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddrDecCopyBGPalette,
            this.mnuAddrDecCopySPRPalette,
            this.mnuAddrDecCopyTileset,
            this.mnuAddrDecCopyTilemap});
            this.mnuAddrDec.Name = "mnuAddrDec";
            this.mnuAddrDec.Size = new System.Drawing.Size(143, 22);
            this.mnuAddrDec.Text = "Decimal";
            // 
            // mnuAddrDecCopyBGPalette
            // 
            this.mnuAddrDecCopyBGPalette.Name = "mnuAddrDecCopyBGPalette";
            this.mnuAddrDecCopyBGPalette.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrDecCopyBGPalette.Text = "Copy BG Palette Address";
            this.mnuAddrDecCopyBGPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrDecCopySPRPalette
            // 
            this.mnuAddrDecCopySPRPalette.Name = "mnuAddrDecCopySPRPalette";
            this.mnuAddrDecCopySPRPalette.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrDecCopySPRPalette.Text = "Copy SPR Palette Address";
            this.mnuAddrDecCopySPRPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrDecCopyTileset
            // 
            this.mnuAddrDecCopyTileset.Name = "mnuAddrDecCopyTileset";
            this.mnuAddrDecCopyTileset.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrDecCopyTileset.Text = "Copy Tileset Address";
            this.mnuAddrDecCopyTileset.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrDecCopyTilemap
            // 
            this.mnuAddrDecCopyTilemap.Name = "mnuAddrDecCopyTilemap";
            this.mnuAddrDecCopyTilemap.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrDecCopyTilemap.Text = "Copy Tilemap Address";
            this.mnuAddrDecCopyTilemap.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrHex
            // 
            this.mnuAddrHex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddrHexCopyBGPalette,
            this.mnuAddrHexCopySPRPalette,
            this.mnuAddrHexCopyTileset,
            this.mnuAddrHexCopyTilemap});
            this.mnuAddrHex.Name = "mnuAddrHex";
            this.mnuAddrHex.Size = new System.Drawing.Size(143, 22);
            this.mnuAddrHex.Text = "Hexadecimal";
            // 
            // mnuAddrHexCopyBGPalette
            // 
            this.mnuAddrHexCopyBGPalette.Name = "mnuAddrHexCopyBGPalette";
            this.mnuAddrHexCopyBGPalette.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrHexCopyBGPalette.Text = "Copy BG Palette Address";
            this.mnuAddrHexCopyBGPalette.BackColorChanged += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrHexCopySPRPalette
            // 
            this.mnuAddrHexCopySPRPalette.Name = "mnuAddrHexCopySPRPalette";
            this.mnuAddrHexCopySPRPalette.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrHexCopySPRPalette.Text = "Copy SPR Palette Address";
            this.mnuAddrHexCopySPRPalette.BackColorChanged += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrHexCopyTileset
            // 
            this.mnuAddrHexCopyTileset.Name = "mnuAddrHexCopyTileset";
            this.mnuAddrHexCopyTileset.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrHexCopyTileset.Text = "Copy Tileset Address";
            this.mnuAddrHexCopyTileset.BackColorChanged += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuAddrHexCopyTilemap
            // 
            this.mnuAddrHexCopyTilemap.Name = "mnuAddrHexCopyTilemap";
            this.mnuAddrHexCopyTilemap.Size = new System.Drawing.Size(209, 22);
            this.mnuAddrHexCopyTilemap.Text = "Copy Tilemap Address";
            this.mnuAddrHexCopyTilemap.BackColorChanged += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataIgnoreCompression,
            this.mnuDataOverrideLength,
            this.toolStripMenuItem1,
            this.mnuDataBinary,
            this.mnuDataHex,
            this.mnuDataAsm});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(134, 22);
            this.mnuData.Text = "Data";
            // 
            // mnuDataIgnoreCompression
            // 
            this.mnuDataIgnoreCompression.CheckOnClick = true;
            this.mnuDataIgnoreCompression.Name = "mnuDataIgnoreCompression";
            this.mnuDataIgnoreCompression.Size = new System.Drawing.Size(204, 22);
            this.mnuDataIgnoreCompression.Text = "Ignore Compression";
            // 
            // mnuDataOverrideLength
            // 
            this.mnuDataOverrideLength.Checked = true;
            this.mnuDataOverrideLength.CheckOnClick = true;
            this.mnuDataOverrideLength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDataOverrideLength.Name = "mnuDataOverrideLength";
            this.mnuDataOverrideLength.Size = new System.Drawing.Size(204, 22);
            this.mnuDataOverrideLength.Text = "Override Original Length";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuDataBinary
            // 
            this.mnuDataBinary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataBinExportBGPalette,
            this.mnuDataBinExportSPRPalette,
            this.mnuDataBinExportTileset,
            this.mnuDataBinExportTilemap});
            this.mnuDataBinary.Name = "mnuDataBinary";
            this.mnuDataBinary.Size = new System.Drawing.Size(204, 22);
            this.mnuDataBinary.Text = "Binary";
            // 
            // mnuDataBinExportBGPalette
            // 
            this.mnuDataBinExportBGPalette.Name = "mnuDataBinExportBGPalette";
            this.mnuDataBinExportBGPalette.Size = new System.Drawing.Size(197, 22);
            this.mnuDataBinExportBGPalette.Text = "Export BG Palette Data";
            this.mnuDataBinExportBGPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataBinExportSPRPalette
            // 
            this.mnuDataBinExportSPRPalette.Name = "mnuDataBinExportSPRPalette";
            this.mnuDataBinExportSPRPalette.Size = new System.Drawing.Size(197, 22);
            this.mnuDataBinExportSPRPalette.Text = "Export SPR Palette Data";
            this.mnuDataBinExportSPRPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataBinExportTileset
            // 
            this.mnuDataBinExportTileset.Name = "mnuDataBinExportTileset";
            this.mnuDataBinExportTileset.Size = new System.Drawing.Size(197, 22);
            this.mnuDataBinExportTileset.Text = "Export Tileset Data";
            this.mnuDataBinExportTileset.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataBinExportTilemap
            // 
            this.mnuDataBinExportTilemap.Name = "mnuDataBinExportTilemap";
            this.mnuDataBinExportTilemap.Size = new System.Drawing.Size(197, 22);
            this.mnuDataBinExportTilemap.Text = "Export Tilemap Data";
            this.mnuDataBinExportTilemap.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataHex
            // 
            this.mnuDataHex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataHexCopyBGPalette,
            this.mnuDataHexCopySPRPalette,
            this.mnuDataHexCopyTileset,
            this.mnuDataHexCopyTilemap});
            this.mnuDataHex.Name = "mnuDataHex";
            this.mnuDataHex.Size = new System.Drawing.Size(204, 22);
            this.mnuDataHex.Text = "Hexadecimal";
            // 
            // mnuDataHexCopyBGPalette
            // 
            this.mnuDataHexCopyBGPalette.Name = "mnuDataHexCopyBGPalette";
            this.mnuDataHexCopyBGPalette.Size = new System.Drawing.Size(191, 22);
            this.mnuDataHexCopyBGPalette.Text = "Copy BG Palette Data";
            this.mnuDataHexCopyBGPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataHexCopySPRPalette
            // 
            this.mnuDataHexCopySPRPalette.Name = "mnuDataHexCopySPRPalette";
            this.mnuDataHexCopySPRPalette.Size = new System.Drawing.Size(191, 22);
            this.mnuDataHexCopySPRPalette.Text = "Copy SPR Palette Data";
            this.mnuDataHexCopySPRPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataHexCopyTileset
            // 
            this.mnuDataHexCopyTileset.Name = "mnuDataHexCopyTileset";
            this.mnuDataHexCopyTileset.Size = new System.Drawing.Size(191, 22);
            this.mnuDataHexCopyTileset.Text = "Copy Tileset Data";
            this.mnuDataHexCopyTileset.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataHexCopyTilemap
            // 
            this.mnuDataHexCopyTilemap.Name = "mnuDataHexCopyTilemap";
            this.mnuDataHexCopyTilemap.Size = new System.Drawing.Size(191, 22);
            this.mnuDataHexCopyTilemap.Text = "Copy Tilemap Data";
            this.mnuDataHexCopyTilemap.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataAsm
            // 
            this.mnuDataAsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataAsmCopyBGPalette,
            this.mnuDataAsmCopySPRPalette,
            this.mnuDataAsmCopyTileset,
            this.mnuDataAsmCopyTilemap});
            this.mnuDataAsm.Name = "mnuDataAsm";
            this.mnuDataAsm.Size = new System.Drawing.Size(204, 22);
            this.mnuDataAsm.Text = "Assembly";
            // 
            // mnuDataAsmCopyBGPalette
            // 
            this.mnuDataAsmCopyBGPalette.Name = "mnuDataAsmCopyBGPalette";
            this.mnuDataAsmCopyBGPalette.Size = new System.Drawing.Size(191, 22);
            this.mnuDataAsmCopyBGPalette.Text = "Copy BG Palette Data";
            this.mnuDataAsmCopyBGPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataAsmCopySPRPalette
            // 
            this.mnuDataAsmCopySPRPalette.Name = "mnuDataAsmCopySPRPalette";
            this.mnuDataAsmCopySPRPalette.Size = new System.Drawing.Size(191, 22);
            this.mnuDataAsmCopySPRPalette.Text = "Copy SPR Palette Data";
            this.mnuDataAsmCopySPRPalette.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataAsmCopyTileset
            // 
            this.mnuDataAsmCopyTileset.Name = "mnuDataAsmCopyTileset";
            this.mnuDataAsmCopyTileset.Size = new System.Drawing.Size(191, 22);
            this.mnuDataAsmCopyTileset.Text = "Copy Tileset Data";
            this.mnuDataAsmCopyTileset.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // mnuDataAsmCopyTilemap
            // 
            this.mnuDataAsmCopyTilemap.Name = "mnuDataAsmCopyTilemap";
            this.mnuDataAsmCopyTilemap.Size = new System.Drawing.Size(191, 22);
            this.mnuDataAsmCopyTilemap.Text = "Copy Tilemap Data";
            this.mnuDataAsmCopyTilemap.Click += new System.EventHandler(this.mnuContextMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSpriteListTools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 23);
            this.panel1.TabIndex = 0;
            // 
            // pnlSpriteListTools
            // 
            this.pnlSpriteListTools.Controls.Add(this.lblSpriteTilemap);
            this.pnlSpriteListTools.Controls.Add(this.btnPreviousFrame);
            this.pnlSpriteListTools.Controls.Add(this.btnNextFrame);
            this.pnlSpriteListTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpriteListTools.Location = new System.Drawing.Point(0, 0);
            this.pnlSpriteListTools.Name = "pnlSpriteListTools";
            this.pnlSpriteListTools.Size = new System.Drawing.Size(172, 21);
            this.pnlSpriteListTools.TabIndex = 0;
            // 
            // lblSpriteTilemap
            // 
            this.lblSpriteTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteTilemap.Location = new System.Drawing.Point(25, 0);
            this.lblSpriteTilemap.Name = "lblSpriteTilemap";
            this.lblSpriteTilemap.Size = new System.Drawing.Size(122, 21);
            this.lblSpriteTilemap.TabIndex = 1;
            this.lblSpriteTilemap.Text = "Sprite Tilemap";
            this.lblSpriteTilemap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousFrame
            // 
            this.btnPreviousFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreviousFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousFrame.Location = new System.Drawing.Point(0, 0);
            this.btnPreviousFrame.Name = "btnPreviousFrame";
            this.btnPreviousFrame.Size = new System.Drawing.Size(25, 21);
            this.btnPreviousFrame.TabIndex = 0;
            this.btnPreviousFrame.Text = "<<";
            this.btnPreviousFrame.UseVisualStyleBackColor = true;
            this.btnPreviousFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFrame.Location = new System.Drawing.Point(147, 0);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(25, 21);
            this.btnNextFrame.TabIndex = 2;
            this.btnNextFrame.Text = ">>";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // tpnlSpriteEditMain
            // 
            this.tpnlSpriteEditMain.ColumnCount = 2;
            this.tpnlSpriteEditMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlSpriteEditMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteEditMain.Controls.Add(this.tabSpriteEditMain, 1, 0);
            this.tpnlSpriteEditMain.Controls.Add(this.grpSpriteList, 0, 0);
            this.tpnlSpriteEditMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpriteEditMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlSpriteEditMain.Name = "tpnlSpriteEditMain";
            this.tpnlSpriteEditMain.RowCount = 1;
            this.tpnlSpriteEditMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteEditMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlSpriteEditMain.TabIndex = 3;
            // 
            // AssetEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlSpriteEditMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetEditControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tabSpriteEditMain.ResumeLayout(false);
            this.tabSprite.ResumeLayout(false);
            this.pnlSpriteTools.ResumeLayout(false);
            this.pnlSpriteTools.PerformLayout();
            this.tabTileset.ResumeLayout(false);
            this.pnlTilesetTools.ResumeLayout(false);
            this.pnlTilesetTools.PerformLayout();
            this.tabTilemap.ResumeLayout(false);
            this.pnlTilemapTools.ResumeLayout(false);
            this.pnlTilemapToolsContainer.ResumeLayout(false);
            this.pnlTilemapToolsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).EndInit();
            this.grpSpriteList.ResumeLayout(false);
            this.mnuSpriteOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlSpriteListTools.ResumeLayout(false);
            this.tpnlSpriteEditMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabSpriteEditMain;
        private System.Windows.Forms.TabPage tabSprite;
        private ImageControl pnlSprite;
        private System.Windows.Forms.Panel pnlSpriteTools;
        private System.Windows.Forms.Button btnSpriteCompare;
        private System.Windows.Forms.Label lblSpriteEditSPRPalette;
        private PaletteControl pnlSpriteEditSPRPalette;
        private System.Windows.Forms.Label lblSpriteEditBGPalette;
        private System.Windows.Forms.Button btnSpriteRevert;
        private System.Windows.Forms.Button btnSpriteImport;
        private PaletteControl pnlSpriteEditBGPalette;
        private System.Windows.Forms.TabPage tabTileset;
        private TilesetControl pnlTileset;
        private System.Windows.Forms.Panel pnlTilesetTools;
        private System.Windows.Forms.Button btnAddTile;
        private System.Windows.Forms.Button btnSwapSelectedPixel;
        private PaletteControl pnlTilePalette;
        private System.Windows.Forms.Label lblSelectedPalette;
        private System.Windows.Forms.RadioButton radSpritePalette;
        private System.Windows.Forms.RadioButton radBackgroundPalette;
        private System.Windows.Forms.Label lblTile;
        private TileControl pnlTile;
        private System.Windows.Forms.CheckBox chkTilesetUseGrid;
        private System.Windows.Forms.Button btnDeselectTile;
        private System.Windows.Forms.Button btnDeleteTile;
        private System.Windows.Forms.CheckBox chkTilesetIndexed;
        private System.Windows.Forms.Button btnRevertTileset;
        private System.Windows.Forms.TabPage tabTilemap;
        private TilemapControl pnlTilemap;
        private System.Windows.Forms.Panel pnlTilemapTools;
        private TilesControl pnlTiles;
        private System.Windows.Forms.Panel pnlTilemapToolsContainer;
        private System.Windows.Forms.Label lblTileEdit;
        private System.Windows.Forms.ComboBox cbTileEdit;
        private System.Windows.Forms.Label lblSelectedTileIDValue;
        private System.Windows.Forms.Button btnReplaceTiles;
        private System.Windows.Forms.Label lblSelectedTileID;
        private System.Windows.Forms.CheckBox chkTilesUseGrid;
        private System.Windows.Forms.CheckBox chkTilemapIndexed;
        private System.Windows.Forms.Button btnRevertTilemap;
        private System.Windows.Forms.GroupBox grpSpriteList;
        private ListBoxControl lstSprites;
        private System.Windows.Forms.Panel pnlSpriteListTools;
        private System.Windows.Forms.Label lblSpriteTilemap;
        private System.Windows.Forms.Button btnPreviousFrame;
        private System.Windows.Forms.Button btnNextFrame;
        private System.Windows.Forms.TextBox txtSpriteEditSPRPalette;
        private System.Windows.Forms.TextBox txtSpriteEditBGPalette;
        private System.Windows.Forms.Button btnEditPalette;
        private System.Windows.Forms.TableLayoutPanel tpnlSpriteEditMain;
        private System.Windows.Forms.CheckBox chkHighlighter;
        private System.Windows.Forms.Label lblHighlighterCountValue;
        private System.Windows.Forms.CheckBox chkTilemapOverride;
        private System.Windows.Forms.Label lblTilemapRows;
        private System.Windows.Forms.Label lblTilemapColumns;
        private System.Windows.Forms.NumericUpDown nudTilemapRows;
        private System.Windows.Forms.NumericUpDown nudTilemapColumns;
        private System.Windows.Forms.GroupBox grpTilemapDivider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTilesetOverride;
        private System.Windows.Forms.Button btnTilemapProperties;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTilesetProperties;
        private System.Windows.Forms.Button btnSpriteDisable;
        private System.Windows.Forms.CheckBox chkDisableSPRPalette;
        private System.Windows.Forms.CheckBox chkDisableBGPalette;
        private System.Windows.Forms.CheckBox chkDisableTileset;
        private System.Windows.Forms.CheckBox chkDisableTilemap;
        private System.Windows.Forms.CheckBox chkShowIndexesWithOffset;
        private System.Windows.Forms.ContextMenuStrip mnuSpriteOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuImage;
        private System.Windows.Forms.ToolStripMenuItem mnuImageExportAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuImageExportSprite;
        private System.Windows.Forms.ToolStripMenuItem mnuImageExportTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuAddress;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrDec;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrDecCopyBGPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrDecCopySPRPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrDecCopyTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrDecCopyTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrHex;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrHexCopyBGPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrHexCopySPRPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrHexCopyTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuAddrHexCopyTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuDataIgnoreCompression;
        private System.Windows.Forms.ToolStripMenuItem mnuDataOverrideLength;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBinExportBGPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBinExportSPRPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBinExportTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBinExportTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHex;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHexCopyBGPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHexCopySPRPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHexCopyTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuDataHexCopyTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAsm;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAsmCopyBGPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAsmCopySPRPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAsmCopyTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAsmCopyTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuEditedData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Button btnSpriteRevertPalette;
        private System.Windows.Forms.Button btnSpriteEnable;
    }
}
