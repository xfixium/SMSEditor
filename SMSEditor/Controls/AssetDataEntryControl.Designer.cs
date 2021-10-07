namespace SMSEditor.Controls
{
    partial class AssetDataEntryControl
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtDataEntry = new System.Windows.Forms.TextBox();
            this.radDataEntryInsert = new System.Windows.Forms.RadioButton();
            this.radDataEntryOverwrite = new System.Windows.Forms.RadioButton();
            this.tpnlDataInjectionMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpDataEntryList = new System.Windows.Forms.GroupBox();
            this.lstDataEntries = new SMSEditor.Controls.ListBoxControl();
            this.pnlDataEntryButtons = new System.Windows.Forms.Panel();
            this.btnDataEntryRemove = new System.Windows.Forms.Button();
            this.btnDataEntrySave = new System.Windows.Forms.Button();
            this.pnlDataEntryOptions = new System.Windows.Forms.Panel();
            this.lblDataEntryComments = new System.Windows.Forms.Label();
            this.txtDataEntryComments = new System.Windows.Forms.TextBox();
            this.nudDataEntryHex = new System.Windows.Forms.NumericUpDown();
            this.lblDataEntryHex = new System.Windows.Forms.Label();
            this.nudDataEntryID = new System.Windows.Forms.NumericUpDown();
            this.chkDataEntryDisable = new System.Windows.Forms.CheckBox();
            this.chkDataEntryUseHex = new System.Windows.Forms.CheckBox();
            this.lblDataEntryID = new System.Windows.Forms.Label();
            this.txtDataEntryName = new System.Windows.Forms.TextBox();
            this.lblDataEntryName = new System.Windows.Forms.Label();
            this.grpData.SuspendLayout();
            this.tpnlDataInjectionMain.SuspendLayout();
            this.grpDataEntryList.SuspendLayout();
            this.pnlDataEntryButtons.SuspendLayout();
            this.pnlDataEntryOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEntryHex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEntryID)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtDataEntry);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(202, 0);
            this.grpData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 2);
            this.grpData.Name = "grpData";
            this.grpData.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.grpData.Size = new System.Drawing.Size(430, 542);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Space Separated Byte Values";
            // 
            // txtDataEntry
            // 
            this.txtDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataEntry.Location = new System.Drawing.Point(12, 23);
            this.txtDataEntry.Multiline = true;
            this.txtDataEntry.Name = "txtDataEntry";
            this.txtDataEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataEntry.Size = new System.Drawing.Size(406, 507);
            this.txtDataEntry.TabIndex = 0;
            // 
            // radDataEntryInsert
            // 
            this.radDataEntryInsert.AutoSize = true;
            this.radDataEntryInsert.Location = new System.Drawing.Point(80, 96);
            this.radDataEntryInsert.Name = "radDataEntryInsert";
            this.radDataEntryInsert.Size = new System.Drawing.Size(54, 17);
            this.radDataEntryInsert.TabIndex = 9;
            this.radDataEntryInsert.Text = "Insert";
            this.radDataEntryInsert.UseVisualStyleBackColor = true;
            // 
            // radDataEntryOverwrite
            // 
            this.radDataEntryOverwrite.AutoSize = true;
            this.radDataEntryOverwrite.Checked = true;
            this.radDataEntryOverwrite.Location = new System.Drawing.Point(0, 96);
            this.radDataEntryOverwrite.Name = "radDataEntryOverwrite";
            this.radDataEntryOverwrite.Size = new System.Drawing.Size(75, 17);
            this.radDataEntryOverwrite.TabIndex = 8;
            this.radDataEntryOverwrite.TabStop = true;
            this.radDataEntryOverwrite.Text = "Overwrite";
            this.radDataEntryOverwrite.UseVisualStyleBackColor = true;
            // 
            // tpnlDataInjectionMain
            // 
            this.tpnlDataInjectionMain.ColumnCount = 3;
            this.tpnlDataInjectionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlDataInjectionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataInjectionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlDataInjectionMain.Controls.Add(this.grpData, 1, 0);
            this.tpnlDataInjectionMain.Controls.Add(this.grpDataEntryList, 0, 0);
            this.tpnlDataInjectionMain.Controls.Add(this.pnlDataEntryOptions, 2, 0);
            this.tpnlDataInjectionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDataInjectionMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlDataInjectionMain.Name = "tpnlDataInjectionMain";
            this.tpnlDataInjectionMain.RowCount = 1;
            this.tpnlDataInjectionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataInjectionMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlDataInjectionMain.TabIndex = 11;
            // 
            // grpDataEntryList
            // 
            this.grpDataEntryList.Controls.Add(this.lstDataEntries);
            this.grpDataEntryList.Controls.Add(this.pnlDataEntryButtons);
            this.grpDataEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataEntryList.Location = new System.Drawing.Point(0, 0);
            this.grpDataEntryList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDataEntryList.Name = "grpDataEntryList";
            this.grpDataEntryList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDataEntryList.Size = new System.Drawing.Size(196, 544);
            this.grpDataEntryList.TabIndex = 0;
            this.grpDataEntryList.TabStop = false;
            this.grpDataEntryList.Text = "Data Entries";
            // 
            // lstDataEntries
            // 
            this.lstDataEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDataEntries.DisableHighlighting = false;
            this.lstDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDataEntries.FormattingEnabled = true;
            this.lstDataEntries.HorizontalExtent = 170;
            this.lstDataEntries.IntegralHeight = false;
            this.lstDataEntries.ItemHeight = 15;
            this.lstDataEntries.Location = new System.Drawing.Point(12, 66);
            this.lstDataEntries.Name = "lstDataEntries";
            this.lstDataEntries.Size = new System.Drawing.Size(172, 466);
            this.lstDataEntries.TabIndex = 1;
            this.lstDataEntries.TextOffsetX = 2;
            this.lstDataEntries.TextOffsetY = -1;
            this.lstDataEntries.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // pnlDataEntryButtons
            // 
            this.pnlDataEntryButtons.Controls.Add(this.btnDataEntryRemove);
            this.pnlDataEntryButtons.Controls.Add(this.btnDataEntrySave);
            this.pnlDataEntryButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataEntryButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlDataEntryButtons.Name = "pnlDataEntryButtons";
            this.pnlDataEntryButtons.Size = new System.Drawing.Size(172, 47);
            this.pnlDataEntryButtons.TabIndex = 0;
            // 
            // btnDataEntryRemove
            // 
            this.btnDataEntryRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataEntryRemove.Location = new System.Drawing.Point(0, 23);
            this.btnDataEntryRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataEntryRemove.Name = "btnDataEntryRemove";
            this.btnDataEntryRemove.Size = new System.Drawing.Size(172, 23);
            this.btnDataEntryRemove.TabIndex = 1;
            this.btnDataEntryRemove.Text = "Remove Data Entry";
            this.btnDataEntryRemove.UseVisualStyleBackColor = true;
            this.btnDataEntryRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnDataEntrySave
            // 
            this.btnDataEntrySave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataEntrySave.Location = new System.Drawing.Point(0, 0);
            this.btnDataEntrySave.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataEntrySave.Name = "btnDataEntrySave";
            this.btnDataEntrySave.Size = new System.Drawing.Size(172, 23);
            this.btnDataEntrySave.TabIndex = 0;
            this.btnDataEntrySave.Text = "Save Data Entry";
            this.btnDataEntrySave.UseVisualStyleBackColor = true;
            this.btnDataEntrySave.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // pnlDataEntryOptions
            // 
            this.pnlDataEntryOptions.Controls.Add(this.lblDataEntryComments);
            this.pnlDataEntryOptions.Controls.Add(this.txtDataEntryComments);
            this.pnlDataEntryOptions.Controls.Add(this.nudDataEntryHex);
            this.pnlDataEntryOptions.Controls.Add(this.lblDataEntryHex);
            this.pnlDataEntryOptions.Controls.Add(this.nudDataEntryID);
            this.pnlDataEntryOptions.Controls.Add(this.radDataEntryInsert);
            this.pnlDataEntryOptions.Controls.Add(this.radDataEntryOverwrite);
            this.pnlDataEntryOptions.Controls.Add(this.chkDataEntryDisable);
            this.pnlDataEntryOptions.Controls.Add(this.chkDataEntryUseHex);
            this.pnlDataEntryOptions.Controls.Add(this.lblDataEntryID);
            this.pnlDataEntryOptions.Controls.Add(this.txtDataEntryName);
            this.pnlDataEntryOptions.Controls.Add(this.lblDataEntryName);
            this.pnlDataEntryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntryOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlDataEntryOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlDataEntryOptions.Name = "pnlDataEntryOptions";
            this.pnlDataEntryOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlDataEntryOptions.TabIndex = 2;
            // 
            // lblDataEntryComments
            // 
            this.lblDataEntryComments.AutoSize = true;
            this.lblDataEntryComments.Location = new System.Drawing.Point(0, 120);
            this.lblDataEntryComments.Name = "lblDataEntryComments";
            this.lblDataEntryComments.Size = new System.Drawing.Size(64, 13);
            this.lblDataEntryComments.TabIndex = 10;
            this.lblDataEntryComments.Text = "Comments:";
            // 
            // txtDataEntryComments
            // 
            this.txtDataEntryComments.Location = new System.Drawing.Point(0, 136);
            this.txtDataEntryComments.Multiline = true;
            this.txtDataEntryComments.Name = "txtDataEntryComments";
            this.txtDataEntryComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataEntryComments.Size = new System.Drawing.Size(168, 184);
            this.txtDataEntryComments.TabIndex = 11;
            // 
            // nudDataEntryHex
            // 
            this.nudDataEntryHex.Hexadecimal = true;
            this.nudDataEntryHex.Location = new System.Drawing.Point(88, 16);
            this.nudDataEntryHex.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudDataEntryHex.Name = "nudDataEntryHex";
            this.nudDataEntryHex.Size = new System.Drawing.Size(80, 22);
            this.nudDataEntryHex.TabIndex = 3;
            this.nudDataEntryHex.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // lblDataEntryHex
            // 
            this.lblDataEntryHex.AutoSize = true;
            this.lblDataEntryHex.Location = new System.Drawing.Point(88, 0);
            this.lblDataEntryHex.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataEntryHex.Name = "lblDataEntryHex";
            this.lblDataEntryHex.Size = new System.Drawing.Size(80, 13);
            this.lblDataEntryHex.TabIndex = 2;
            this.lblDataEntryHex.Text = "Position (Hex):";
            this.lblDataEntryHex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudDataEntryID
            // 
            this.nudDataEntryID.Location = new System.Drawing.Point(0, 16);
            this.nudDataEntryID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudDataEntryID.Name = "nudDataEntryID";
            this.nudDataEntryID.Size = new System.Drawing.Size(80, 22);
            this.nudDataEntryID.TabIndex = 1;
            this.nudDataEntryID.ValueChanged += new System.EventHandler(this.nudAssetID_ValueChanged);
            // 
            // chkDataEntryDisable
            // 
            this.chkDataEntryDisable.AutoSize = true;
            this.chkDataEntryDisable.Location = new System.Drawing.Point(112, 80);
            this.chkDataEntryDisable.Name = "chkDataEntryDisable";
            this.chkDataEntryDisable.Size = new System.Drawing.Size(64, 17);
            this.chkDataEntryDisable.TabIndex = 7;
            this.chkDataEntryDisable.Text = "Disable";
            this.chkDataEntryDisable.UseVisualStyleBackColor = true;
            // 
            // chkDataEntryUseHex
            // 
            this.chkDataEntryUseHex.AutoSize = true;
            this.chkDataEntryUseHex.Checked = true;
            this.chkDataEntryUseHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataEntryUseHex.Location = new System.Drawing.Point(0, 80);
            this.chkDataEntryUseHex.Name = "chkDataEntryUseHex";
            this.chkDataEntryUseHex.Size = new System.Drawing.Size(103, 17);
            this.chkDataEntryUseHex.TabIndex = 6;
            this.chkDataEntryUseHex.Text = "Use Hex Values";
            this.chkDataEntryUseHex.UseVisualStyleBackColor = true;
            this.chkDataEntryUseHex.CheckedChanged += new System.EventHandler(this.chkDataEntryUseHex_CheckedChanged);
            // 
            // lblDataEntryID
            // 
            this.lblDataEntryID.AutoSize = true;
            this.lblDataEntryID.Location = new System.Drawing.Point(0, 0);
            this.lblDataEntryID.Name = "lblDataEntryID";
            this.lblDataEntryID.Size = new System.Drawing.Size(72, 13);
            this.lblDataEntryID.TabIndex = 0;
            this.lblDataEntryID.Text = "Position (ID):";
            // 
            // txtDataEntryName
            // 
            this.txtDataEntryName.Location = new System.Drawing.Point(0, 56);
            this.txtDataEntryName.MaxLength = 50;
            this.txtDataEntryName.Name = "txtDataEntryName";
            this.txtDataEntryName.Size = new System.Drawing.Size(168, 22);
            this.txtDataEntryName.TabIndex = 5;
            // 
            // lblDataEntryName
            // 
            this.lblDataEntryName.AutoSize = true;
            this.lblDataEntryName.Location = new System.Drawing.Point(1, 41);
            this.lblDataEntryName.Name = "lblDataEntryName";
            this.lblDataEntryName.Size = new System.Drawing.Size(39, 13);
            this.lblDataEntryName.TabIndex = 4;
            this.lblDataEntryName.Text = "Name:";
            // 
            // AssetDataEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlDataInjectionMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetDataEntryControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.tpnlDataInjectionMain.ResumeLayout(false);
            this.grpDataEntryList.ResumeLayout(false);
            this.pnlDataEntryButtons.ResumeLayout(false);
            this.pnlDataEntryOptions.ResumeLayout(false);
            this.pnlDataEntryOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEntryHex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEntryID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.TextBox txtDataEntry;
        private System.Windows.Forms.RadioButton radDataEntryInsert;
        private System.Windows.Forms.RadioButton radDataEntryOverwrite;
        private System.Windows.Forms.TableLayoutPanel tpnlDataInjectionMain;
        private System.Windows.Forms.GroupBox grpDataEntryList;
        private ListBoxControl lstDataEntries;
        private System.Windows.Forms.Panel pnlDataEntryButtons;
        private System.Windows.Forms.Button btnDataEntryRemove;
        private System.Windows.Forms.Button btnDataEntrySave;
        private System.Windows.Forms.Panel pnlDataEntryOptions;
        private System.Windows.Forms.CheckBox chkDataEntryDisable;
        private System.Windows.Forms.CheckBox chkDataEntryUseHex;
        private System.Windows.Forms.Label lblDataEntryID;
        private System.Windows.Forms.TextBox txtDataEntryName;
        private System.Windows.Forms.Label lblDataEntryName;
        private System.Windows.Forms.NumericUpDown nudDataEntryID;
        private System.Windows.Forms.NumericUpDown nudDataEntryHex;
        private System.Windows.Forms.Label lblDataEntryHex;
        private System.Windows.Forms.Label lblDataEntryComments;
        private System.Windows.Forms.TextBox txtDataEntryComments;
    }
}
