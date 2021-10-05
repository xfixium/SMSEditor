namespace SMSEditor.Controls
{
    partial class AssetSpriteControl
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
            this.tpnlSpritesMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSpriteImage = new SMSEditor.Controls.ImageControl();
            this.grpSpriteList = new System.Windows.Forms.GroupBox();
            this.pnlSpriteListBorder = new System.Windows.Forms.Panel();
            this.lstSprites = new System.Windows.Forms.ListBox();
            this.pnlSpriteButtons = new System.Windows.Forms.Panel();
            this.btnSpriteRemove = new System.Windows.Forms.Button();
            this.btnSpriteSave = new System.Windows.Forms.Button();
            this.pnlSpriteOptions = new System.Windows.Forms.Panel();
            this.pnlSpriteTilemapsBorder = new System.Windows.Forms.Panel();
            this.lstSpriteTilemaps = new System.Windows.Forms.ListBox();
            this.btnSpriteTilemapRemove = new System.Windows.Forms.Button();
            this.lblSpriteName = new System.Windows.Forms.Label();
            this.cbSpriteBGPalette = new System.Windows.Forms.ComboBox();
            this.pnlSpriteBGPalette = new SMSEditor.Controls.PaletteControl();
            this.txtSpriteName = new System.Windows.Forms.TextBox();
            this.lblSpriteSpritePalette = new System.Windows.Forms.Label();
            this.btnSpriteTilemapAdd = new System.Windows.Forms.Button();
            this.btnSpriteTilemapMoveDown = new System.Windows.Forms.Button();
            this.cbSpriteTilemap = new System.Windows.Forms.ComboBox();
            this.cbSpriteSPRPalette = new System.Windows.Forms.ComboBox();
            this.pnlSpriteSPRPalette = new SMSEditor.Controls.PaletteControl();
            this.lblSpriteBGPalette = new System.Windows.Forms.Label();
            this.lblSpriteTilemap = new System.Windows.Forms.Label();
            this.btnSpriteTilemapMoveUp = new System.Windows.Forms.Button();
            this.tpnlSpritesMain.SuspendLayout();
            this.grpSpriteList.SuspendLayout();
            this.pnlSpriteListBorder.SuspendLayout();
            this.pnlSpriteButtons.SuspendLayout();
            this.pnlSpriteOptions.SuspendLayout();
            this.pnlSpriteTilemapsBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlSpritesMain
            // 
            this.tpnlSpritesMain.ColumnCount = 3;
            this.tpnlSpritesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlSpritesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpritesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tpnlSpritesMain.Controls.Add(this.pnlSpriteImage, 1, 0);
            this.tpnlSpritesMain.Controls.Add(this.grpSpriteList, 0, 0);
            this.tpnlSpritesMain.Controls.Add(this.pnlSpriteOptions, 2, 0);
            this.tpnlSpritesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpritesMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlSpritesMain.Name = "tpnlSpritesMain";
            this.tpnlSpritesMain.RowCount = 1;
            this.tpnlSpritesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.tpnlSpritesMain.Size = new System.Drawing.Size(810, 544);
            this.tpnlSpritesMain.TabIndex = 1;
            // 
            // pnlSpriteImage
            // 
            this.pnlSpriteImage.AutoScroll = true;
            this.pnlSpriteImage.AutoScrollMinSize = new System.Drawing.Size(430, 535);
            this.pnlSpriteImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSpriteImage.Centered = true;
            this.pnlSpriteImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSpriteImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlSpriteImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSpriteImage.Image = null;
            this.pnlSpriteImage.ImageAlpha = 1F;
            this.pnlSpriteImage.ImageScale = 1;
            this.pnlSpriteImage.Location = new System.Drawing.Point(202, 7);
            this.pnlSpriteImage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 2);
            this.pnlSpriteImage.MinimumScale = 1;
            this.pnlSpriteImage.Name = "pnlSpriteImage";
            this.pnlSpriteImage.Size = new System.Drawing.Size(430, 535);
            this.pnlSpriteImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSpriteImage.TabIndex = 1;
            this.pnlSpriteImage.UseCanvas = false;
            this.pnlSpriteImage.UseHatch = true;
            this.pnlSpriteImage.UseMouseWheelScaling = true;
            // 
            // grpSpriteList
            // 
            this.grpSpriteList.Controls.Add(this.pnlSpriteListBorder);
            this.grpSpriteList.Controls.Add(this.pnlSpriteButtons);
            this.grpSpriteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSpriteList.Location = new System.Drawing.Point(0, 0);
            this.grpSpriteList.Margin = new System.Windows.Forms.Padding(0);
            this.grpSpriteList.Name = "grpSpriteList";
            this.grpSpriteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpSpriteList.Size = new System.Drawing.Size(196, 544);
            this.grpSpriteList.TabIndex = 0;
            this.grpSpriteList.TabStop = false;
            this.grpSpriteList.Text = "Sprites";
            // 
            // pnlSpriteListBorder
            // 
            this.pnlSpriteListBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSpriteListBorder.Controls.Add(this.lstSprites);
            this.pnlSpriteListBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteListBorder.Location = new System.Drawing.Point(12, 66);
            this.pnlSpriteListBorder.Name = "pnlSpriteListBorder";
            this.pnlSpriteListBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpriteListBorder.Size = new System.Drawing.Size(172, 466);
            this.pnlSpriteListBorder.TabIndex = 1;
            // 
            // lstSprites
            // 
            this.lstSprites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSprites.FormattingEnabled = true;
            this.lstSprites.IntegralHeight = false;
            this.lstSprites.Location = new System.Drawing.Point(1, 1);
            this.lstSprites.Name = "lstSprites";
            this.lstSprites.Size = new System.Drawing.Size(170, 464);
            this.lstSprites.TabIndex = 0;
            this.lstSprites.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // pnlSpriteButtons
            // 
            this.pnlSpriteButtons.Controls.Add(this.btnSpriteRemove);
            this.pnlSpriteButtons.Controls.Add(this.btnSpriteSave);
            this.pnlSpriteButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpriteButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlSpriteButtons.Name = "pnlSpriteButtons";
            this.pnlSpriteButtons.Size = new System.Drawing.Size(172, 47);
            this.pnlSpriteButtons.TabIndex = 0;
            // 
            // btnSpriteRemove
            // 
            this.btnSpriteRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpriteRemove.Location = new System.Drawing.Point(0, 23);
            this.btnSpriteRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpriteRemove.Name = "btnSpriteRemove";
            this.btnSpriteRemove.Size = new System.Drawing.Size(172, 23);
            this.btnSpriteRemove.TabIndex = 1;
            this.btnSpriteRemove.Text = "Remove Sprite";
            this.btnSpriteRemove.UseVisualStyleBackColor = true;
            this.btnSpriteRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnSpriteSave
            // 
            this.btnSpriteSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpriteSave.Location = new System.Drawing.Point(0, 0);
            this.btnSpriteSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpriteSave.Name = "btnSpriteSave";
            this.btnSpriteSave.Size = new System.Drawing.Size(172, 23);
            this.btnSpriteSave.TabIndex = 0;
            this.btnSpriteSave.Text = "Save Sprite";
            this.btnSpriteSave.UseVisualStyleBackColor = true;
            this.btnSpriteSave.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // pnlSpriteOptions
            // 
            this.pnlSpriteOptions.Controls.Add(this.pnlSpriteTilemapsBorder);
            this.pnlSpriteOptions.Controls.Add(this.btnSpriteTilemapRemove);
            this.pnlSpriteOptions.Controls.Add(this.lblSpriteName);
            this.pnlSpriteOptions.Controls.Add(this.cbSpriteBGPalette);
            this.pnlSpriteOptions.Controls.Add(this.pnlSpriteBGPalette);
            this.pnlSpriteOptions.Controls.Add(this.txtSpriteName);
            this.pnlSpriteOptions.Controls.Add(this.lblSpriteSpritePalette);
            this.pnlSpriteOptions.Controls.Add(this.btnSpriteTilemapAdd);
            this.pnlSpriteOptions.Controls.Add(this.btnSpriteTilemapMoveDown);
            this.pnlSpriteOptions.Controls.Add(this.cbSpriteTilemap);
            this.pnlSpriteOptions.Controls.Add(this.cbSpriteSPRPalette);
            this.pnlSpriteOptions.Controls.Add(this.pnlSpriteSPRPalette);
            this.pnlSpriteOptions.Controls.Add(this.lblSpriteBGPalette);
            this.pnlSpriteOptions.Controls.Add(this.lblSpriteTilemap);
            this.pnlSpriteOptions.Controls.Add(this.btnSpriteTilemapMoveUp);
            this.pnlSpriteOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteOptions.Location = new System.Drawing.Point(638, 6);
            this.pnlSpriteOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSpriteOptions.Name = "pnlSpriteOptions";
            this.pnlSpriteOptions.Size = new System.Drawing.Size(172, 538);
            this.pnlSpriteOptions.TabIndex = 2;
            // 
            // pnlSpriteTilemapsBorder
            // 
            this.pnlSpriteTilemapsBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSpriteTilemapsBorder.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSpriteTilemapsBorder.Controls.Add(this.lstSpriteTilemaps);
            this.pnlSpriteTilemapsBorder.Location = new System.Drawing.Point(0, 280);
            this.pnlSpriteTilemapsBorder.Name = "pnlSpriteTilemapsBorder";
            this.pnlSpriteTilemapsBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpriteTilemapsBorder.Size = new System.Drawing.Size(168, 256);
            this.pnlSpriteTilemapsBorder.TabIndex = 14;
            // 
            // lstSpriteTilemaps
            // 
            this.lstSpriteTilemaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSpriteTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSpriteTilemaps.FormattingEnabled = true;
            this.lstSpriteTilemaps.IntegralHeight = false;
            this.lstSpriteTilemaps.Location = new System.Drawing.Point(1, 1);
            this.lstSpriteTilemaps.Name = "lstSpriteTilemaps";
            this.lstSpriteTilemaps.Size = new System.Drawing.Size(166, 254);
            this.lstSpriteTilemaps.TabIndex = 0;
            this.lstSpriteTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstAssets_SelectedIndexChanged);
            // 
            // btnSpriteTilemapRemove
            // 
            this.btnSpriteTilemapRemove.Location = new System.Drawing.Point(120, 256);
            this.btnSpriteTilemapRemove.Name = "btnSpriteTilemapRemove";
            this.btnSpriteTilemapRemove.Size = new System.Drawing.Size(48, 23);
            this.btnSpriteTilemapRemove.TabIndex = 13;
            this.btnSpriteTilemapRemove.Text = "Delete";
            this.btnSpriteTilemapRemove.UseVisualStyleBackColor = true;
            this.btnSpriteTilemapRemove.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // lblSpriteName
            // 
            this.lblSpriteName.AutoSize = true;
            this.lblSpriteName.Location = new System.Drawing.Point(0, 0);
            this.lblSpriteName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteName.Name = "lblSpriteName";
            this.lblSpriteName.Size = new System.Drawing.Size(72, 13);
            this.lblSpriteName.TabIndex = 0;
            this.lblSpriteName.Text = "Sprite Name:";
            this.lblSpriteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteBGPalette
            // 
            this.cbSpriteBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteBGPalette.FormattingEnabled = true;
            this.cbSpriteBGPalette.Location = new System.Drawing.Point(0, 56);
            this.cbSpriteBGPalette.Name = "cbSpriteBGPalette";
            this.cbSpriteBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSpriteBGPalette.TabIndex = 3;
            this.cbSpriteBGPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // pnlSpriteBGPalette
            // 
            this.pnlSpriteBGPalette.Location = new System.Drawing.Point(0, 80);
            this.pnlSpriteBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSpriteBGPalette.Name = "pnlSpriteBGPalette";
            this.pnlSpriteBGPalette.ReadOnly = true;
            this.pnlSpriteBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSpriteBGPalette.TabIndex = 4;
            // 
            // txtSpriteName
            // 
            this.txtSpriteName.Location = new System.Drawing.Point(0, 16);
            this.txtSpriteName.Name = "txtSpriteName";
            this.txtSpriteName.Size = new System.Drawing.Size(168, 22);
            this.txtSpriteName.TabIndex = 1;
            // 
            // lblSpriteSpritePalette
            // 
            this.lblSpriteSpritePalette.AutoSize = true;
            this.lblSpriteSpritePalette.Location = new System.Drawing.Point(0, 128);
            this.lblSpriteSpritePalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteSpritePalette.Name = "lblSpriteSpritePalette";
            this.lblSpriteSpritePalette.Size = new System.Drawing.Size(78, 13);
            this.lblSpriteSpritePalette.TabIndex = 5;
            this.lblSpriteSpritePalette.Text = "Sprite Palette:";
            this.lblSpriteSpritePalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpriteTilemapAdd
            // 
            this.btnSpriteTilemapAdd.Location = new System.Drawing.Point(0, 256);
            this.btnSpriteTilemapAdd.Name = "btnSpriteTilemapAdd";
            this.btnSpriteTilemapAdd.Size = new System.Drawing.Size(40, 23);
            this.btnSpriteTilemapAdd.TabIndex = 10;
            this.btnSpriteTilemapAdd.Text = "Add";
            this.btnSpriteTilemapAdd.UseVisualStyleBackColor = true;
            this.btnSpriteTilemapAdd.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnSpriteTilemapMoveDown
            // 
            this.btnSpriteTilemapMoveDown.Location = new System.Drawing.Point(72, 256);
            this.btnSpriteTilemapMoveDown.Name = "btnSpriteTilemapMoveDown";
            this.btnSpriteTilemapMoveDown.Size = new System.Drawing.Size(48, 23);
            this.btnSpriteTilemapMoveDown.TabIndex = 12;
            this.btnSpriteTilemapMoveDown.Text = "Down";
            this.btnSpriteTilemapMoveDown.UseVisualStyleBackColor = true;
            this.btnSpriteTilemapMoveDown.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // cbSpriteTilemap
            // 
            this.cbSpriteTilemap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteTilemap.FormattingEnabled = true;
            this.cbSpriteTilemap.Location = new System.Drawing.Point(0, 232);
            this.cbSpriteTilemap.Name = "cbSpriteTilemap";
            this.cbSpriteTilemap.Size = new System.Drawing.Size(168, 21);
            this.cbSpriteTilemap.TabIndex = 9;
            this.cbSpriteTilemap.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // cbSpriteSPRPalette
            // 
            this.cbSpriteSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteSPRPalette.FormattingEnabled = true;
            this.cbSpriteSPRPalette.Location = new System.Drawing.Point(0, 144);
            this.cbSpriteSPRPalette.Name = "cbSpriteSPRPalette";
            this.cbSpriteSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSpriteSPRPalette.TabIndex = 6;
            this.cbSpriteSPRPalette.SelectedIndexChanged += new System.EventHandler(this.cbAsset_SelectedIndexChanged);
            // 
            // pnlSpriteSPRPalette
            // 
            this.pnlSpriteSPRPalette.Location = new System.Drawing.Point(0, 168);
            this.pnlSpriteSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSpriteSPRPalette.Name = "pnlSpriteSPRPalette";
            this.pnlSpriteSPRPalette.ReadOnly = true;
            this.pnlSpriteSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSpriteSPRPalette.TabIndex = 7;
            // 
            // lblSpriteBGPalette
            // 
            this.lblSpriteBGPalette.AutoSize = true;
            this.lblSpriteBGPalette.Location = new System.Drawing.Point(0, 40);
            this.lblSpriteBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteBGPalette.Name = "lblSpriteBGPalette";
            this.lblSpriteBGPalette.Size = new System.Drawing.Size(110, 13);
            this.lblSpriteBGPalette.TabIndex = 2;
            this.lblSpriteBGPalette.Text = "Background Palette:";
            this.lblSpriteBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpriteTilemap
            // 
            this.lblSpriteTilemap.AutoSize = true;
            this.lblSpriteTilemap.Location = new System.Drawing.Point(0, 216);
            this.lblSpriteTilemap.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteTilemap.Name = "lblSpriteTilemap";
            this.lblSpriteTilemap.Size = new System.Drawing.Size(50, 13);
            this.lblSpriteTilemap.TabIndex = 8;
            this.lblSpriteTilemap.Text = "Tilemap:";
            this.lblSpriteTilemap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpriteTilemapMoveUp
            // 
            this.btnSpriteTilemapMoveUp.Location = new System.Drawing.Point(40, 256);
            this.btnSpriteTilemapMoveUp.Name = "btnSpriteTilemapMoveUp";
            this.btnSpriteTilemapMoveUp.Size = new System.Drawing.Size(32, 23);
            this.btnSpriteTilemapMoveUp.TabIndex = 11;
            this.btnSpriteTilemapMoveUp.Text = "Up";
            this.btnSpriteTilemapMoveUp.UseVisualStyleBackColor = true;
            this.btnSpriteTilemapMoveUp.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // AssetSpriteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlSpritesMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AssetSpriteControl";
            this.Size = new System.Drawing.Size(810, 544);
            this.tpnlSpritesMain.ResumeLayout(false);
            this.grpSpriteList.ResumeLayout(false);
            this.pnlSpriteListBorder.ResumeLayout(false);
            this.pnlSpriteButtons.ResumeLayout(false);
            this.pnlSpriteOptions.ResumeLayout(false);
            this.pnlSpriteOptions.PerformLayout();
            this.pnlSpriteTilemapsBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlSpritesMain;
        private ImageControl pnlSpriteImage;
        private System.Windows.Forms.GroupBox grpSpriteList;
        private System.Windows.Forms.Panel pnlSpriteListBorder;
        private System.Windows.Forms.ListBox lstSprites;
        private System.Windows.Forms.Panel pnlSpriteButtons;
        private System.Windows.Forms.Button btnSpriteRemove;
        private System.Windows.Forms.Button btnSpriteSave;
        private System.Windows.Forms.Panel pnlSpriteOptions;
        private System.Windows.Forms.Panel pnlSpriteTilemapsBorder;
        private System.Windows.Forms.ListBox lstSpriteTilemaps;
        private System.Windows.Forms.Button btnSpriteTilemapRemove;
        private System.Windows.Forms.Label lblSpriteName;
        private System.Windows.Forms.ComboBox cbSpriteBGPalette;
        private PaletteControl pnlSpriteBGPalette;
        private System.Windows.Forms.TextBox txtSpriteName;
        private System.Windows.Forms.Label lblSpriteSpritePalette;
        private System.Windows.Forms.Button btnSpriteTilemapAdd;
        private System.Windows.Forms.Button btnSpriteTilemapMoveDown;
        private System.Windows.Forms.ComboBox cbSpriteTilemap;
        private System.Windows.Forms.ComboBox cbSpriteSPRPalette;
        private PaletteControl pnlSpriteSPRPalette;
        private System.Windows.Forms.Label lblSpriteBGPalette;
        private System.Windows.Forms.Label lblSpriteTilemap;
        private System.Windows.Forms.Button btnSpriteTilemapMoveUp;
    }
}
