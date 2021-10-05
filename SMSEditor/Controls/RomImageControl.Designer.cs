namespace SMSEditor.Controls
{
    partial class RomImageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomImageControl));
            this.tpnlRomImageMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRomImage = new SMSEditor.Controls.ImageControl();
            this.pnlRomImageOptions = new System.Windows.Forms.Panel();
            this.nudRomImageHex = new System.Windows.Forms.NumericUpDown();
            this.lblRomImageHex = new System.Windows.Forms.Label();
            this.nudRomImagePosition = new System.Windows.Forms.NumericUpDown();
            this.lblRomImagePosition = new System.Windows.Forms.Label();
            this.lblRomImageSelectedTile = new System.Windows.Forms.Label();
            this.lblRomImageSelectedPalette = new System.Windows.Forms.Label();
            this.cbRomImageBGPalette = new System.Windows.Forms.ComboBox();
            this.lblRomImageSPRPalette = new System.Windows.Forms.Label();
            this.cbRomImageSPRPalette = new System.Windows.Forms.ComboBox();
            this.radRomImageBGPalette = new System.Windows.Forms.RadioButton();
            this.lblRomImageBGPalette = new System.Windows.Forms.Label();
            this.radRomImageSPRPalette = new System.Windows.Forms.RadioButton();
            this.pnlRomImageBGPalette = new SMSEditor.Controls.PaletteControl();
            this.pnlRomImageSPRPalette = new SMSEditor.Controls.PaletteControl();
            this.pnlRomImageTile = new SMSEditor.Controls.TileControl();
            this.tpnlRomImageMain.SuspendLayout();
            this.pnlRomImageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImageHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImagePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlRomImageMain
            // 
            this.tpnlRomImageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tpnlRomImageMain.ColumnCount = 2;
            this.tpnlRomImageMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlRomImageMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlRomImageMain.Controls.Add(this.pnlRomImage, 0, 0);
            this.tpnlRomImageMain.Controls.Add(this.pnlRomImageOptions, 1, 0);
            this.tpnlRomImageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlRomImageMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlRomImageMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlRomImageMain.Name = "tpnlRomImageMain";
            this.tpnlRomImageMain.RowCount = 1;
            this.tpnlRomImageMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.tpnlRomImageMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlRomImageMain.TabIndex = 0;
            // 
            // pnlRomImage
            // 
            this.pnlRomImage.AutoScroll = true;
            this.pnlRomImage.AutoScrollMinSize = new System.Drawing.Size(2460, 2084);
            this.pnlRomImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlRomImage.Centered = false;
            this.pnlRomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRomImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlRomImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlRomImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlRomImage.Image = null;
            this.pnlRomImage.ImageAlpha = 1F;
            this.pnlRomImage.ImageScale = 4;
            this.pnlRomImage.Location = new System.Drawing.Point(3, 3);
            this.pnlRomImage.MinimumScale = 1;
            this.pnlRomImage.Name = "pnlRomImage";
            this.pnlRomImage.Size = new System.Drawing.Size(632, 538);
            this.pnlRomImage.SnapSize = new System.Drawing.Size(4, 4);
            this.pnlRomImage.TabIndex = 0;
            this.pnlRomImage.UseCanvas = false;
            this.pnlRomImage.UseHatch = true;
            this.pnlRomImage.UseMouseWheelScaling = false;
            // 
            // pnlRomImageOptions
            // 
            this.pnlRomImageOptions.Controls.Add(this.nudRomImageHex);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImageHex);
            this.pnlRomImageOptions.Controls.Add(this.nudRomImagePosition);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImagePosition);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImageSelectedTile);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImageSelectedPalette);
            this.pnlRomImageOptions.Controls.Add(this.cbRomImageBGPalette);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImageSPRPalette);
            this.pnlRomImageOptions.Controls.Add(this.cbRomImageSPRPalette);
            this.pnlRomImageOptions.Controls.Add(this.radRomImageBGPalette);
            this.pnlRomImageOptions.Controls.Add(this.lblRomImageBGPalette);
            this.pnlRomImageOptions.Controls.Add(this.radRomImageSPRPalette);
            this.pnlRomImageOptions.Controls.Add(this.pnlRomImageBGPalette);
            this.pnlRomImageOptions.Controls.Add(this.pnlRomImageSPRPalette);
            this.pnlRomImageOptions.Controls.Add(this.pnlRomImageTile);
            this.pnlRomImageOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRomImageOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlRomImageOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlRomImageOptions.Name = "pnlRomImageOptions";
            this.pnlRomImageOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlRomImageOptions.TabIndex = 1;
            // 
            // nudRomImageHex
            // 
            this.nudRomImageHex.Hexadecimal = true;
            this.nudRomImageHex.Location = new System.Drawing.Point(88, 16);
            this.nudRomImageHex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudRomImageHex.Name = "nudRomImageHex";
            this.nudRomImageHex.Size = new System.Drawing.Size(80, 20);
            this.nudRomImageHex.TabIndex = 3;
            // 
            // lblRomImageHex
            // 
            this.lblRomImageHex.AutoSize = true;
            this.lblRomImageHex.Location = new System.Drawing.Point(88, 0);
            this.lblRomImageHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImageHex.Name = "lblRomImageHex";
            this.lblRomImageHex.Size = new System.Drawing.Size(75, 13);
            this.lblRomImageHex.TabIndex = 2;
            this.lblRomImageHex.Text = "Position (Hex):";
            this.lblRomImageHex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRomImagePosition
            // 
            this.nudRomImagePosition.Location = new System.Drawing.Point(0, 16);
            this.nudRomImagePosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudRomImagePosition.Name = "nudRomImagePosition";
            this.nudRomImagePosition.Size = new System.Drawing.Size(80, 20);
            this.nudRomImagePosition.TabIndex = 1;
            // 
            // lblRomImagePosition
            // 
            this.lblRomImagePosition.AutoSize = true;
            this.lblRomImagePosition.Location = new System.Drawing.Point(0, 0);
            this.lblRomImagePosition.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImagePosition.Name = "lblRomImagePosition";
            this.lblRomImagePosition.Size = new System.Drawing.Size(67, 13);
            this.lblRomImagePosition.TabIndex = 0;
            this.lblRomImagePosition.Text = "Position (ID):";
            this.lblRomImagePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRomImageSelectedTile
            // 
            this.lblRomImageSelectedTile.AutoSize = true;
            this.lblRomImageSelectedTile.Location = new System.Drawing.Point(0, 40);
            this.lblRomImageSelectedTile.Name = "lblRomImageSelectedTile";
            this.lblRomImageSelectedTile.Size = new System.Drawing.Size(72, 13);
            this.lblRomImageSelectedTile.TabIndex = 4;
            this.lblRomImageSelectedTile.Text = "Selected Tile:";
            // 
            // lblRomImageSelectedPalette
            // 
            this.lblRomImageSelectedPalette.AutoSize = true;
            this.lblRomImageSelectedPalette.Location = new System.Drawing.Point(0, 232);
            this.lblRomImageSelectedPalette.Name = "lblRomImageSelectedPalette";
            this.lblRomImageSelectedPalette.Size = new System.Drawing.Size(88, 13);
            this.lblRomImageSelectedPalette.TabIndex = 6;
            this.lblRomImageSelectedPalette.Text = "Selected Palette:";
            // 
            // cbRomImageBGPalette
            // 
            this.cbRomImageBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRomImageBGPalette.FormattingEnabled = true;
            this.cbRomImageBGPalette.Location = new System.Drawing.Point(0, 288);
            this.cbRomImageBGPalette.Name = "cbRomImageBGPalette";
            this.cbRomImageBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbRomImageBGPalette.TabIndex = 10;
            this.cbRomImageBGPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // lblRomImageSPRPalette
            // 
            this.lblRomImageSPRPalette.AutoSize = true;
            this.lblRomImageSPRPalette.Location = new System.Drawing.Point(0, 360);
            this.lblRomImageSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImageSPRPalette.Name = "lblRomImageSPRPalette";
            this.lblRomImageSPRPalette.Size = new System.Drawing.Size(73, 13);
            this.lblRomImageSPRPalette.TabIndex = 12;
            this.lblRomImageSPRPalette.Text = "Sprite Palette:";
            this.lblRomImageSPRPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRomImageSPRPalette
            // 
            this.cbRomImageSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRomImageSPRPalette.FormattingEnabled = true;
            this.cbRomImageSPRPalette.Location = new System.Drawing.Point(0, 376);
            this.cbRomImageSPRPalette.Name = "cbRomImageSPRPalette";
            this.cbRomImageSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbRomImageSPRPalette.TabIndex = 13;
            this.cbRomImageSPRPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // radRomImageBGPalette
            // 
            this.radRomImageBGPalette.AutoSize = true;
            this.radRomImageBGPalette.Checked = true;
            this.radRomImageBGPalette.Location = new System.Drawing.Point(0, 248);
            this.radRomImageBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.radRomImageBGPalette.Name = "radRomImageBGPalette";
            this.radRomImageBGPalette.Size = new System.Drawing.Size(83, 17);
            this.radRomImageBGPalette.TabIndex = 7;
            this.radRomImageBGPalette.TabStop = true;
            this.radRomImageBGPalette.Text = "Background";
            this.radRomImageBGPalette.UseVisualStyleBackColor = true;
            this.radRomImageBGPalette.CheckedChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // lblRomImageBGPalette
            // 
            this.lblRomImageBGPalette.AutoSize = true;
            this.lblRomImageBGPalette.Location = new System.Drawing.Point(0, 272);
            this.lblRomImageBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImageBGPalette.Name = "lblRomImageBGPalette";
            this.lblRomImageBGPalette.Size = new System.Drawing.Size(104, 13);
            this.lblRomImageBGPalette.TabIndex = 9;
            this.lblRomImageBGPalette.Text = "Background Palette:";
            this.lblRomImageBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radRomImageSPRPalette
            // 
            this.radRomImageSPRPalette.AutoSize = true;
            this.radRomImageSPRPalette.Location = new System.Drawing.Point(88, 248);
            this.radRomImageSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.radRomImageSPRPalette.Name = "radRomImageSPRPalette";
            this.radRomImageSPRPalette.Size = new System.Drawing.Size(52, 17);
            this.radRomImageSPRPalette.TabIndex = 8;
            this.radRomImageSPRPalette.Text = "Sprite";
            this.radRomImageSPRPalette.UseVisualStyleBackColor = true;
            this.radRomImageSPRPalette.CheckedChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // pnlRomImageBGPalette
            // 
            this.pnlRomImageBGPalette.Location = new System.Drawing.Point(0, 312);
            this.pnlRomImageBGPalette.Name = "pnlRomImageBGPalette";
            this.pnlRomImageBGPalette.ReadOnly = true;
            this.pnlRomImageBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlRomImageBGPalette.TabIndex = 11;
            // 
            // pnlRomImageSPRPalette
            // 
            this.pnlRomImageSPRPalette.Location = new System.Drawing.Point(0, 400);
            this.pnlRomImageSPRPalette.Name = "pnlRomImageSPRPalette";
            this.pnlRomImageSPRPalette.ReadOnly = true;
            this.pnlRomImageSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlRomImageSPRPalette.TabIndex = 14;
            // 
            // pnlRomImageTile
            // 
            this.pnlRomImageTile.AutoScroll = true;
            this.pnlRomImageTile.AutoScrollMinSize = new System.Drawing.Size(168, 168);
            this.pnlRomImageTile.Canvas = new System.Drawing.Size(8, 8);
            this.pnlRomImageTile.Centered = false;
            this.pnlRomImageTile.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlRomImageTile.HatchForeColor = System.Drawing.Color.White;
            this.pnlRomImageTile.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlRomImageTile.Image = null;
            this.pnlRomImageTile.ImageAlpha = 1F;
            this.pnlRomImageTile.ImageScale = 1;
            this.pnlRomImageTile.Location = new System.Drawing.Point(0, 56);
            this.pnlRomImageTile.MinimumScale = 1;
            this.pnlRomImageTile.Name = "pnlRomImageTile";
            this.pnlRomImageTile.Palette = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pnlRomImageTile.Palette")));
            this.pnlRomImageTile.Pixels = ((System.Collections.Generic.List<byte>)(resources.GetObject("pnlRomImageTile.Pixels")));
            this.pnlRomImageTile.SelectedColor = ((byte)(0));
            this.pnlRomImageTile.SelectedTileID = 0;
            this.pnlRomImageTile.Size = new System.Drawing.Size(168, 168);
            this.pnlRomImageTile.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlRomImageTile.TabIndex = 5;
            this.pnlRomImageTile.TargetColor = ((byte)(0));
            this.pnlRomImageTile.UseCanvas = false;
            this.pnlRomImageTile.UseHatch = true;
            this.pnlRomImageTile.UseMouseWheelScaling = false;
            // 
            // RomImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlRomImageMain);
            this.Name = "RomImageControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlRomImageMain.ResumeLayout(false);
            this.pnlRomImageOptions.ResumeLayout(false);
            this.pnlRomImageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImageHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImagePosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlRomImageMain;
        private ImageControl pnlRomImage;
        private System.Windows.Forms.Panel pnlRomImageOptions;
        private System.Windows.Forms.ComboBox cbRomImageBGPalette;
        private System.Windows.Forms.Label lblRomImageSPRPalette;
        private System.Windows.Forms.ComboBox cbRomImageSPRPalette;
        private System.Windows.Forms.RadioButton radRomImageBGPalette;
        private System.Windows.Forms.Label lblRomImageBGPalette;
        private System.Windows.Forms.RadioButton radRomImageSPRPalette;
        private PaletteControl pnlRomImageBGPalette;
        private PaletteControl pnlRomImageSPRPalette;
        private TileControl pnlRomImageTile;
        private System.Windows.Forms.Label lblRomImageSelectedPalette;
        private System.Windows.Forms.Label lblRomImageSelectedTile;
        private System.Windows.Forms.NumericUpDown nudRomImageHex;
        private System.Windows.Forms.Label lblRomImageHex;
        private System.Windows.Forms.NumericUpDown nudRomImagePosition;
        private System.Windows.Forms.Label lblRomImagePosition;
    }
}
