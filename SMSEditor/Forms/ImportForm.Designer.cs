namespace SMSEditor.Forms
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFlipOptions = new System.Windows.Forms.ComboBox();
            this.btnSetAllSPRPalette = new System.Windows.Forms.Button();
            this.btnSetAllBGPalette = new System.Windows.Forms.Button();
            this.chkShowIndexes = new System.Windows.Forms.CheckBox();
            this.chkAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.radSprPalette = new System.Windows.Forms.RadioButton();
            this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.radBGPalette = new System.Windows.Forms.RadioButton();
            this.grpIndexAdjustment = new System.Windows.Forms.GroupBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.sslTileset = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpTileset = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSpriteListTools = new System.Windows.Forms.Panel();
            this.lblSpriteTilemap = new System.Windows.Forms.Label();
            this.btnPreviousFrame = new System.Windows.Forms.Button();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.pnlTiles = new SMSEditor.Controls.PixelTileControl();
            this.pnlImage = new SMSEditor.Controls.TilemapImageControl();
            this.pnlPalettes = new SMSEditor.Controls.ColorEditControl();
            this.grpOptions.SuspendLayout();
            this.grpIndexAdjustment.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.grpTileset.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSpriteListTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.cbFlipOptions);
            this.grpOptions.Controls.Add(this.btnSetAllSPRPalette);
            this.grpOptions.Controls.Add(this.btnSetAllBGPalette);
            this.grpOptions.Controls.Add(this.chkShowIndexes);
            this.grpOptions.Controls.Add(this.chkAllowDuplicates);
            this.grpOptions.Controls.Add(this.radSprPalette);
            this.grpOptions.Controls.Add(this.chkIgnoreEmpty);
            this.grpOptions.Controls.Add(this.radBGPalette);
            this.grpOptions.Location = new System.Drawing.Point(8, 32);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(144, 520);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Compile Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Flipping Options:";
            // 
            // cbFlipOptions
            // 
            this.cbFlipOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlipOptions.FormattingEnabled = true;
            this.cbFlipOptions.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.cbFlipOptions.Location = new System.Drawing.Point(8, 148);
            this.cbFlipOptions.Name = "cbFlipOptions";
            this.cbFlipOptions.Size = new System.Drawing.Size(124, 21);
            this.cbFlipOptions.TabIndex = 5;
            this.cbFlipOptions.SelectedIndexChanged += new System.EventHandler(this.cbFlipOptions_SelectedIndexChanged);
            // 
            // btnSetAllSPRPalette
            // 
            this.btnSetAllSPRPalette.Location = new System.Drawing.Point(8, 96);
            this.btnSetAllSPRPalette.Name = "btnSetAllSPRPalette";
            this.btnSetAllSPRPalette.Size = new System.Drawing.Size(128, 23);
            this.btnSetAllSPRPalette.TabIndex = 3;
            this.btnSetAllSPRPalette.Text = "Set All SPR Palette";
            this.btnSetAllSPRPalette.UseVisualStyleBackColor = true;
            this.btnSetAllSPRPalette.Click += new System.EventHandler(this.btnSetAllPalette_Click);
            // 
            // btnSetAllBGPalette
            // 
            this.btnSetAllBGPalette.Location = new System.Drawing.Point(8, 72);
            this.btnSetAllBGPalette.Name = "btnSetAllBGPalette";
            this.btnSetAllBGPalette.Size = new System.Drawing.Size(128, 23);
            this.btnSetAllBGPalette.TabIndex = 2;
            this.btnSetAllBGPalette.Text = "Set All BG Palette";
            this.btnSetAllBGPalette.UseVisualStyleBackColor = true;
            this.btnSetAllBGPalette.Click += new System.EventHandler(this.btnSetAllPalette_Click);
            // 
            // chkShowIndexes
            // 
            this.chkShowIndexes.AutoSize = true;
            this.chkShowIndexes.Location = new System.Drawing.Point(8, 232);
            this.chkShowIndexes.Name = "chkShowIndexes";
            this.chkShowIndexes.Size = new System.Drawing.Size(135, 17);
            this.chkShowIndexes.TabIndex = 8;
            this.chkShowIndexes.Text = "Show Palette Indexes";
            this.chkShowIndexes.UseVisualStyleBackColor = true;
            this.chkShowIndexes.CheckedChanged += new System.EventHandler(this.chkOptions_CheckedChanged);
            // 
            // chkAllowDuplicates
            // 
            this.chkAllowDuplicates.AutoSize = true;
            this.chkAllowDuplicates.Location = new System.Drawing.Point(8, 208);
            this.chkAllowDuplicates.Name = "chkAllowDuplicates";
            this.chkAllowDuplicates.Size = new System.Drawing.Size(133, 17);
            this.chkAllowDuplicates.TabIndex = 7;
            this.chkAllowDuplicates.Text = "Allow Duplicate Tiles";
            this.chkAllowDuplicates.UseVisualStyleBackColor = true;
            this.chkAllowDuplicates.CheckedChanged += new System.EventHandler(this.chkOptions_CheckedChanged);
            // 
            // radSprPalette
            // 
            this.radSprPalette.AutoSize = true;
            this.radSprPalette.Location = new System.Drawing.Point(8, 48);
            this.radSprPalette.Name = "radSprPalette";
            this.radSprPalette.Size = new System.Drawing.Size(93, 17);
            this.radSprPalette.TabIndex = 1;
            this.radSprPalette.Text = "Sprite Palette";
            this.radSprPalette.UseVisualStyleBackColor = true;
            this.radSprPalette.CheckedChanged += new System.EventHandler(this.radPalette_CheckedChanged);
            // 
            // chkIgnoreEmpty
            // 
            this.chkIgnoreEmpty.AutoSize = true;
            this.chkIgnoreEmpty.Location = new System.Drawing.Point(8, 184);
            this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
            this.chkIgnoreEmpty.Size = new System.Drawing.Size(120, 17);
            this.chkIgnoreEmpty.TabIndex = 6;
            this.chkIgnoreEmpty.Text = "Ignore Empty Tiles";
            this.chkIgnoreEmpty.UseVisualStyleBackColor = true;
            this.chkIgnoreEmpty.CheckedChanged += new System.EventHandler(this.chkOptions_CheckedChanged);
            // 
            // radBGPalette
            // 
            this.radBGPalette.AutoSize = true;
            this.radBGPalette.Checked = true;
            this.radBGPalette.Location = new System.Drawing.Point(8, 24);
            this.radBGPalette.Name = "radBGPalette";
            this.radBGPalette.Size = new System.Drawing.Size(125, 17);
            this.radBGPalette.TabIndex = 0;
            this.radBGPalette.TabStop = true;
            this.radBGPalette.Text = "Background Palette";
            this.radBGPalette.UseVisualStyleBackColor = true;
            this.radBGPalette.CheckedChanged += new System.EventHandler(this.radPalette_CheckedChanged);
            // 
            // grpIndexAdjustment
            // 
            this.grpIndexAdjustment.Controls.Add(this.pnlPalettes);
            this.grpIndexAdjustment.Location = new System.Drawing.Point(160, 432);
            this.grpIndexAdjustment.Name = "grpIndexAdjustment";
            this.grpIndexAdjustment.Size = new System.Drawing.Size(592, 120);
            this.grpIndexAdjustment.TabIndex = 4;
            this.grpIndexAdjustment.TabStop = false;
            this.grpIndexAdjustment.Text = "Import Palette Match";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTileset,
            this.sslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 594);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(760, 22);
            this.ssMain.TabIndex = 6;
            this.ssMain.Text = "statusStrip1";
            // 
            // sslTileset
            // 
            this.sslTileset.Name = "sslTileset";
            this.sslTileset.Size = new System.Drawing.Size(40, 17);
            this.sslTileset.Text = "Tileset";
            // 
            // sslStatus
            // 
            this.sslStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sslStatus.ForeColor = System.Drawing.Color.SlateBlue;
            this.sslStatus.Name = "sslStatus";
            this.sslStatus.Size = new System.Drawing.Size(42, 17);
            this.sslStatus.Text = "Status";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(680, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(600, 560);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpTileset
            // 
            this.grpTileset.Controls.Add(this.pnlImage);
            this.grpTileset.Location = new System.Drawing.Point(160, 8);
            this.grpTileset.Name = "grpTileset";
            this.grpTileset.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.grpTileset.Size = new System.Drawing.Size(352, 416);
            this.grpTileset.TabIndex = 2;
            this.grpTileset.TabStop = false;
            this.grpTileset.Text = "Image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTiles);
            this.groupBox1.Location = new System.Drawing.Point(520, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 8, 11, 12);
            this.groupBox1.Size = new System.Drawing.Size(232, 416);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tileset";
            // 
            // pnlSpriteListTools
            // 
            this.pnlSpriteListTools.Controls.Add(this.lblSpriteTilemap);
            this.pnlSpriteListTools.Controls.Add(this.btnPreviousFrame);
            this.pnlSpriteListTools.Controls.Add(this.btnNextFrame);
            this.pnlSpriteListTools.Location = new System.Drawing.Point(8, 8);
            this.pnlSpriteListTools.Name = "pnlSpriteListTools";
            this.pnlSpriteListTools.Size = new System.Drawing.Size(144, 21);
            this.pnlSpriteListTools.TabIndex = 0;
            // 
            // lblSpriteTilemap
            // 
            this.lblSpriteTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteTilemap.Location = new System.Drawing.Point(25, 0);
            this.lblSpriteTilemap.Name = "lblSpriteTilemap";
            this.lblSpriteTilemap.Size = new System.Drawing.Size(94, 21);
            this.lblSpriteTilemap.TabIndex = 1;
            this.lblSpriteTilemap.Text = "Tilemap";
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
            this.btnNextFrame.Location = new System.Drawing.Point(119, 0);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(25, 21);
            this.btnNextFrame.TabIndex = 2;
            this.btnNextFrame.Text = ">>";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // pnlTiles
            // 
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(576, 1092);
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = true;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 3;
            this.pnlTiles.Indexed = false;
            this.pnlTiles.Location = new System.Drawing.Point(12, 23);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.SelectedTilesetID = 0;
            this.pnlTiles.Size = new System.Drawing.Size(209, 381);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseHatch = true;
            this.pnlTiles.UseMouseWheelScaling = false;
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.AutoScrollMinSize = new System.Drawing.Size(328, 381);
            this.pnlImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlImage.Centered = true;
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Frames = ((System.Collections.Generic.List<System.Drawing.Rectangle>)(resources.GetObject("pnlImage.Frames")));
            this.pnlImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlImage.Image = null;
            this.pnlImage.ImageAlpha = 1F;
            this.pnlImage.ImageScale = 1;
            this.pnlImage.Index = 0;
            this.pnlImage.Location = new System.Drawing.Point(12, 23);
            this.pnlImage.MinimumScale = 1;
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(328, 381);
            this.pnlImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlImage.TabIndex = 0;
            this.pnlImage.UseCanvas = false;
            this.pnlImage.UseHatch = true;
            this.pnlImage.UseMouseWheelScaling = true;
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.BGPaletteSelected = true;
            this.pnlPalettes.Location = new System.Drawing.Point(16, 24);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(560, 80);
            this.pnlPalettes.TabIndex = 0;
            this.pnlPalettes.ColorShifted += new SMSEditor.Controls.ColorEditControl.ColorShiftedHandler(this.pnlColors_ColorShifted);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 616);
            this.Controls.Add(this.pnlSpriteListTools);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTileset);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpIndexAdjustment);
            this.Controls.Add(this.grpOptions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Graphics";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpIndexAdjustment.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.grpTileset.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlSpriteListTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.PixelTileControl pnlTiles;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFlipOptions;
        private System.Windows.Forms.Button btnSetAllSPRPalette;
        private System.Windows.Forms.Button btnSetAllBGPalette;
        private System.Windows.Forms.CheckBox chkShowIndexes;
        private System.Windows.Forms.CheckBox chkAllowDuplicates;
        private System.Windows.Forms.RadioButton radSprPalette;
        private System.Windows.Forms.CheckBox chkIgnoreEmpty;
        private System.Windows.Forms.RadioButton radBGPalette;
        private System.Windows.Forms.GroupBox grpIndexAdjustment;
        private Controls.ColorEditControl pnlPalettes;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel sslTileset;
        private System.Windows.Forms.ToolStripStatusLabel sslStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpTileset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlSpriteListTools;
        private System.Windows.Forms.Label lblSpriteTilemap;
        private System.Windows.Forms.Button btnPreviousFrame;
        private System.Windows.Forms.Button btnNextFrame;
        private Controls.TilemapImageControl pnlImage;
    }
}