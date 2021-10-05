namespace SMSEditor.Forms
{
    partial class ReplaceForm
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
            this.grpEditedSprite = new System.Windows.Forms.GroupBox();
            this.grpOriginalSprite = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkTilesetUseGrid = new System.Windows.Forms.CheckBox();
            this.chkTilesetIndexed = new System.Windows.Forms.CheckBox();
            this.pnlTarget = new SMSEditor.Controls.TileSelectControl();
            this.pnlSource = new SMSEditor.Controls.TileSelectControl();
            this.grpEditedSprite.SuspendLayout();
            this.grpOriginalSprite.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditedSprite
            // 
            this.grpEditedSprite.Controls.Add(this.pnlTarget);
            this.grpEditedSprite.Location = new System.Drawing.Point(8, 8);
            this.grpEditedSprite.Name = "grpEditedSprite";
            this.grpEditedSprite.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.grpEditedSprite.Size = new System.Drawing.Size(360, 360);
            this.grpEditedSprite.TabIndex = 3;
            this.grpEditedSprite.TabStop = false;
            this.grpEditedSprite.Text = "Target Tile";
            // 
            // grpOriginalSprite
            // 
            this.grpOriginalSprite.Controls.Add(this.pnlSource);
            this.grpOriginalSprite.Location = new System.Drawing.Point(384, 8);
            this.grpOriginalSprite.Name = "grpOriginalSprite";
            this.grpOriginalSprite.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.grpOriginalSprite.Size = new System.Drawing.Size(360, 360);
            this.grpOriginalSprite.TabIndex = 2;
            this.grpOriginalSprite.TabStop = false;
            this.grpOriginalSprite.Text = "Replacement Tile";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(672, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(592, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkTilesetUseGrid
            // 
            this.chkTilesetUseGrid.AutoSize = true;
            this.chkTilesetUseGrid.Checked = true;
            this.chkTilesetUseGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetUseGrid.Location = new System.Drawing.Point(8, 376);
            this.chkTilesetUseGrid.Name = "chkTilesetUseGrid";
            this.chkTilesetUseGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetUseGrid.TabIndex = 7;
            this.chkTilesetUseGrid.Text = "Grid";
            this.chkTilesetUseGrid.UseVisualStyleBackColor = true;
            this.chkTilesetUseGrid.CheckedChanged += new System.EventHandler(this.chkTilesetUseGrid_CheckedChanged);
            // 
            // chkTilesetIndexed
            // 
            this.chkTilesetIndexed.AutoSize = true;
            this.chkTilesetIndexed.Location = new System.Drawing.Point(64, 376);
            this.chkTilesetIndexed.Name = "chkTilesetIndexed";
            this.chkTilesetIndexed.Size = new System.Drawing.Size(67, 17);
            this.chkTilesetIndexed.TabIndex = 8;
            this.chkTilesetIndexed.Text = "Indexed";
            this.chkTilesetIndexed.UseVisualStyleBackColor = true;
            this.chkTilesetIndexed.CheckedChanged += new System.EventHandler(this.chkTilesetIndexed_CheckedChanged);
            // 
            // pnlTarget
            // 
            this.pnlTarget.AutoScroll = true;
            this.pnlTarget.AutoScrollMinSize = new System.Drawing.Size(328, 321);
            this.pnlTarget.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTarget.Centered = true;
            this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTarget.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTarget.HatchForeColor = System.Drawing.Color.White;
            this.pnlTarget.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTarget.Image = null;
            this.pnlTarget.ImageAlpha = 1F;
            this.pnlTarget.ImageScale = 1;
            this.pnlTarget.Indexed = false;
            this.pnlTarget.Location = new System.Drawing.Point(16, 23);
            this.pnlTarget.MinimumScale = 1;
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Selection = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.pnlTarget.Size = new System.Drawing.Size(328, 321);
            this.pnlTarget.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTarget.TabIndex = 1;
            this.pnlTarget.TileCount = 0;
            this.pnlTarget.TileID = -1;
            this.pnlTarget.UseCanvas = false;
            this.pnlTarget.UseGrid = true;
            this.pnlTarget.UseHatch = true;
            this.pnlTarget.UseMouseWheelScaling = true;
            this.pnlTarget.TileSelectionChanged += new SMSEditor.Controls.TileSelectControl.TileSelectionHandler(this.pnlTarget_TileSelectionChanged);
            this.pnlTarget.ScaleChanged += new SMSEditor.Controls.ImageControl.ScaleChangedHandler(this.pnlTileSelect_ScaleChanged);
            this.pnlTarget.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlTarget_Scroll);
            // 
            // pnlSource
            // 
            this.pnlSource.AutoScroll = true;
            this.pnlSource.AutoScrollMinSize = new System.Drawing.Size(328, 321);
            this.pnlSource.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSource.Centered = true;
            this.pnlSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSource.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSource.HatchForeColor = System.Drawing.Color.White;
            this.pnlSource.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSource.Image = null;
            this.pnlSource.ImageAlpha = 1F;
            this.pnlSource.ImageScale = 1;
            this.pnlSource.Indexed = false;
            this.pnlSource.Location = new System.Drawing.Point(16, 23);
            this.pnlSource.MinimumScale = 1;
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Selection = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.pnlSource.Size = new System.Drawing.Size(328, 321);
            this.pnlSource.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSource.TabIndex = 0;
            this.pnlSource.TileCount = 0;
            this.pnlSource.TileID = -1;
            this.pnlSource.UseCanvas = false;
            this.pnlSource.UseGrid = true;
            this.pnlSource.UseHatch = true;
            this.pnlSource.UseMouseWheelScaling = true;
            this.pnlSource.ScaleChanged += new SMSEditor.Controls.ImageControl.ScaleChangedHandler(this.pnlTileSelect_ScaleChanged);
            this.pnlSource.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlSource_Scroll);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 407);
            this.Controls.Add(this.chkTilesetUseGrid);
            this.Controls.Add(this.chkTilesetIndexed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpEditedSprite);
            this.Controls.Add(this.grpOriginalSprite);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Tiles";
            this.grpEditedSprite.ResumeLayout(false);
            this.grpOriginalSprite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditedSprite;
        private System.Windows.Forms.GroupBox grpOriginalSprite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Controls.TileSelectControl pnlTarget;
        private Controls.TileSelectControl pnlSource;
        private System.Windows.Forms.CheckBox chkTilesetUseGrid;
        private System.Windows.Forms.CheckBox chkTilesetIndexed;
    }
}