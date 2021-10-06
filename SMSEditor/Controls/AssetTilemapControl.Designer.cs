namespace SMSEditor.Controls
{
    partial class AssetTilemapControl
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
            this.tpnlTilemapsMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilemapImage = new SMSEditor.Controls.ImageControl();
            this.grpTilemapList = new System.Windows.Forms.GroupBox();
            this.lstTilemaps = new SMSEditor.Controls.ListBoxControl();
            this.pnlTilemapButtons = new System.Windows.Forms.Panel();
            this.btnTilemapRemove = new System.Windows.Forms.Button();
            this.btnTilemapSave = new System.Windows.Forms.Button();
            this.btnTilemapValidate = new System.Windows.Forms.Button();
            this.pnlTilemapOptions = new System.Windows.Forms.Panel();
            this.chkTilemapPlaceholder = new System.Windows.Forms.CheckBox();
            this.nudTilemapHex = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapHex = new System.Windows.Forms.Label();
            this.lblTilemapLength = new System.Windows.Forms.Label();
            this.nudTilemapLength = new System.Windows.Forms.NumericUpDown();
            this.grpTilemapDivider = new System.Windows.Forms.GroupBox();
            this.pnlTilemapSPRPalette = new SMSEditor.Controls.PaletteControl();
            this.pnlTilemapBGPalette = new SMSEditor.Controls.PaletteControl();
            this.lblTilemapID = new System.Windows.Forms.Label();
            this.lblTilemapRows = new System.Windows.Forms.Label();
            this.lblTilemapColumns = new System.Windows.Forms.Label();
            this.cbTilemapSPRPalette = new System.Windows.Forms.ComboBox();
            this.cbTilemapCompression = new System.Windows.Forms.ComboBox();
            this.lblTilemapCompression = new System.Windows.Forms.Label();
            this.cbTilemapTileset = new System.Windows.Forms.ComboBox();
            this.chkTilemapUseAttributes = new System.Windows.Forms.CheckBox();
            this.nudTilemapOffset = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapSPRPalette = new System.Windows.Forms.Label();
            this.nudTilemapRows = new System.Windows.Forms.NumericUpDown();
            this.cbTilemapBGPalette = new System.Windows.Forms.ComboBox();
            this.txtTilemapName = new System.Windows.Forms.TextBox();
            this.nudTilemapColumns = new System.Windows.Forms.NumericUpDown();
            this.lblTilemapBGPalette = new System.Windows.Forms.Label();
            this.lblTilemapName = new System.Windows.Forms.Label();
            this.lblTilemapOffset = new System.Windows.Forms.Label();
            this.lblTilemapTileset = new System.Windows.Forms.Label();
            this.nudTilemapID = new System.Windows.Forms.NumericUpDown();
            this.tpnlTilemapsMain.SuspendLayout();
            this.grpTilemapList.SuspendLayout();
            this.pnlTilemapButtons.SuspendLayout();
            this.pnlTilemapOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapID)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlTilemapsMain
            // 
            this.tpnlTilemapsMain.ColumnCount = 3;
            this.tpnlTilemapsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlTilemapsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlTilemapsMain.Controls.Add(this.pnlTilemapImage, 1, 0);
            this.tpnlTilemapsMain.Controls.Add(this.grpTilemapList, 0, 0);
            this.tpnlTilemapsMain.Controls.Add(this.pnlTilemapOptions, 2, 0);
            this.tpnlTilemapsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemapsMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlTilemapsMain.Name = "tpnlTilemapsMain";
            this.tpnlTilemapsMain.RowCount = 1;
            this.tpnlTilemapsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapsMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlTilemapsMain.TabIndex = 4;
            // 
            // pnlTilemapImage
            // 
            this.pnlTilemapImage.AutoScroll = true;
            this.pnlTilemapImage.AutoScrollMinSize = new System.Drawing.Size(430, 535);
            this.pnlTilemapImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemapImage.Centered = true;
            this.pnlTilemapImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemapImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemapImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemapImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemapImage.Image = null;
            this.pnlTilemapImage.ImageAlpha = 1F;
            this.pnlTilemapImage.ImageScale = 1;
            this.pnlTilemapImage.Location = new System.Drawing.Point(202, 7);
            this.pnlTilemapImage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 2);
            this.pnlTilemapImage.MinimumScale = 1;
            this.pnlTilemapImage.Name = "pnlTilemapImage";
            this.pnlTilemapImage.Size = new System.Drawing.Size(430, 535);
            this.pnlTilemapImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemapImage.TabIndex = 1;
            this.pnlTilemapImage.UseCanvas = false;
            this.pnlTilemapImage.UseHatch = true;
            this.pnlTilemapImage.UseMouseWheelScaling = true;
            // 
            // grpTilemapList
            // 
            this.grpTilemapList.Controls.Add(this.lstTilemaps);
            this.grpTilemapList.Controls.Add(this.pnlTilemapButtons);
            this.grpTilemapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTilemapList.Location = new System.Drawing.Point(0, 0);
            this.grpTilemapList.Margin = new System.Windows.Forms.Padding(0);
            this.grpTilemapList.Name = "grpTilemapList";
            this.grpTilemapList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpTilemapList.Size = new System.Drawing.Size(196, 544);
            this.grpTilemapList.TabIndex = 0;
            this.grpTilemapList.TabStop = false;
            this.grpTilemapList.Text = "Tilemaps";
            // 
            // lstTilemaps
            // 
            this.lstTilemaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilemaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilemaps.FormattingEnabled = true;
            this.lstTilemaps.HorizontalExtent = 170;
            this.lstTilemaps.IntegralHeight = false;
            this.lstTilemaps.ItemHeight = 15;
            this.lstTilemaps.Location = new System.Drawing.Point(12, 89);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(172, 443);
            this.lstTilemaps.TabIndex = 0;
            this.lstTilemaps.TextOffsetX = 2;
            this.lstTilemaps.TextOffsetY = -1;
            this.lstTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // pnlTilemapButtons
            // 
            this.pnlTilemapButtons.Controls.Add(this.btnTilemapRemove);
            this.pnlTilemapButtons.Controls.Add(this.btnTilemapSave);
            this.pnlTilemapButtons.Controls.Add(this.btnTilemapValidate);
            this.pnlTilemapButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlTilemapButtons.Name = "pnlTilemapButtons";
            this.pnlTilemapButtons.Size = new System.Drawing.Size(172, 70);
            this.pnlTilemapButtons.TabIndex = 0;
            // 
            // btnTilemapRemove
            // 
            this.btnTilemapRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapRemove.Location = new System.Drawing.Point(0, 46);
            this.btnTilemapRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapRemove.Name = "btnTilemapRemove";
            this.btnTilemapRemove.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapRemove.TabIndex = 2;
            this.btnTilemapRemove.Text = "Remove Tilemap";
            this.btnTilemapRemove.UseVisualStyleBackColor = true;
            this.btnTilemapRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnTilemapSave
            // 
            this.btnTilemapSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapSave.Location = new System.Drawing.Point(0, 23);
            this.btnTilemapSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapSave.Name = "btnTilemapSave";
            this.btnTilemapSave.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapSave.TabIndex = 1;
            this.btnTilemapSave.Text = "Save Tilemap";
            this.btnTilemapSave.UseVisualStyleBackColor = true;
            this.btnTilemapSave.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnTilemapValidate
            // 
            this.btnTilemapValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapValidate.Location = new System.Drawing.Point(0, 0);
            this.btnTilemapValidate.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapValidate.Name = "btnTilemapValidate";
            this.btnTilemapValidate.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapValidate.TabIndex = 0;
            this.btnTilemapValidate.Text = "Validate Tilemap";
            this.btnTilemapValidate.UseVisualStyleBackColor = true;
            this.btnTilemapValidate.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // pnlTilemapOptions
            // 
            this.pnlTilemapOptions.Controls.Add(this.chkTilemapPlaceholder);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapHex);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapHex);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapLength);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapLength);
            this.pnlTilemapOptions.Controls.Add(this.grpTilemapDivider);
            this.pnlTilemapOptions.Controls.Add(this.pnlTilemapSPRPalette);
            this.pnlTilemapOptions.Controls.Add(this.pnlTilemapBGPalette);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapID);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapRows);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapColumns);
            this.pnlTilemapOptions.Controls.Add(this.cbTilemapSPRPalette);
            this.pnlTilemapOptions.Controls.Add(this.cbTilemapCompression);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapCompression);
            this.pnlTilemapOptions.Controls.Add(this.cbTilemapTileset);
            this.pnlTilemapOptions.Controls.Add(this.chkTilemapUseAttributes);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapOffset);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapSPRPalette);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapRows);
            this.pnlTilemapOptions.Controls.Add(this.cbTilemapBGPalette);
            this.pnlTilemapOptions.Controls.Add(this.txtTilemapName);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapColumns);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapBGPalette);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapName);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapOffset);
            this.pnlTilemapOptions.Controls.Add(this.lblTilemapTileset);
            this.pnlTilemapOptions.Controls.Add(this.nudTilemapID);
            this.pnlTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemapOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlTilemapOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTilemapOptions.Name = "pnlTilemapOptions";
            this.pnlTilemapOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlTilemapOptions.TabIndex = 2;
            // 
            // chkTilemapPlaceholder
            // 
            this.chkTilemapPlaceholder.AutoSize = true;
            this.chkTilemapPlaceholder.Location = new System.Drawing.Point(0, 448);
            this.chkTilemapPlaceholder.Name = "chkTilemapPlaceholder";
            this.chkTilemapPlaceholder.Size = new System.Drawing.Size(122, 17);
            this.chkTilemapPlaceholder.TabIndex = 26;
            this.chkTilemapPlaceholder.Text = "Tileset Placeholder";
            this.chkTilemapPlaceholder.UseVisualStyleBackColor = true;
            // 
            // nudTilemapHex
            // 
            this.nudTilemapHex.Hexadecimal = true;
            this.nudTilemapHex.Location = new System.Drawing.Point(88, 16);
            this.nudTilemapHex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilemapHex.Name = "nudTilemapHex";
            this.nudTilemapHex.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapHex.TabIndex = 3;
            this.nudTilemapHex.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblTilemapHex
            // 
            this.lblTilemapHex.AutoSize = true;
            this.lblTilemapHex.Location = new System.Drawing.Point(88, 0);
            this.lblTilemapHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapHex.Name = "lblTilemapHex";
            this.lblTilemapHex.Size = new System.Drawing.Size(80, 13);
            this.lblTilemapHex.TabIndex = 2;
            this.lblTilemapHex.Text = "Position (Hex):";
            this.lblTilemapHex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapLength
            // 
            this.lblTilemapLength.AutoSize = true;
            this.lblTilemapLength.Location = new System.Drawing.Point(0, 160);
            this.lblTilemapLength.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapLength.Name = "lblTilemapLength";
            this.lblTilemapLength.Size = new System.Drawing.Size(46, 13);
            this.lblTilemapLength.TabIndex = 12;
            this.lblTilemapLength.Text = "Length:";
            this.lblTilemapLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilemapLength
            // 
            this.nudTilemapLength.Location = new System.Drawing.Point(0, 176);
            this.nudTilemapLength.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilemapLength.Name = "nudTilemapLength";
            this.nudTilemapLength.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapLength.TabIndex = 13;
            // 
            // grpTilemapDivider
            // 
            this.grpTilemapDivider.Location = new System.Drawing.Point(0, 260);
            this.grpTilemapDivider.Name = "grpTilemapDivider";
            this.grpTilemapDivider.Size = new System.Drawing.Size(176, 5);
            this.grpTilemapDivider.TabIndex = 19;
            this.grpTilemapDivider.TabStop = false;
            // 
            // pnlTilemapSPRPalette
            // 
            this.pnlTilemapSPRPalette.Location = new System.Drawing.Point(0, 400);
            this.pnlTilemapSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemapSPRPalette.Name = "pnlTilemapSPRPalette";
            this.pnlTilemapSPRPalette.ReadOnly = true;
            this.pnlTilemapSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlTilemapSPRPalette.TabIndex = 25;
            // 
            // pnlTilemapBGPalette
            // 
            this.pnlTilemapBGPalette.Location = new System.Drawing.Point(0, 312);
            this.pnlTilemapBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemapBGPalette.Name = "pnlTilemapBGPalette";
            this.pnlTilemapBGPalette.ReadOnly = true;
            this.pnlTilemapBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlTilemapBGPalette.TabIndex = 22;
            // 
            // lblTilemapID
            // 
            this.lblTilemapID.AutoSize = true;
            this.lblTilemapID.Location = new System.Drawing.Point(0, 0);
            this.lblTilemapID.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapID.Name = "lblTilemapID";
            this.lblTilemapID.Size = new System.Drawing.Size(72, 13);
            this.lblTilemapID.TabIndex = 0;
            this.lblTilemapID.Text = "Position (ID):";
            this.lblTilemapID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapRows
            // 
            this.lblTilemapRows.AutoSize = true;
            this.lblTilemapRows.Location = new System.Drawing.Point(88, 80);
            this.lblTilemapRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapRows.Name = "lblTilemapRows";
            this.lblTilemapRows.Size = new System.Drawing.Size(38, 13);
            this.lblTilemapRows.TabIndex = 8;
            this.lblTilemapRows.Text = "Rows:";
            this.lblTilemapRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapColumns
            // 
            this.lblTilemapColumns.AutoSize = true;
            this.lblTilemapColumns.Location = new System.Drawing.Point(0, 80);
            this.lblTilemapColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapColumns.Name = "lblTilemapColumns";
            this.lblTilemapColumns.Size = new System.Drawing.Size(55, 13);
            this.lblTilemapColumns.TabIndex = 6;
            this.lblTilemapColumns.Text = "Columns:";
            this.lblTilemapColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilemapSPRPalette
            // 
            this.cbTilemapSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapSPRPalette.FormattingEnabled = true;
            this.cbTilemapSPRPalette.Location = new System.Drawing.Point(0, 376);
            this.cbTilemapSPRPalette.Name = "cbTilemapSPRPalette";
            this.cbTilemapSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapSPRPalette.TabIndex = 24;
            this.cbTilemapSPRPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // cbTilemapCompression
            // 
            this.cbTilemapCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapCompression.FormattingEnabled = true;
            this.cbTilemapCompression.Location = new System.Drawing.Point(0, 136);
            this.cbTilemapCompression.Name = "cbTilemapCompression";
            this.cbTilemapCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapCompression.TabIndex = 11;
            this.cbTilemapCompression.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // lblTilemapCompression
            // 
            this.lblTilemapCompression.AutoSize = true;
            this.lblTilemapCompression.Location = new System.Drawing.Point(0, 120);
            this.lblTilemapCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapCompression.Name = "lblTilemapCompression";
            this.lblTilemapCompression.Size = new System.Drawing.Size(77, 13);
            this.lblTilemapCompression.TabIndex = 10;
            this.lblTilemapCompression.Text = "Compression:";
            this.lblTilemapCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilemapTileset
            // 
            this.cbTilemapTileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapTileset.FormattingEnabled = true;
            this.cbTilemapTileset.Location = new System.Drawing.Point(0, 216);
            this.cbTilemapTileset.Name = "cbTilemapTileset";
            this.cbTilemapTileset.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapTileset.TabIndex = 17;
            // 
            // chkTilemapUseAttributes
            // 
            this.chkTilemapUseAttributes.AutoSize = true;
            this.chkTilemapUseAttributes.Location = new System.Drawing.Point(0, 240);
            this.chkTilemapUseAttributes.Margin = new System.Windows.Forms.Padding(0);
            this.chkTilemapUseAttributes.Name = "chkTilemapUseAttributes";
            this.chkTilemapUseAttributes.Size = new System.Drawing.Size(120, 17);
            this.chkTilemapUseAttributes.TabIndex = 18;
            this.chkTilemapUseAttributes.Text = "Use Tile Attributes";
            this.chkTilemapUseAttributes.UseVisualStyleBackColor = true;
            // 
            // nudTilemapOffset
            // 
            this.nudTilemapOffset.Location = new System.Drawing.Point(88, 176);
            this.nudTilemapOffset.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudTilemapOffset.Name = "nudTilemapOffset";
            this.nudTilemapOffset.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapOffset.TabIndex = 15;
            // 
            // lblTilemapSPRPalette
            // 
            this.lblTilemapSPRPalette.AutoSize = true;
            this.lblTilemapSPRPalette.Location = new System.Drawing.Point(0, 360);
            this.lblTilemapSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapSPRPalette.Name = "lblTilemapSPRPalette";
            this.lblTilemapSPRPalette.Size = new System.Drawing.Size(78, 13);
            this.lblTilemapSPRPalette.TabIndex = 23;
            this.lblTilemapSPRPalette.Text = "Sprite Palette:";
            this.lblTilemapSPRPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilemapRows
            // 
            this.nudTilemapRows.Location = new System.Drawing.Point(88, 96);
            this.nudTilemapRows.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapRows.Name = "nudTilemapRows";
            this.nudTilemapRows.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapRows.TabIndex = 9;
            // 
            // cbTilemapBGPalette
            // 
            this.cbTilemapBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapBGPalette.FormattingEnabled = true;
            this.cbTilemapBGPalette.Location = new System.Drawing.Point(0, 288);
            this.cbTilemapBGPalette.Name = "cbTilemapBGPalette";
            this.cbTilemapBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapBGPalette.TabIndex = 21;
            this.cbTilemapBGPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // txtTilemapName
            // 
            this.txtTilemapName.Location = new System.Drawing.Point(0, 56);
            this.txtTilemapName.Name = "txtTilemapName";
            this.txtTilemapName.Size = new System.Drawing.Size(168, 22);
            this.txtTilemapName.TabIndex = 5;
            // 
            // nudTilemapColumns
            // 
            this.nudTilemapColumns.Location = new System.Drawing.Point(0, 96);
            this.nudTilemapColumns.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilemapColumns.Name = "nudTilemapColumns";
            this.nudTilemapColumns.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapColumns.TabIndex = 7;
            // 
            // lblTilemapBGPalette
            // 
            this.lblTilemapBGPalette.AutoSize = true;
            this.lblTilemapBGPalette.Location = new System.Drawing.Point(0, 272);
            this.lblTilemapBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapBGPalette.Name = "lblTilemapBGPalette";
            this.lblTilemapBGPalette.Size = new System.Drawing.Size(110, 13);
            this.lblTilemapBGPalette.TabIndex = 20;
            this.lblTilemapBGPalette.Text = "Background Palette:";
            this.lblTilemapBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapName
            // 
            this.lblTilemapName.AutoSize = true;
            this.lblTilemapName.Location = new System.Drawing.Point(0, 40);
            this.lblTilemapName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapName.Name = "lblTilemapName";
            this.lblTilemapName.Size = new System.Drawing.Size(82, 13);
            this.lblTilemapName.TabIndex = 4;
            this.lblTilemapName.Text = "Tilemap Name:";
            this.lblTilemapName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapOffset
            // 
            this.lblTilemapOffset.AutoSize = true;
            this.lblTilemapOffset.Location = new System.Drawing.Point(88, 160);
            this.lblTilemapOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapOffset.Name = "lblTilemapOffset";
            this.lblTilemapOffset.Size = new System.Drawing.Size(42, 13);
            this.lblTilemapOffset.TabIndex = 14;
            this.lblTilemapOffset.Text = "Offset:";
            this.lblTilemapOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilemapTileset
            // 
            this.lblTilemapTileset.AutoSize = true;
            this.lblTilemapTileset.Location = new System.Drawing.Point(0, 200);
            this.lblTilemapTileset.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapTileset.Name = "lblTilemapTileset";
            this.lblTilemapTileset.Size = new System.Drawing.Size(43, 13);
            this.lblTilemapTileset.TabIndex = 16;
            this.lblTilemapTileset.Text = "Tileset:";
            this.lblTilemapTileset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilemapID
            // 
            this.nudTilemapID.Location = new System.Drawing.Point(0, 16);
            this.nudTilemapID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilemapID.Name = "nudTilemapID";
            this.nudTilemapID.Size = new System.Drawing.Size(80, 22);
            this.nudTilemapID.TabIndex = 1;
            this.nudTilemapID.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // AssetTilemapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlTilemapsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetTilemapControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlTilemapsMain.ResumeLayout(false);
            this.grpTilemapList.ResumeLayout(false);
            this.pnlTilemapButtons.ResumeLayout(false);
            this.pnlTilemapOptions.ResumeLayout(false);
            this.pnlTilemapOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilemapID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlTilemapsMain;
        private ImageControl pnlTilemapImage;
        private System.Windows.Forms.GroupBox grpTilemapList;
        private ListBoxControl lstTilemaps;
        private System.Windows.Forms.Panel pnlTilemapButtons;
        private System.Windows.Forms.Button btnTilemapRemove;
        private System.Windows.Forms.Button btnTilemapSave;
        private System.Windows.Forms.Button btnTilemapValidate;
        private System.Windows.Forms.Panel pnlTilemapOptions;
        private PaletteControl pnlTilemapSPRPalette;
        private PaletteControl pnlTilemapBGPalette;
        private System.Windows.Forms.Label lblTilemapID;
        private System.Windows.Forms.Label lblTilemapRows;
        private System.Windows.Forms.Label lblTilemapColumns;
        private System.Windows.Forms.ComboBox cbTilemapSPRPalette;
        private System.Windows.Forms.ComboBox cbTilemapCompression;
        private System.Windows.Forms.Label lblTilemapCompression;
        private System.Windows.Forms.ComboBox cbTilemapTileset;
        private System.Windows.Forms.CheckBox chkTilemapUseAttributes;
        private System.Windows.Forms.NumericUpDown nudTilemapOffset;
        private System.Windows.Forms.Label lblTilemapSPRPalette;
        private System.Windows.Forms.NumericUpDown nudTilemapRows;
        private System.Windows.Forms.ComboBox cbTilemapBGPalette;
        private System.Windows.Forms.TextBox txtTilemapName;
        private System.Windows.Forms.NumericUpDown nudTilemapColumns;
        private System.Windows.Forms.Label lblTilemapBGPalette;
        private System.Windows.Forms.Label lblTilemapName;
        private System.Windows.Forms.Label lblTilemapOffset;
        private System.Windows.Forms.Label lblTilemapTileset;
        private System.Windows.Forms.NumericUpDown nudTilemapID;
        private System.Windows.Forms.GroupBox grpTilemapDivider;
        private System.Windows.Forms.Label lblTilemapLength;
        private System.Windows.Forms.NumericUpDown nudTilemapLength;
        private System.Windows.Forms.Label lblTilemapHex;
        private System.Windows.Forms.NumericUpDown nudTilemapHex;
        private System.Windows.Forms.CheckBox chkTilemapPlaceholder;
    }
}
