namespace SMSEditor.Forms
{
    partial class RemoveForm
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
            this.grpDataEntryList = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstDataEntries = new SMSEditor.Controls.ListBoxControl();
            this.grpDataEntryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataEntryList
            // 
            this.grpDataEntryList.Controls.Add(this.lstDataEntries);
            this.grpDataEntryList.Location = new System.Drawing.Point(8, 8);
            this.grpDataEntryList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDataEntryList.Name = "grpDataEntryList";
            this.grpDataEntryList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDataEntryList.Size = new System.Drawing.Size(248, 344);
            this.grpDataEntryList.TabIndex = 1;
            this.grpDataEntryList.TabStop = false;
            this.grpDataEntryList.Text = "Affected Assets";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(184, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(104, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lstDataEntries
            // 
            this.lstDataEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDataEntries.DisableHighlighting = false;
            this.lstDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDataEntries.FormattingEnabled = true;
            this.lstDataEntries.HorizontalExtent = 222;
            this.lstDataEntries.IntegralHeight = false;
            this.lstDataEntries.ItemHeight = 15;
            this.lstDataEntries.Location = new System.Drawing.Point(12, 19);
            this.lstDataEntries.Name = "lstDataEntries";
            this.lstDataEntries.Size = new System.Drawing.Size(224, 313);
            this.lstDataEntries.TabIndex = 1;
            this.lstDataEntries.TextOffsetX = 2;
            this.lstDataEntries.TextOffsetY = -1;
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpDataEntryList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Confirmation";
            this.grpDataEntryList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataEntryList;
        private Controls.ListBoxControl lstDataEntries;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}