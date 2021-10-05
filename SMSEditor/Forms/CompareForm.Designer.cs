namespace SMSEditor.Forms
{
    partial class CompareForm
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
            this.grpOriginalSprite = new System.Windows.Forms.GroupBox();
            this.pnlOriginalSprite = new SMSEditor.Controls.ImageControl();
            this.grpEditedSprite = new System.Windows.Forms.GroupBox();
            this.pnlEditedSprite = new SMSEditor.Controls.ImageControl();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlSpriteTilemap = new System.Windows.Forms.Panel();
            this.lblSpriteTilemap = new System.Windows.Forms.Label();
            this.btnPreviousFrame = new System.Windows.Forms.Button();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.grpOriginalSprite.SuspendLayout();
            this.grpEditedSprite.SuspendLayout();
            this.pnlSpriteTilemap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOriginalSprite
            // 
            this.grpOriginalSprite.Controls.Add(this.pnlOriginalSprite);
            this.grpOriginalSprite.Location = new System.Drawing.Point(8, 8);
            this.grpOriginalSprite.Name = "grpOriginalSprite";
            this.grpOriginalSprite.Size = new System.Drawing.Size(360, 360);
            this.grpOriginalSprite.TabIndex = 0;
            this.grpOriginalSprite.TabStop = false;
            this.grpOriginalSprite.Text = "Original Sprite";
            // 
            // pnlOriginalSprite
            // 
            this.pnlOriginalSprite.AutoScroll = true;
            this.pnlOriginalSprite.AutoScrollMinSize = new System.Drawing.Size(328, 320);
            this.pnlOriginalSprite.Canvas = new System.Drawing.Size(8, 8);
            this.pnlOriginalSprite.Centered = true;
            this.pnlOriginalSprite.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlOriginalSprite.HatchForeColor = System.Drawing.Color.White;
            this.pnlOriginalSprite.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlOriginalSprite.Image = null;
            this.pnlOriginalSprite.ImageAlpha = 1F;
            this.pnlOriginalSprite.ImageScale = 1;
            this.pnlOriginalSprite.Location = new System.Drawing.Point(16, 24);
            this.pnlOriginalSprite.MinimumScale = 1;
            this.pnlOriginalSprite.Name = "pnlOriginalSprite";
            this.pnlOriginalSprite.Size = new System.Drawing.Size(328, 320);
            this.pnlOriginalSprite.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlOriginalSprite.TabIndex = 0;
            this.pnlOriginalSprite.UseCanvas = false;
            this.pnlOriginalSprite.UseHatch = true;
            this.pnlOriginalSprite.UseMouseWheelScaling = true;
            this.pnlOriginalSprite.ScaleChanged += new SMSEditor.Controls.ImageControl.ScaleChangedHandler(this.pnlSprite_ScaleChanged);
            this.pnlOriginalSprite.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlOriginalSprite_Scroll);
            // 
            // grpEditedSprite
            // 
            this.grpEditedSprite.Controls.Add(this.pnlEditedSprite);
            this.grpEditedSprite.Location = new System.Drawing.Point(384, 8);
            this.grpEditedSprite.Name = "grpEditedSprite";
            this.grpEditedSprite.Size = new System.Drawing.Size(360, 360);
            this.grpEditedSprite.TabIndex = 1;
            this.grpEditedSprite.TabStop = false;
            this.grpEditedSprite.Text = "Edited Sprite";
            // 
            // pnlEditedSprite
            // 
            this.pnlEditedSprite.AutoScroll = true;
            this.pnlEditedSprite.AutoScrollMinSize = new System.Drawing.Size(328, 320);
            this.pnlEditedSprite.Canvas = new System.Drawing.Size(8, 8);
            this.pnlEditedSprite.Centered = true;
            this.pnlEditedSprite.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlEditedSprite.HatchForeColor = System.Drawing.Color.White;
            this.pnlEditedSprite.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlEditedSprite.Image = null;
            this.pnlEditedSprite.ImageAlpha = 1F;
            this.pnlEditedSprite.ImageScale = 1;
            this.pnlEditedSprite.Location = new System.Drawing.Point(16, 24);
            this.pnlEditedSprite.MinimumScale = 1;
            this.pnlEditedSprite.Name = "pnlEditedSprite";
            this.pnlEditedSprite.Size = new System.Drawing.Size(328, 320);
            this.pnlEditedSprite.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlEditedSprite.TabIndex = 0;
            this.pnlEditedSprite.UseCanvas = false;
            this.pnlEditedSprite.UseHatch = true;
            this.pnlEditedSprite.UseMouseWheelScaling = true;
            this.pnlEditedSprite.ScaleChanged += new SMSEditor.Controls.ImageControl.ScaleChangedHandler(this.pnlSprite_ScaleChanged);
            this.pnlEditedSprite.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlEditedSprite_Scroll);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(665, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlSpriteTilemap
            // 
            this.pnlSpriteTilemap.Controls.Add(this.lblSpriteTilemap);
            this.pnlSpriteTilemap.Controls.Add(this.btnPreviousFrame);
            this.pnlSpriteTilemap.Controls.Add(this.btnNextFrame);
            this.pnlSpriteTilemap.Location = new System.Drawing.Point(8, 376);
            this.pnlSpriteTilemap.Name = "pnlSpriteTilemap";
            this.pnlSpriteTilemap.Size = new System.Drawing.Size(152, 29);
            this.pnlSpriteTilemap.TabIndex = 2;
            // 
            // lblSpriteTilemap
            // 
            this.lblSpriteTilemap.AutoSize = true;
            this.lblSpriteTilemap.Location = new System.Drawing.Point(36, 8);
            this.lblSpriteTilemap.Name = "lblSpriteTilemap";
            this.lblSpriteTilemap.Size = new System.Drawing.Size(80, 13);
            this.lblSpriteTilemap.TabIndex = 1;
            this.lblSpriteTilemap.Text = "Sprite Tilemap";
            // 
            // btnPreviousFrame
            // 
            this.btnPreviousFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousFrame.Location = new System.Drawing.Point(0, 3);
            this.btnPreviousFrame.Name = "btnPreviousFrame";
            this.btnPreviousFrame.Size = new System.Drawing.Size(25, 23);
            this.btnPreviousFrame.TabIndex = 0;
            this.btnPreviousFrame.Text = "<<";
            this.btnPreviousFrame.UseVisualStyleBackColor = true;
            this.btnPreviousFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextFrame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFrame.Location = new System.Drawing.Point(123, 3);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(25, 23);
            this.btnNextFrame.TabIndex = 2;
            this.btnNextFrame.Text = ">>";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // btnExportImage
            // 
            this.btnExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImage.Location = new System.Drawing.Point(561, 376);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(99, 23);
            this.btnExportImage.TabIndex = 3;
            this.btnExportImage.Text = "Export Image";
            this.btnExportImage.UseVisualStyleBackColor = true;
            this.btnExportImage.Click += new System.EventHandler(this.btnExportImage_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 407);
            this.Controls.Add(this.btnExportImage);
            this.Controls.Add(this.pnlSpriteTilemap);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpEditedSprite);
            this.Controls.Add(this.grpOriginalSprite);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompareForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compare Sprites";
            this.grpOriginalSprite.ResumeLayout(false);
            this.grpEditedSprite.ResumeLayout(false);
            this.pnlSpriteTilemap.ResumeLayout(false);
            this.pnlSpriteTilemap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOriginalSprite;
        private System.Windows.Forms.GroupBox grpEditedSprite;
        private System.Windows.Forms.Button btnOK;
        private Controls.ImageControl pnlEditedSprite;
        private Controls.ImageControl pnlOriginalSprite;
        private System.Windows.Forms.Panel pnlSpriteTilemap;
        private System.Windows.Forms.Label lblSpriteTilemap;
        private System.Windows.Forms.Button btnPreviousFrame;
        private System.Windows.Forms.Button btnNextFrame;
        private System.Windows.Forms.Button btnExportImage;
    }
}