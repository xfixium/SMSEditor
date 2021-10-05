namespace SMSEditor.Forms
{
    partial class PropertiesForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.nudPosition = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsY1 = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsX1 = new System.Windows.Forms.NumericUpDown();
            this.lblBoundsY1 = new System.Windows.Forms.Label();
            this.lblBoundsX1 = new System.Windows.Forms.Label();
            this.lblPositionID = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblBoundsX0 = new System.Windows.Forms.Label();
            this.lblBoundsY0 = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsX0 = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsY0 = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.nudColumnsPosition = new System.Windows.Forms.NumericUpDown();
            this.nudRowsPosition = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsX0Position = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsY0Position = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsX1Position = new System.Windows.Forms.NumericUpDown();
            this.nudBoundsY1Position = new System.Windows.Forms.NumericUpDown();
            this.lblOverride = new System.Windows.Forms.Label();
            this.tpnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX0Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY0Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX1Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY1Position)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(177, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Location = new System.Drawing.Point(83, 211);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(88, 24);
            this.btnApply.TabIndex = 23;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 3;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.Controls.Add(this.nudPosition, 1, 0);
            this.tpnlMain.Controls.Add(this.nudBoundsY1, 1, 7);
            this.tpnlMain.Controls.Add(this.nudBoundsX1, 1, 6);
            this.tpnlMain.Controls.Add(this.lblBoundsY1, 0, 7);
            this.tpnlMain.Controls.Add(this.lblBoundsX1, 0, 6);
            this.tpnlMain.Controls.Add(this.lblPositionID, 0, 0);
            this.tpnlMain.Controls.Add(this.lblColumns, 0, 2);
            this.tpnlMain.Controls.Add(this.nudColumns, 1, 2);
            this.tpnlMain.Controls.Add(this.lblRows, 0, 3);
            this.tpnlMain.Controls.Add(this.lblBoundsX0, 0, 4);
            this.tpnlMain.Controls.Add(this.lblBoundsY0, 0, 5);
            this.tpnlMain.Controls.Add(this.nudRows, 1, 3);
            this.tpnlMain.Controls.Add(this.nudBoundsX0, 1, 4);
            this.tpnlMain.Controls.Add(this.nudBoundsY0, 1, 5);
            this.tpnlMain.Controls.Add(this.btnCancel, 2, 8);
            this.tpnlMain.Controls.Add(this.btnApply, 1, 8);
            this.tpnlMain.Controls.Add(this.lblValue, 1, 1);
            this.tpnlMain.Controls.Add(this.lblPosition, 2, 1);
            this.tpnlMain.Controls.Add(this.nudColumnsPosition, 2, 2);
            this.tpnlMain.Controls.Add(this.nudRowsPosition, 2, 3);
            this.tpnlMain.Controls.Add(this.nudBoundsX0Position, 2, 4);
            this.tpnlMain.Controls.Add(this.nudBoundsY0Position, 2, 5);
            this.tpnlMain.Controls.Add(this.nudBoundsX1Position, 2, 6);
            this.tpnlMain.Controls.Add(this.nudBoundsY1Position, 2, 7);
            this.tpnlMain.Controls.Add(this.lblOverride, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 9;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Size = new System.Drawing.Size(268, 238);
            this.tpnlMain.TabIndex = 1;
            // 
            // nudPosition
            // 
            this.tpnlMain.SetColumnSpan(this.nudPosition, 2);
            this.nudPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPosition.Location = new System.Drawing.Point(83, 3);
            this.nudPosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudPosition.Name = "nudPosition";
            this.nudPosition.Size = new System.Drawing.Size(182, 22);
            this.nudPosition.TabIndex = 1;
            this.nudPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudBoundsY1
            // 
            this.nudBoundsY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBoundsY1.Location = new System.Drawing.Point(83, 185);
            this.nudBoundsY1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBoundsY1.Name = "nudBoundsY1";
            this.nudBoundsY1.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsY1.TabIndex = 21;
            // 
            // nudBoundsX1
            // 
            this.nudBoundsX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBoundsX1.Location = new System.Drawing.Point(83, 159);
            this.nudBoundsX1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBoundsX1.Name = "nudBoundsX1";
            this.nudBoundsX1.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsX1.TabIndex = 18;
            // 
            // lblBoundsY1
            // 
            this.lblBoundsY1.AutoSize = true;
            this.lblBoundsY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoundsY1.Location = new System.Drawing.Point(3, 182);
            this.lblBoundsY1.Name = "lblBoundsY1";
            this.lblBoundsY1.Size = new System.Drawing.Size(74, 26);
            this.lblBoundsY1.TabIndex = 20;
            this.lblBoundsY1.Text = "Bounds Y1:";
            this.lblBoundsY1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBoundsX1
            // 
            this.lblBoundsX1.AutoSize = true;
            this.lblBoundsX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoundsX1.Location = new System.Drawing.Point(3, 156);
            this.lblBoundsX1.Name = "lblBoundsX1";
            this.lblBoundsX1.Size = new System.Drawing.Size(74, 26);
            this.lblBoundsX1.TabIndex = 17;
            this.lblBoundsX1.Text = "Bounds X1:";
            this.lblBoundsX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPositionID
            // 
            this.lblPositionID.AutoSize = true;
            this.lblPositionID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPositionID.Location = new System.Drawing.Point(3, 0);
            this.lblPositionID.Name = "lblPositionID";
            this.lblPositionID.Size = new System.Drawing.Size(74, 26);
            this.lblPositionID.TabIndex = 0;
            this.lblPositionID.Text = "Position:";
            this.lblPositionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColumns.Location = new System.Drawing.Point(3, 52);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(74, 26);
            this.lblColumns.TabIndex = 5;
            this.lblColumns.Text = "Columns:";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudColumns
            // 
            this.nudColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudColumns.Location = new System.Drawing.Point(83, 55);
            this.nudColumns.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(88, 22);
            this.nudColumns.TabIndex = 6;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRows.Location = new System.Drawing.Point(3, 78);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(74, 26);
            this.lblRows.TabIndex = 8;
            this.lblRows.Text = "Rows:";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBoundsX0
            // 
            this.lblBoundsX0.AutoSize = true;
            this.lblBoundsX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoundsX0.Location = new System.Drawing.Point(3, 104);
            this.lblBoundsX0.Name = "lblBoundsX0";
            this.lblBoundsX0.Size = new System.Drawing.Size(74, 26);
            this.lblBoundsX0.TabIndex = 11;
            this.lblBoundsX0.Text = "Bounds X0:";
            this.lblBoundsX0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBoundsY0
            // 
            this.lblBoundsY0.AutoSize = true;
            this.lblBoundsY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoundsY0.Location = new System.Drawing.Point(3, 130);
            this.lblBoundsY0.Name = "lblBoundsY0";
            this.lblBoundsY0.Size = new System.Drawing.Size(74, 26);
            this.lblBoundsY0.TabIndex = 14;
            this.lblBoundsY0.Text = "Bounds Y0:";
            this.lblBoundsY0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRows
            // 
            this.nudRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRows.Location = new System.Drawing.Point(83, 81);
            this.nudRows.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(88, 22);
            this.nudRows.TabIndex = 9;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBoundsX0
            // 
            this.nudBoundsX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBoundsX0.Location = new System.Drawing.Point(83, 107);
            this.nudBoundsX0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBoundsX0.Name = "nudBoundsX0";
            this.nudBoundsX0.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsX0.TabIndex = 12;
            // 
            // nudBoundsY0
            // 
            this.nudBoundsY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBoundsY0.Location = new System.Drawing.Point(83, 133);
            this.nudBoundsY0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBoundsY0.Name = "nudBoundsY0";
            this.nudBoundsY0.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsY0.TabIndex = 15;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValue.Location = new System.Drawing.Point(83, 29);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(88, 20);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(177, 29);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(3);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(88, 20);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudColumnsPosition
            // 
            this.nudColumnsPosition.Location = new System.Drawing.Point(177, 55);
            this.nudColumnsPosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudColumnsPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudColumnsPosition.Name = "nudColumnsPosition";
            this.nudColumnsPosition.Size = new System.Drawing.Size(88, 22);
            this.nudColumnsPosition.TabIndex = 7;
            this.nudColumnsPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudRowsPosition
            // 
            this.nudRowsPosition.Location = new System.Drawing.Point(177, 81);
            this.nudRowsPosition.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudRowsPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudRowsPosition.Name = "nudRowsPosition";
            this.nudRowsPosition.Size = new System.Drawing.Size(88, 22);
            this.nudRowsPosition.TabIndex = 10;
            this.nudRowsPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudBoundsX0Position
            // 
            this.nudBoundsX0Position.Location = new System.Drawing.Point(177, 107);
            this.nudBoundsX0Position.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudBoundsX0Position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudBoundsX0Position.Name = "nudBoundsX0Position";
            this.nudBoundsX0Position.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsX0Position.TabIndex = 13;
            this.nudBoundsX0Position.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudBoundsY0Position
            // 
            this.nudBoundsY0Position.Location = new System.Drawing.Point(177, 133);
            this.nudBoundsY0Position.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudBoundsY0Position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudBoundsY0Position.Name = "nudBoundsY0Position";
            this.nudBoundsY0Position.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsY0Position.TabIndex = 16;
            this.nudBoundsY0Position.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudBoundsX1Position
            // 
            this.nudBoundsX1Position.Location = new System.Drawing.Point(177, 159);
            this.nudBoundsX1Position.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudBoundsX1Position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudBoundsX1Position.Name = "nudBoundsX1Position";
            this.nudBoundsX1Position.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsX1Position.TabIndex = 19;
            this.nudBoundsX1Position.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudBoundsY1Position
            // 
            this.nudBoundsY1Position.Location = new System.Drawing.Point(177, 185);
            this.nudBoundsY1Position.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudBoundsY1Position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudBoundsY1Position.Name = "nudBoundsY1Position";
            this.nudBoundsY1Position.Size = new System.Drawing.Size(88, 22);
            this.nudBoundsY1Position.TabIndex = 22;
            this.nudBoundsY1Position.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblOverride
            // 
            this.lblOverride.AutoSize = true;
            this.lblOverride.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOverride.Location = new System.Drawing.Point(3, 29);
            this.lblOverride.Margin = new System.Windows.Forms.Padding(3);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(74, 20);
            this.lblOverride.TabIndex = 2;
            this.lblOverride.Text = "Override";
            this.lblOverride.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX0Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY0Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsX1Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundsY1Position)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.NumericUpDown nudBoundsY1;
        private System.Windows.Forms.NumericUpDown nudBoundsX1;
        private System.Windows.Forms.Label lblBoundsY1;
        private System.Windows.Forms.Label lblBoundsX1;
        private System.Windows.Forms.Label lblPositionID;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblBoundsX0;
        private System.Windows.Forms.Label lblBoundsY0;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudBoundsX0;
        private System.Windows.Forms.NumericUpDown nudBoundsY0;
        private System.Windows.Forms.NumericUpDown nudPosition;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown nudColumnsPosition;
        private System.Windows.Forms.NumericUpDown nudRowsPosition;
        private System.Windows.Forms.NumericUpDown nudBoundsX0Position;
        private System.Windows.Forms.NumericUpDown nudBoundsY0Position;
        private System.Windows.Forms.NumericUpDown nudBoundsX1Position;
        private System.Windows.Forms.NumericUpDown nudBoundsY1Position;
        private System.Windows.Forms.Label lblOverride;
    }
}