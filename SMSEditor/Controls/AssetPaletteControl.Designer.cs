namespace SMSEditor.Controls
{
    partial class AssetPaletteControl
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
            this.tpnlPalettesMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaletteColors = new SMSEditor.Controls.PaletteControl();
            this.grpPaletteList = new System.Windows.Forms.GroupBox();
            this.lstPalettes = new SMSEditor.Controls.ListBoxControl();
            this.pnlPaletteButtons = new System.Windows.Forms.Panel();
            this.btnPaletteRemove = new System.Windows.Forms.Button();
            this.btnPaletteSave = new System.Windows.Forms.Button();
            this.btnPaletteValidate = new System.Windows.Forms.Button();
            this.pnlPaletteOptions = new System.Windows.Forms.Panel();
            this.nudPaletteHex = new System.Windows.Forms.NumericUpDown();
            this.lblPaletteHex = new System.Windows.Forms.Label();
            this.nudPaletteID = new System.Windows.Forms.NumericUpDown();
            this.lblPaletteOffset = new System.Windows.Forms.Label();
            this.lblPaletteID = new System.Windows.Forms.Label();
            this.lblPalettePartial = new System.Windows.Forms.Label();
            this.pnlPalettePartial = new SMSEditor.Controls.PaletteControl();
            this.cbPaletteCompression = new System.Windows.Forms.ComboBox();
            this.lblPaletteLength = new System.Windows.Forms.Label();
            this.txtPaletteName = new System.Windows.Forms.TextBox();
            this.lblPaletteName = new System.Windows.Forms.Label();
            this.nudPaletteLength = new System.Windows.Forms.NumericUpDown();
            this.lblPaletteCompression = new System.Windows.Forms.Label();
            this.cbPalettePartial = new System.Windows.Forms.ComboBox();
            this.nudPaletteOffset = new System.Windows.Forms.NumericUpDown();
            this.tpnlPalettesMain.SuspendLayout();
            this.grpPaletteList.SuspendLayout();
            this.pnlPaletteButtons.SuspendLayout();
            this.pnlPaletteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlPalettesMain
            // 
            this.tpnlPalettesMain.ColumnCount = 3;
            this.tpnlPalettesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlPalettesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalettesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlPalettesMain.Controls.Add(this.pnlPaletteColors, 1, 0);
            this.tpnlPalettesMain.Controls.Add(this.grpPaletteList, 0, 0);
            this.tpnlPalettesMain.Controls.Add(this.pnlPaletteOptions, 2, 0);
            this.tpnlPalettesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlPalettesMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlPalettesMain.Name = "tpnlPalettesMain";
            this.tpnlPalettesMain.RowCount = 1;
            this.tpnlPalettesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalettesMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlPalettesMain.TabIndex = 1;
            // 
            // pnlPaletteColors
            // 
            this.pnlPaletteColors.Location = new System.Drawing.Point(199, 6);
            this.pnlPaletteColors.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pnlPaletteColors.Name = "pnlPaletteColors";
            this.pnlPaletteColors.ReadOnly = true;
            this.pnlPaletteColors.Size = new System.Drawing.Size(336, 80);
            this.pnlPaletteColors.TabIndex = 1;
            // 
            // grpPaletteList
            // 
            this.grpPaletteList.Controls.Add(this.lstPalettes);
            this.grpPaletteList.Controls.Add(this.pnlPaletteButtons);
            this.grpPaletteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaletteList.Location = new System.Drawing.Point(0, 0);
            this.grpPaletteList.Margin = new System.Windows.Forms.Padding(0);
            this.grpPaletteList.Name = "grpPaletteList";
            this.grpPaletteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpPaletteList.Size = new System.Drawing.Size(196, 544);
            this.grpPaletteList.TabIndex = 0;
            this.grpPaletteList.TabStop = false;
            this.grpPaletteList.Text = "Palettes";
            // 
            // lstPalettes
            // 
            this.lstPalettes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalettes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPalettes.FormattingEnabled = true;
            this.lstPalettes.HorizontalExtent = 170;
            this.lstPalettes.IntegralHeight = false;
            this.lstPalettes.ItemHeight = 15;
            this.lstPalettes.Location = new System.Drawing.Point(12, 89);
            this.lstPalettes.Name = "lstPalettes";
            this.lstPalettes.Size = new System.Drawing.Size(172, 443);
            this.lstPalettes.TabIndex = 1;
            this.lstPalettes.TextOffsetX = 2;
            this.lstPalettes.TextOffsetY = -1;
            this.lstPalettes.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // pnlPaletteButtons
            // 
            this.pnlPaletteButtons.Controls.Add(this.btnPaletteRemove);
            this.pnlPaletteButtons.Controls.Add(this.btnPaletteSave);
            this.pnlPaletteButtons.Controls.Add(this.btnPaletteValidate);
            this.pnlPaletteButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaletteButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlPaletteButtons.Name = "pnlPaletteButtons";
            this.pnlPaletteButtons.Size = new System.Drawing.Size(172, 70);
            this.pnlPaletteButtons.TabIndex = 0;
            // 
            // btnPaletteRemove
            // 
            this.btnPaletteRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaletteRemove.Location = new System.Drawing.Point(0, 46);
            this.btnPaletteRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaletteRemove.Name = "btnPaletteRemove";
            this.btnPaletteRemove.Size = new System.Drawing.Size(172, 23);
            this.btnPaletteRemove.TabIndex = 2;
            this.btnPaletteRemove.Text = "Remove Palette";
            this.btnPaletteRemove.UseVisualStyleBackColor = true;
            this.btnPaletteRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnPaletteSave
            // 
            this.btnPaletteSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaletteSave.Location = new System.Drawing.Point(0, 23);
            this.btnPaletteSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaletteSave.Name = "btnPaletteSave";
            this.btnPaletteSave.Size = new System.Drawing.Size(172, 23);
            this.btnPaletteSave.TabIndex = 1;
            this.btnPaletteSave.Text = "Save Palette";
            this.btnPaletteSave.UseVisualStyleBackColor = true;
            this.btnPaletteSave.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnPaletteValidate
            // 
            this.btnPaletteValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaletteValidate.Location = new System.Drawing.Point(0, 0);
            this.btnPaletteValidate.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaletteValidate.Name = "btnPaletteValidate";
            this.btnPaletteValidate.Size = new System.Drawing.Size(172, 23);
            this.btnPaletteValidate.TabIndex = 0;
            this.btnPaletteValidate.Text = "Validate Palette";
            this.btnPaletteValidate.UseVisualStyleBackColor = true;
            this.btnPaletteValidate.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // pnlPaletteOptions
            // 
            this.pnlPaletteOptions.Controls.Add(this.nudPaletteHex);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteHex);
            this.pnlPaletteOptions.Controls.Add(this.nudPaletteID);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteOffset);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteID);
            this.pnlPaletteOptions.Controls.Add(this.lblPalettePartial);
            this.pnlPaletteOptions.Controls.Add(this.pnlPalettePartial);
            this.pnlPaletteOptions.Controls.Add(this.cbPaletteCompression);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteLength);
            this.pnlPaletteOptions.Controls.Add(this.txtPaletteName);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteName);
            this.pnlPaletteOptions.Controls.Add(this.nudPaletteLength);
            this.pnlPaletteOptions.Controls.Add(this.lblPaletteCompression);
            this.pnlPaletteOptions.Controls.Add(this.cbPalettePartial);
            this.pnlPaletteOptions.Controls.Add(this.nudPaletteOffset);
            this.pnlPaletteOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlPaletteOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlPaletteOptions.Name = "pnlPaletteOptions";
            this.pnlPaletteOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlPaletteOptions.TabIndex = 2;
            // 
            // nudPaletteHex
            // 
            this.nudPaletteHex.Hexadecimal = true;
            this.nudPaletteHex.Location = new System.Drawing.Point(88, 16);
            this.nudPaletteHex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPaletteHex.Name = "nudPaletteHex";
            this.nudPaletteHex.Size = new System.Drawing.Size(80, 22);
            this.nudPaletteHex.TabIndex = 3;
            this.nudPaletteHex.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblPaletteHex
            // 
            this.lblPaletteHex.AutoSize = true;
            this.lblPaletteHex.Location = new System.Drawing.Point(88, 0);
            this.lblPaletteHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteHex.Name = "lblPaletteHex";
            this.lblPaletteHex.Size = new System.Drawing.Size(80, 13);
            this.lblPaletteHex.TabIndex = 2;
            this.lblPaletteHex.Text = "Position (Hex):";
            this.lblPaletteHex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPaletteID
            // 
            this.nudPaletteID.Location = new System.Drawing.Point(0, 16);
            this.nudPaletteID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPaletteID.Name = "nudPaletteID";
            this.nudPaletteID.Size = new System.Drawing.Size(80, 22);
            this.nudPaletteID.TabIndex = 1;
            this.nudPaletteID.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblPaletteOffset
            // 
            this.lblPaletteOffset.AutoSize = true;
            this.lblPaletteOffset.Location = new System.Drawing.Point(88, 120);
            this.lblPaletteOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteOffset.Name = "lblPaletteOffset";
            this.lblPaletteOffset.Size = new System.Drawing.Size(42, 13);
            this.lblPaletteOffset.TabIndex = 10;
            this.lblPaletteOffset.Text = "Offset:";
            this.lblPaletteOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaletteID
            // 
            this.lblPaletteID.AutoSize = true;
            this.lblPaletteID.Location = new System.Drawing.Point(0, 0);
            this.lblPaletteID.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteID.Name = "lblPaletteID";
            this.lblPaletteID.Size = new System.Drawing.Size(72, 13);
            this.lblPaletteID.TabIndex = 0;
            this.lblPaletteID.Text = "Position (ID):";
            this.lblPaletteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalettePartial
            // 
            this.lblPalettePartial.AutoSize = true;
            this.lblPalettePartial.Location = new System.Drawing.Point(0, 160);
            this.lblPalettePartial.Margin = new System.Windows.Forms.Padding(0);
            this.lblPalettePartial.Name = "lblPalettePartial";
            this.lblPalettePartial.Size = new System.Drawing.Size(80, 13);
            this.lblPalettePartial.TabIndex = 12;
            this.lblPalettePartial.Text = "Partial Palette:";
            this.lblPalettePartial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPalettePartial
            // 
            this.pnlPalettePartial.Location = new System.Drawing.Point(0, 200);
            this.pnlPalettePartial.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPalettePartial.Name = "pnlPalettePartial";
            this.pnlPalettePartial.ReadOnly = true;
            this.pnlPalettePartial.Size = new System.Drawing.Size(168, 40);
            this.pnlPalettePartial.TabIndex = 14;
            // 
            // cbPaletteCompression
            // 
            this.cbPaletteCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteCompression.FormattingEnabled = true;
            this.cbPaletteCompression.Location = new System.Drawing.Point(0, 96);
            this.cbPaletteCompression.Name = "cbPaletteCompression";
            this.cbPaletteCompression.Size = new System.Drawing.Size(168, 21);
            this.cbPaletteCompression.TabIndex = 7;
            // 
            // lblPaletteLength
            // 
            this.lblPaletteLength.AutoSize = true;
            this.lblPaletteLength.Location = new System.Drawing.Point(0, 120);
            this.lblPaletteLength.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteLength.Name = "lblPaletteLength";
            this.lblPaletteLength.Size = new System.Drawing.Size(46, 13);
            this.lblPaletteLength.TabIndex = 8;
            this.lblPaletteLength.Text = "Length:";
            this.lblPaletteLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaletteName
            // 
            this.txtPaletteName.Location = new System.Drawing.Point(0, 56);
            this.txtPaletteName.Name = "txtPaletteName";
            this.txtPaletteName.Size = new System.Drawing.Size(168, 22);
            this.txtPaletteName.TabIndex = 5;
            // 
            // lblPaletteName
            // 
            this.lblPaletteName.AutoSize = true;
            this.lblPaletteName.Location = new System.Drawing.Point(0, 40);
            this.lblPaletteName.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteName.Name = "lblPaletteName";
            this.lblPaletteName.Size = new System.Drawing.Size(77, 13);
            this.lblPaletteName.TabIndex = 4;
            this.lblPaletteName.Text = "Palette Name:";
            this.lblPaletteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPaletteLength
            // 
            this.nudPaletteLength.Location = new System.Drawing.Point(0, 136);
            this.nudPaletteLength.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPaletteLength.Name = "nudPaletteLength";
            this.nudPaletteLength.Size = new System.Drawing.Size(80, 22);
            this.nudPaletteLength.TabIndex = 9;
            // 
            // lblPaletteCompression
            // 
            this.lblPaletteCompression.AutoSize = true;
            this.lblPaletteCompression.Location = new System.Drawing.Point(0, 80);
            this.lblPaletteCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteCompression.Name = "lblPaletteCompression";
            this.lblPaletteCompression.Size = new System.Drawing.Size(77, 13);
            this.lblPaletteCompression.TabIndex = 6;
            this.lblPaletteCompression.Text = "Compression:";
            this.lblPaletteCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPalettePartial
            // 
            this.cbPalettePartial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalettePartial.FormattingEnabled = true;
            this.cbPalettePartial.ItemHeight = 13;
            this.cbPalettePartial.Location = new System.Drawing.Point(0, 176);
            this.cbPalettePartial.Name = "cbPalettePartial";
            this.cbPalettePartial.Size = new System.Drawing.Size(168, 21);
            this.cbPalettePartial.TabIndex = 13;
            this.cbPalettePartial.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // nudPaletteOffset
            // 
            this.nudPaletteOffset.Location = new System.Drawing.Point(88, 136);
            this.nudPaletteOffset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPaletteOffset.Name = "nudPaletteOffset";
            this.nudPaletteOffset.Size = new System.Drawing.Size(80, 22);
            this.nudPaletteOffset.TabIndex = 11;
            // 
            // AssetPaletteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlPalettesMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AssetPaletteControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlPalettesMain.ResumeLayout(false);
            this.grpPaletteList.ResumeLayout(false);
            this.pnlPaletteButtons.ResumeLayout(false);
            this.pnlPaletteOptions.ResumeLayout(false);
            this.pnlPaletteOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlPalettesMain;
        private PaletteControl pnlPaletteColors;
        private System.Windows.Forms.GroupBox grpPaletteList;
        private ListBoxControl lstPalettes;
        private System.Windows.Forms.Panel pnlPaletteButtons;
        private System.Windows.Forms.Button btnPaletteRemove;
        private System.Windows.Forms.Button btnPaletteSave;
        private System.Windows.Forms.Button btnPaletteValidate;
        private System.Windows.Forms.Panel pnlPaletteOptions;
        private System.Windows.Forms.NumericUpDown nudPaletteID;
        private System.Windows.Forms.Label lblPaletteOffset;
        private System.Windows.Forms.Label lblPaletteID;
        private System.Windows.Forms.Label lblPalettePartial;
        private PaletteControl pnlPalettePartial;
        private System.Windows.Forms.ComboBox cbPaletteCompression;
        private System.Windows.Forms.Label lblPaletteLength;
        private System.Windows.Forms.TextBox txtPaletteName;
        private System.Windows.Forms.Label lblPaletteName;
        private System.Windows.Forms.NumericUpDown nudPaletteLength;
        private System.Windows.Forms.Label lblPaletteCompression;
        private System.Windows.Forms.ComboBox cbPalettePartial;
        private System.Windows.Forms.NumericUpDown nudPaletteOffset;
        private System.Windows.Forms.Label lblPaletteHex;
        private System.Windows.Forms.NumericUpDown nudPaletteHex;
    }
}
