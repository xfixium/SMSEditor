namespace SMSEditor.Controls
{
    partial class RomHexControl
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
            this.tpnlRomHexMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRomDataHex = new Be.Windows.Forms.HexBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudRomImageHex = new System.Windows.Forms.NumericUpDown();
            this.lblRomImageHex = new System.Windows.Forms.Label();
            this.nudRomImagePosition = new System.Windows.Forms.NumericUpDown();
            this.lblRomImagePosition = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tpnlRomHexMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImageHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImagePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlRomHexMain
            // 
            this.tpnlRomHexMain.ColumnCount = 2;
            this.tpnlRomHexMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlRomHexMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlRomHexMain.Controls.Add(this.pnlRomDataHex, 0, 0);
            this.tpnlRomHexMain.Controls.Add(this.panel1, 1, 0);
            this.tpnlRomHexMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlRomHexMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlRomHexMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlRomHexMain.Name = "tpnlRomHexMain";
            this.tpnlRomHexMain.RowCount = 1;
            this.tpnlRomHexMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlRomHexMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlRomHexMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlRomHexMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlRomHexMain.TabIndex = 2;
            // 
            // pnlRomDataHex
            // 
            this.pnlRomDataHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRomDataHex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlRomDataHex.GroupSeparatorVisible = true;
            this.pnlRomDataHex.GroupSize = 8;
            this.pnlRomDataHex.LineInfoVisible = true;
            this.pnlRomDataHex.Location = new System.Drawing.Point(3, 3);
            this.pnlRomDataHex.Name = "pnlRomDataHex";
            this.pnlRomDataHex.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.pnlRomDataHex.Size = new System.Drawing.Size(632, 538);
            this.pnlRomDataHex.TabIndex = 1;
            this.pnlRomDataHex.UseFixedBytesPerLine = true;
            this.pnlRomDataHex.VScrollBarVisible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nudRomImageHex);
            this.panel1.Controls.Add(this.lblRomImageHex);
            this.panel1.Controls.Add(this.nudRomImagePosition);
            this.panel1.Controls.Add(this.lblRomImagePosition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(638, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 538);
            this.panel1.TabIndex = 2;
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
            this.nudRomImageHex.TabIndex = 7;
            // 
            // lblRomImageHex
            // 
            this.lblRomImageHex.AutoSize = true;
            this.lblRomImageHex.Location = new System.Drawing.Point(88, 0);
            this.lblRomImageHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImageHex.Name = "lblRomImageHex";
            this.lblRomImageHex.Size = new System.Drawing.Size(75, 13);
            this.lblRomImageHex.TabIndex = 6;
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
            this.nudRomImagePosition.TabIndex = 5;
            // 
            // lblRomImagePosition
            // 
            this.lblRomImagePosition.AutoSize = true;
            this.lblRomImagePosition.Location = new System.Drawing.Point(0, 0);
            this.lblRomImagePosition.Margin = new System.Windows.Forms.Padding(0);
            this.lblRomImagePosition.Name = "lblRomImagePosition";
            this.lblRomImagePosition.Size = new System.Drawing.Size(67, 13);
            this.lblRomImagePosition.TabIndex = 4;
            this.lblRomImagePosition.Text = "Position (ID):";
            this.lblRomImagePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go To Position";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 72);
            this.textBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RomHexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlRomHexMain);
            this.Name = "RomHexControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlRomHexMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImageHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRomImagePosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlRomHexMain;
        private Be.Windows.Forms.HexBox pnlRomDataHex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudRomImageHex;
        private System.Windows.Forms.Label lblRomImageHex;
        private System.Windows.Forms.NumericUpDown nudRomImagePosition;
        private System.Windows.Forms.Label lblRomImagePosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
