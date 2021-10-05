namespace SMSEditor.Forms
{
    partial class PaletteForm
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
            this.components = new System.ComponentModel.Container();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.grpEditPalette = new System.Windows.Forms.GroupBox();
            this.grpPalettes = new System.Windows.Forms.GroupBox();
            this.pnlPaletteListBorder = new System.Windows.Forms.Panel();
            this.lstPalettes = new System.Windows.Forms.ListBox();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkDisable = new System.Windows.Forms.CheckBox();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.pnlPaletteEdit = new SMSEditor.Controls.PaletteControl();
            this.pnlColorPicker = new SMSEditor.Controls.ImageControl();
            this.grpEdit.SuspendLayout();
            this.grpEditPalette.SuspendLayout();
            this.grpPalettes.SuspendLayout();
            this.pnlPaletteListBorder.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.pnlColorPicker);
            this.grpEdit.Location = new System.Drawing.Point(208, 8);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(168, 184);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Color Palette";
            // 
            // grpEditPalette
            // 
            this.grpEditPalette.Controls.Add(this.pnlPaletteEdit);
            this.grpEditPalette.Location = new System.Drawing.Point(8, 200);
            this.grpEditPalette.Name = "grpEditPalette";
            this.grpEditPalette.Padding = new System.Windows.Forms.Padding(8);
            this.grpEditPalette.Size = new System.Drawing.Size(368, 112);
            this.grpEditPalette.TabIndex = 4;
            this.grpEditPalette.TabStop = false;
            this.grpEditPalette.Text = "Edit Palette";
            // 
            // grpPalettes
            // 
            this.grpPalettes.Controls.Add(this.pnlPaletteListBorder);
            this.grpPalettes.Location = new System.Drawing.Point(8, 8);
            this.grpPalettes.Name = "grpPalettes";
            this.grpPalettes.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpPalettes.Size = new System.Drawing.Size(192, 184);
            this.grpPalettes.TabIndex = 0;
            this.grpPalettes.TabStop = false;
            this.grpPalettes.Text = "Palettes";
            // 
            // pnlPaletteListBorder
            // 
            this.pnlPaletteListBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPaletteListBorder.Controls.Add(this.lstPalettes);
            this.pnlPaletteListBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteListBorder.Location = new System.Drawing.Point(12, 19);
            this.pnlPaletteListBorder.Name = "pnlPaletteListBorder";
            this.pnlPaletteListBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPaletteListBorder.Size = new System.Drawing.Size(168, 153);
            this.pnlPaletteListBorder.TabIndex = 2;
            // 
            // lstPalettes
            // 
            this.lstPalettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalettes.FormattingEnabled = true;
            this.lstPalettes.IntegralHeight = false;
            this.lstPalettes.Location = new System.Drawing.Point(1, 1);
            this.lstPalettes.Name = "lstPalettes";
            this.lstPalettes.Size = new System.Drawing.Size(166, 151);
            this.lstPalettes.TabIndex = 0;
            this.lstPalettes.SelectedIndexChanged += new System.EventHandler(this.lstPalettes_SelectedIndexChanged);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssInformation});
            this.ssMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ssMain.Location = new System.Drawing.Point(0, 359);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(384, 5);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssInformation
            // 
            this.tssInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssInformation.Name = "tssInformation";
            this.tssInformation.Size = new System.Drawing.Size(0, 0);
            // 
            // chkDisable
            // 
            this.chkDisable.AutoSize = true;
            this.chkDisable.Location = new System.Drawing.Point(208, 320);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Size = new System.Drawing.Size(125, 17);
            this.chkDisable.TabIndex = 6;
            this.chkDisable.Text = "Disable Palette Edit";
            this.chkDisable.UseVisualStyleBackColor = true;
            this.chkDisable.CheckedChanged += new System.EventHandler(this.chkDisable_CheckedChanged);
            // 
            // chkOverride
            // 
            this.chkOverride.AutoSize = true;
            this.chkOverride.Location = new System.Drawing.Point(16, 320);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(154, 17);
            this.chkOverride.TabIndex = 7;
            this.chkOverride.Text = "Override Original Length";
            this.chkOverride.UseVisualStyleBackColor = true;
            this.chkOverride.CheckedChanged += new System.EventHandler(this.chkOverride_CheckedChanged);
            // 
            // pnlPaletteEdit
            // 
            this.pnlPaletteEdit.Location = new System.Drawing.Point(8, 20);
            this.pnlPaletteEdit.Name = "pnlPaletteEdit";
            this.pnlPaletteEdit.ReadOnly = false;
            this.pnlPaletteEdit.Size = new System.Drawing.Size(352, 82);
            this.pnlPaletteEdit.TabIndex = 0;
            this.pnlPaletteEdit.PaletteChanged += new SMSEditor.Controls.PaletteControl.PaletteChangedHandler(this.pnlPaletteEdit_PaletteChanged);
            // 
            // pnlColorPicker
            // 
            this.pnlColorPicker.AutoScroll = true;
            this.pnlColorPicker.AutoScrollMinSize = new System.Drawing.Size(162, 139);
            this.pnlColorPicker.Canvas = new System.Drawing.Size(162, 139);
            this.pnlColorPicker.Centered = false;
            this.pnlColorPicker.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColorPicker.HatchForeColor = System.Drawing.Color.White;
            this.pnlColorPicker.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColorPicker.Image = global::SMSEditor.Properties.Resources.color_wheel;
            this.pnlColorPicker.ImageAlpha = 1F;
            this.pnlColorPicker.ImageScale = 1;
            this.pnlColorPicker.Location = new System.Drawing.Point(2, 24);
            this.pnlColorPicker.MinimumScale = 1;
            this.pnlColorPicker.Name = "pnlColorPicker";
            this.pnlColorPicker.Size = new System.Drawing.Size(164, 144);
            this.pnlColorPicker.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColorPicker.TabIndex = 3;
            this.pnlColorPicker.UseCanvas = false;
            this.pnlColorPicker.UseHatch = false;
            this.pnlColorPicker.UseMouseWheelScaling = false;
            this.pnlColorPicker.Click += new System.EventHandler(this.pnlColorPicker_Click);
            this.pnlColorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlColorPicker_MouseMove);
            // 
            // PaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 364);
            this.Controls.Add(this.chkOverride);
            this.Controls.Add(this.chkDisable);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.grpPalettes);
            this.Controls.Add(this.grpEditPalette);
            this.Controls.Add(this.grpEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palette Edit";
            this.grpEdit.ResumeLayout(false);
            this.grpEditPalette.ResumeLayout(false);
            this.grpPalettes.ResumeLayout(false);
            this.pnlPaletteListBorder.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.GroupBox grpEditPalette;
        private Controls.PaletteControl pnlPaletteEdit;
        private Controls.ImageControl pnlColorPicker;
        private System.Windows.Forms.GroupBox grpPalettes;
        private System.Windows.Forms.Panel pnlPaletteListBorder;
        private System.Windows.Forms.ListBox lstPalettes;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssInformation;
        private System.Windows.Forms.CheckBox chkDisable;
        private System.Windows.Forms.CheckBox chkOverride;
    }
}