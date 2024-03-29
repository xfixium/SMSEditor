﻿namespace SMSEditor.Controls
{
    partial class AssetTilesetControl
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
            this.tpnlTilesetsMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilesetImage = new SMSEditor.Controls.ImageControl();
            this.grpTilesetList = new System.Windows.Forms.GroupBox();
            this.lstTilesets = new SMSEditor.Controls.ListBoxControl();
            this.pnlTilesetButtons = new System.Windows.Forms.Panel();
            this.btnTilesetRemove = new System.Windows.Forms.Button();
            this.btnTilesetSave = new System.Windows.Forms.Button();
            this.btnTilesetValidate = new System.Windows.Forms.Button();
            this.pnlTilesetOptions = new System.Windows.Forms.Panel();
            this.nudTilesetHex = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetHex = new System.Windows.Forms.Label();
            this.grpTilesetDivider = new System.Windows.Forms.GroupBox();
            this.lblTilesetLength = new System.Windows.Forms.Label();
            this.chkTilesetMasked = new System.Windows.Forms.CheckBox();
            this.lblTilesetID = new System.Windows.Forms.Label();
            this.nudTilesetLength = new System.Windows.Forms.NumericUpDown();
            this.txtTilesetName = new System.Windows.Forms.TextBox();
            this.pnlTilesetPalette = new SMSEditor.Controls.PaletteControl();
            this.cbTilesetCompression = new System.Windows.Forms.ComboBox();
            this.nudTilesetOffset = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetName = new System.Windows.Forms.Label();
            this.lblTilesetPalette = new System.Windows.Forms.Label();
            this.nudTilesetID = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetOffset = new System.Windows.Forms.Label();
            this.lblTilesetCompression = new System.Windows.Forms.Label();
            this.cbTilesetPalette = new System.Windows.Forms.ComboBox();
            this.lblTilesetBpp = new System.Windows.Forms.Label();
            this.rad1Bpp = new System.Windows.Forms.RadioButton();
            this.rad3Bpp = new System.Windows.Forms.RadioButton();
            this.rad2Bpp = new System.Windows.Forms.RadioButton();
            this.rad4Bpp = new System.Windows.Forms.RadioButton();
            this.tpnlTilesetsMain.SuspendLayout();
            this.grpTilesetList.SuspendLayout();
            this.pnlTilesetButtons.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetID)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlTilesetsMain
            // 
            this.tpnlTilesetsMain.ColumnCount = 3;
            this.tpnlTilesetsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlTilesetsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesetsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlTilesetsMain.Controls.Add(this.pnlTilesetImage, 1, 0);
            this.tpnlTilesetsMain.Controls.Add(this.grpTilesetList, 0, 0);
            this.tpnlTilesetsMain.Controls.Add(this.pnlTilesetOptions, 2, 0);
            this.tpnlTilesetsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilesetsMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlTilesetsMain.Name = "tpnlTilesetsMain";
            this.tpnlTilesetsMain.RowCount = 1;
            this.tpnlTilesetsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesetsMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlTilesetsMain.TabIndex = 1;
            // 
            // pnlTilesetImage
            // 
            this.pnlTilesetImage.AutoScroll = true;
            this.pnlTilesetImage.AutoScrollMinSize = new System.Drawing.Size(430, 535);
            this.pnlTilesetImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilesetImage.Centered = true;
            this.pnlTilesetImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilesetImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilesetImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilesetImage.Image = null;
            this.pnlTilesetImage.ImageAlpha = 1F;
            this.pnlTilesetImage.ImageScale = 1;
            this.pnlTilesetImage.Location = new System.Drawing.Point(202, 7);
            this.pnlTilesetImage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 2);
            this.pnlTilesetImage.MinimumScale = 1;
            this.pnlTilesetImage.Name = "pnlTilesetImage";
            this.pnlTilesetImage.Size = new System.Drawing.Size(430, 535);
            this.pnlTilesetImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetImage.TabIndex = 0;
            this.pnlTilesetImage.UseCanvas = false;
            this.pnlTilesetImage.UseHatch = true;
            this.pnlTilesetImage.UseMouseWheelScaling = true;
            // 
            // grpTilesetList
            // 
            this.grpTilesetList.Controls.Add(this.lstTilesets);
            this.grpTilesetList.Controls.Add(this.pnlTilesetButtons);
            this.grpTilesetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTilesetList.Location = new System.Drawing.Point(0, 0);
            this.grpTilesetList.Margin = new System.Windows.Forms.Padding(0);
            this.grpTilesetList.Name = "grpTilesetList";
            this.grpTilesetList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpTilesetList.Size = new System.Drawing.Size(196, 544);
            this.grpTilesetList.TabIndex = 0;
            this.grpTilesetList.TabStop = false;
            this.grpTilesetList.Text = "Tilesets";
            // 
            // lstTilesets
            // 
            this.lstTilesets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTilesets.DisableHighlighting = true;
            this.lstTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilesets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilesets.FormattingEnabled = true;
            this.lstTilesets.HorizontalExtent = 170;
            this.lstTilesets.IntegralHeight = false;
            this.lstTilesets.ItemHeight = 15;
            this.lstTilesets.Location = new System.Drawing.Point(12, 89);
            this.lstTilesets.Name = "lstTilesets";
            this.lstTilesets.Size = new System.Drawing.Size(172, 443);
            this.lstTilesets.TabIndex = 1;
            this.lstTilesets.TextOffsetX = 2;
            this.lstTilesets.TextOffsetY = -1;
            this.lstTilesets.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // pnlTilesetButtons
            // 
            this.pnlTilesetButtons.Controls.Add(this.btnTilesetRemove);
            this.pnlTilesetButtons.Controls.Add(this.btnTilesetSave);
            this.pnlTilesetButtons.Controls.Add(this.btnTilesetValidate);
            this.pnlTilesetButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilesetButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlTilesetButtons.Name = "pnlTilesetButtons";
            this.pnlTilesetButtons.Size = new System.Drawing.Size(172, 70);
            this.pnlTilesetButtons.TabIndex = 0;
            // 
            // btnTilesetRemove
            // 
            this.btnTilesetRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilesetRemove.Location = new System.Drawing.Point(0, 46);
            this.btnTilesetRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilesetRemove.Name = "btnTilesetRemove";
            this.btnTilesetRemove.Size = new System.Drawing.Size(172, 23);
            this.btnTilesetRemove.TabIndex = 2;
            this.btnTilesetRemove.Text = "Remove Tileset";
            this.btnTilesetRemove.UseVisualStyleBackColor = true;
            this.btnTilesetRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnTilesetSave
            // 
            this.btnTilesetSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilesetSave.Location = new System.Drawing.Point(0, 23);
            this.btnTilesetSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilesetSave.Name = "btnTilesetSave";
            this.btnTilesetSave.Size = new System.Drawing.Size(172, 23);
            this.btnTilesetSave.TabIndex = 1;
            this.btnTilesetSave.Text = "Save Tileset";
            this.btnTilesetSave.UseVisualStyleBackColor = true;
            this.btnTilesetSave.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnTilesetValidate
            // 
            this.btnTilesetValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilesetValidate.Location = new System.Drawing.Point(0, 0);
            this.btnTilesetValidate.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilesetValidate.Name = "btnTilesetValidate";
            this.btnTilesetValidate.Size = new System.Drawing.Size(172, 23);
            this.btnTilesetValidate.TabIndex = 0;
            this.btnTilesetValidate.Text = "Validate Tileset";
            this.btnTilesetValidate.UseVisualStyleBackColor = true;
            this.btnTilesetValidate.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // pnlTilesetOptions
            // 
            this.pnlTilesetOptions.Controls.Add(this.rad4Bpp);
            this.pnlTilesetOptions.Controls.Add(this.rad2Bpp);
            this.pnlTilesetOptions.Controls.Add(this.rad3Bpp);
            this.pnlTilesetOptions.Controls.Add(this.rad1Bpp);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetBpp);
            this.pnlTilesetOptions.Controls.Add(this.nudTilesetHex);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetHex);
            this.pnlTilesetOptions.Controls.Add(this.grpTilesetDivider);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetLength);
            this.pnlTilesetOptions.Controls.Add(this.chkTilesetMasked);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetID);
            this.pnlTilesetOptions.Controls.Add(this.nudTilesetLength);
            this.pnlTilesetOptions.Controls.Add(this.txtTilesetName);
            this.pnlTilesetOptions.Controls.Add(this.pnlTilesetPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.nudTilesetOffset);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetName);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetPalette);
            this.pnlTilesetOptions.Controls.Add(this.nudTilesetID);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetOffset);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.cbTilesetPalette);
            this.pnlTilesetOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlTilesetOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTilesetOptions.Name = "pnlTilesetOptions";
            this.pnlTilesetOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlTilesetOptions.TabIndex = 2;
            // 
            // nudTilesetHex
            // 
            this.nudTilesetHex.Hexadecimal = true;
            this.nudTilesetHex.Location = new System.Drawing.Point(88, 16);
            this.nudTilesetHex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilesetHex.Name = "nudTilesetHex";
            this.nudTilesetHex.Size = new System.Drawing.Size(80, 22);
            this.nudTilesetHex.TabIndex = 3;
            this.nudTilesetHex.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblTilesetHex
            // 
            this.lblTilesetHex.AutoSize = true;
            this.lblTilesetHex.Location = new System.Drawing.Point(88, 0);
            this.lblTilesetHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetHex.Name = "lblTilesetHex";
            this.lblTilesetHex.Size = new System.Drawing.Size(80, 13);
            this.lblTilesetHex.TabIndex = 2;
            this.lblTilesetHex.Text = "Position (Hex):";
            this.lblTilesetHex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpTilesetDivider
            // 
            this.grpTilesetDivider.Location = new System.Drawing.Point(-2, 240);
            this.grpTilesetDivider.Name = "grpTilesetDivider";
            this.grpTilesetDivider.Size = new System.Drawing.Size(176, 5);
            this.grpTilesetDivider.TabIndex = 13;
            this.grpTilesetDivider.TabStop = false;
            // 
            // lblTilesetLength
            // 
            this.lblTilesetLength.AutoSize = true;
            this.lblTilesetLength.Location = new System.Drawing.Point(0, 120);
            this.lblTilesetLength.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetLength.Name = "lblTilesetLength";
            this.lblTilesetLength.Size = new System.Drawing.Size(46, 13);
            this.lblTilesetLength.TabIndex = 8;
            this.lblTilesetLength.Text = "Length:";
            this.lblTilesetLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTilesetMasked
            // 
            this.chkTilesetMasked.AutoSize = true;
            this.chkTilesetMasked.Location = new System.Drawing.Point(0, 216);
            this.chkTilesetMasked.Name = "chkTilesetMasked";
            this.chkTilesetMasked.Size = new System.Drawing.Size(66, 17);
            this.chkTilesetMasked.TabIndex = 12;
            this.chkTilesetMasked.Text = "Masked";
            this.chkTilesetMasked.UseVisualStyleBackColor = true;
            // 
            // lblTilesetID
            // 
            this.lblTilesetID.AutoSize = true;
            this.lblTilesetID.Location = new System.Drawing.Point(0, 0);
            this.lblTilesetID.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetID.Name = "lblTilesetID";
            this.lblTilesetID.Size = new System.Drawing.Size(72, 13);
            this.lblTilesetID.TabIndex = 0;
            this.lblTilesetID.Text = "Position (ID):";
            this.lblTilesetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilesetLength
            // 
            this.nudTilesetLength.Location = new System.Drawing.Point(0, 136);
            this.nudTilesetLength.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilesetLength.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudTilesetLength.Name = "nudTilesetLength";
            this.nudTilesetLength.Size = new System.Drawing.Size(80, 22);
            this.nudTilesetLength.TabIndex = 9;
            this.nudTilesetLength.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // txtTilesetName
            // 
            this.txtTilesetName.Location = new System.Drawing.Point(0, 56);
            this.txtTilesetName.MaxLength = 50;
            this.txtTilesetName.Name = "txtTilesetName";
            this.txtTilesetName.Size = new System.Drawing.Size(168, 22);
            this.txtTilesetName.TabIndex = 5;
            // 
            // pnlTilesetPalette
            // 
            this.pnlTilesetPalette.Location = new System.Drawing.Point(0, 292);
            this.pnlTilesetPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilesetPalette.Name = "pnlTilesetPalette";
            this.pnlTilesetPalette.ReadOnly = true;
            this.pnlTilesetPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlTilesetPalette.TabIndex = 16;
            // 
            // cbTilesetCompression
            // 
            this.cbTilesetCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetCompression.FormattingEnabled = true;
            this.cbTilesetCompression.Location = new System.Drawing.Point(0, 96);
            this.cbTilesetCompression.Name = "cbTilesetCompression";
            this.cbTilesetCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilesetCompression.TabIndex = 7;
            // 
            // nudTilesetOffset
            // 
            this.nudTilesetOffset.Location = new System.Drawing.Point(88, 136);
            this.nudTilesetOffset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTilesetOffset.Name = "nudTilesetOffset";
            this.nudTilesetOffset.Size = new System.Drawing.Size(80, 22);
            this.nudTilesetOffset.TabIndex = 11;
            // 
            // lblTilesetName
            // 
            this.lblTilesetName.AutoSize = true;
            this.lblTilesetName.Location = new System.Drawing.Point(0, 40);
            this.lblTilesetName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetName.Name = "lblTilesetName";
            this.lblTilesetName.Size = new System.Drawing.Size(75, 13);
            this.lblTilesetName.TabIndex = 4;
            this.lblTilesetName.Text = "Tileset Name:";
            this.lblTilesetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilesetPalette
            // 
            this.lblTilesetPalette.AutoSize = true;
            this.lblTilesetPalette.Location = new System.Drawing.Point(0, 252);
            this.lblTilesetPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetPalette.Name = "lblTilesetPalette";
            this.lblTilesetPalette.Size = new System.Drawing.Size(45, 13);
            this.lblTilesetPalette.TabIndex = 14;
            this.lblTilesetPalette.Text = "Palette:";
            this.lblTilesetPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilesetID
            // 
            this.nudTilesetID.Location = new System.Drawing.Point(0, 16);
            this.nudTilesetID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTilesetID.Name = "nudTilesetID";
            this.nudTilesetID.Size = new System.Drawing.Size(80, 22);
            this.nudTilesetID.TabIndex = 1;
            this.nudTilesetID.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblTilesetOffset
            // 
            this.lblTilesetOffset.AutoSize = true;
            this.lblTilesetOffset.Location = new System.Drawing.Point(88, 120);
            this.lblTilesetOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetOffset.Name = "lblTilesetOffset";
            this.lblTilesetOffset.Size = new System.Drawing.Size(42, 13);
            this.lblTilesetOffset.TabIndex = 10;
            this.lblTilesetOffset.Text = "Offset:";
            this.lblTilesetOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilesetCompression
            // 
            this.lblTilesetCompression.AutoSize = true;
            this.lblTilesetCompression.Location = new System.Drawing.Point(0, 80);
            this.lblTilesetCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetCompression.Name = "lblTilesetCompression";
            this.lblTilesetCompression.Size = new System.Drawing.Size(77, 13);
            this.lblTilesetCompression.TabIndex = 6;
            this.lblTilesetCompression.Text = "Compression:";
            this.lblTilesetCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilesetPalette
            // 
            this.cbTilesetPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetPalette.FormattingEnabled = true;
            this.cbTilesetPalette.Location = new System.Drawing.Point(0, 268);
            this.cbTilesetPalette.Name = "cbTilesetPalette";
            this.cbTilesetPalette.Size = new System.Drawing.Size(168, 21);
            this.cbTilesetPalette.TabIndex = 15;
            this.cbTilesetPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // lblTilesetBpp
            // 
            this.lblTilesetBpp.AutoSize = true;
            this.lblTilesetBpp.Location = new System.Drawing.Point(0, 160);
            this.lblTilesetBpp.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetBpp.Name = "lblTilesetBpp";
            this.lblTilesetBpp.Size = new System.Drawing.Size(73, 13);
            this.lblTilesetBpp.TabIndex = 17;
            this.lblTilesetBpp.Text = "Bits Per Pixel:";
            this.lblTilesetBpp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad1Bpp
            // 
            this.rad1Bpp.AutoSize = true;
            this.rad1Bpp.Location = new System.Drawing.Point(0, 176);
            this.rad1Bpp.Name = "rad1Bpp";
            this.rad1Bpp.Size = new System.Drawing.Size(55, 17);
            this.rad1Bpp.TabIndex = 18;
            this.rad1Bpp.TabStop = true;
            this.rad1Bpp.Text = "1 bpp";
            this.rad1Bpp.UseVisualStyleBackColor = true;
            // 
            // rad3Bpp
            // 
            this.rad3Bpp.AutoSize = true;
            this.rad3Bpp.Location = new System.Drawing.Point(0, 192);
            this.rad3Bpp.Name = "rad3Bpp";
            this.rad3Bpp.Size = new System.Drawing.Size(55, 17);
            this.rad3Bpp.TabIndex = 19;
            this.rad3Bpp.TabStop = true;
            this.rad3Bpp.Text = "3 bpp";
            this.rad3Bpp.UseVisualStyleBackColor = true;
            // 
            // rad2Bpp
            // 
            this.rad2Bpp.AutoSize = true;
            this.rad2Bpp.Location = new System.Drawing.Point(88, 176);
            this.rad2Bpp.Name = "rad2Bpp";
            this.rad2Bpp.Size = new System.Drawing.Size(55, 17);
            this.rad2Bpp.TabIndex = 20;
            this.rad2Bpp.TabStop = true;
            this.rad2Bpp.Text = "2 bpp";
            this.rad2Bpp.UseVisualStyleBackColor = true;
            // 
            // rad4Bpp
            // 
            this.rad4Bpp.AutoSize = true;
            this.rad4Bpp.Checked = true;
            this.rad4Bpp.Location = new System.Drawing.Point(88, 192);
            this.rad4Bpp.Name = "rad4Bpp";
            this.rad4Bpp.Size = new System.Drawing.Size(55, 17);
            this.rad4Bpp.TabIndex = 21;
            this.rad4Bpp.TabStop = true;
            this.rad4Bpp.Text = "4 bpp";
            this.rad4Bpp.UseVisualStyleBackColor = true;
            // 
            // AssetTilesetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlTilesetsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetTilesetControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlTilesetsMain.ResumeLayout(false);
            this.grpTilesetList.ResumeLayout(false);
            this.pnlTilesetButtons.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlTilesetsMain;
        private ImageControl pnlTilesetImage;
        private System.Windows.Forms.GroupBox grpTilesetList;
        private ListBoxControl lstTilesets;
        private System.Windows.Forms.Panel pnlTilesetButtons;
        private System.Windows.Forms.Button btnTilesetRemove;
        private System.Windows.Forms.Button btnTilesetSave;
        private System.Windows.Forms.Button btnTilesetValidate;
        private System.Windows.Forms.Panel pnlTilesetOptions;
        private System.Windows.Forms.Label lblTilesetLength;
        private System.Windows.Forms.CheckBox chkTilesetMasked;
        private System.Windows.Forms.Label lblTilesetID;
        private System.Windows.Forms.NumericUpDown nudTilesetLength;
        private System.Windows.Forms.TextBox txtTilesetName;
        private PaletteControl pnlTilesetPalette;
        private System.Windows.Forms.ComboBox cbTilesetCompression;
        private System.Windows.Forms.NumericUpDown nudTilesetOffset;
        private System.Windows.Forms.Label lblTilesetName;
        private System.Windows.Forms.Label lblTilesetPalette;
        private System.Windows.Forms.NumericUpDown nudTilesetID;
        private System.Windows.Forms.Label lblTilesetOffset;
        private System.Windows.Forms.Label lblTilesetCompression;
        private System.Windows.Forms.ComboBox cbTilesetPalette;
        private System.Windows.Forms.GroupBox grpTilesetDivider;
        private System.Windows.Forms.Label lblTilesetHex;
        private System.Windows.Forms.NumericUpDown nudTilesetHex;
        private System.Windows.Forms.Label lblTilesetBpp;
        private System.Windows.Forms.RadioButton rad4Bpp;
        private System.Windows.Forms.RadioButton rad2Bpp;
        private System.Windows.Forms.RadioButton rad3Bpp;
        private System.Windows.Forms.RadioButton rad1Bpp;
    }
}
