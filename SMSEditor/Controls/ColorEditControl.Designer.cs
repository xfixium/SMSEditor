// 
// SMS Editor
// Copyright (C) 2021 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

namespace SMSEditor.Controls
{
    partial class ColorEditControl
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
            this.components = new System.ComponentModel.Container();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTargetPalette = new System.Windows.Forms.Panel();
            this.pnlColor31 = new SMSEditor.Controls.ColorControl();
            this.pnlColor30 = new SMSEditor.Controls.ColorControl();
            this.pnlColor29 = new SMSEditor.Controls.ColorControl();
            this.pnlColor28 = new SMSEditor.Controls.ColorControl();
            this.pnlColor27 = new SMSEditor.Controls.ColorControl();
            this.pnlColor26 = new SMSEditor.Controls.ColorControl();
            this.pnlColor25 = new SMSEditor.Controls.ColorControl();
            this.pnlColor24 = new SMSEditor.Controls.ColorControl();
            this.pnlColor23 = new SMSEditor.Controls.ColorControl();
            this.pnlColor22 = new SMSEditor.Controls.ColorControl();
            this.pnlColor21 = new SMSEditor.Controls.ColorControl();
            this.pnlColor20 = new SMSEditor.Controls.ColorControl();
            this.pnlColor19 = new SMSEditor.Controls.ColorControl();
            this.pnlColor18 = new SMSEditor.Controls.ColorControl();
            this.pnlColor17 = new SMSEditor.Controls.ColorControl();
            this.pnlColor16 = new SMSEditor.Controls.ColorControl();
            this.pnlImportPalette = new System.Windows.Forms.Panel();
            this.pnlColor15 = new SMSEditor.Controls.ColorControl();
            this.pnlColor14 = new SMSEditor.Controls.ColorControl();
            this.pnlColor13 = new SMSEditor.Controls.ColorControl();
            this.pnlColor12 = new SMSEditor.Controls.ColorControl();
            this.pnlColor11 = new SMSEditor.Controls.ColorControl();
            this.pnlColor10 = new SMSEditor.Controls.ColorControl();
            this.pnlColor9 = new SMSEditor.Controls.ColorControl();
            this.pnlColor8 = new SMSEditor.Controls.ColorControl();
            this.pnlColor7 = new SMSEditor.Controls.ColorControl();
            this.pnlColor6 = new SMSEditor.Controls.ColorControl();
            this.pnlColor5 = new SMSEditor.Controls.ColorControl();
            this.pnlColor4 = new SMSEditor.Controls.ColorControl();
            this.pnlColor3 = new SMSEditor.Controls.ColorControl();
            this.pnlColor2 = new SMSEditor.Controls.ColorControl();
            this.pnlColor1 = new SMSEditor.Controls.ColorControl();
            this.pnlColor0 = new SMSEditor.Controls.ColorControl();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRemoveColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.tpnlMain.SuspendLayout();
            this.pnlTargetPalette.SuspendLayout();
            this.pnlImportPalette.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 3;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Controls.Add(this.pnlTargetPalette, 1, 1);
            this.tpnlMain.Controls.Add(this.pnlImportPalette, 1, 0);
            this.tpnlMain.Controls.Add(this.btnLeft, 0, 0);
            this.tpnlMain.Controls.Add(this.btnRight, 2, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.Size = new System.Drawing.Size(561, 80);
            this.tpnlMain.TabIndex = 36;
            // 
            // pnlTargetPalette
            // 
            this.pnlTargetPalette.Controls.Add(this.pnlColor31);
            this.pnlTargetPalette.Controls.Add(this.pnlColor30);
            this.pnlTargetPalette.Controls.Add(this.pnlColor29);
            this.pnlTargetPalette.Controls.Add(this.pnlColor28);
            this.pnlTargetPalette.Controls.Add(this.pnlColor27);
            this.pnlTargetPalette.Controls.Add(this.pnlColor26);
            this.pnlTargetPalette.Controls.Add(this.pnlColor25);
            this.pnlTargetPalette.Controls.Add(this.pnlColor24);
            this.pnlTargetPalette.Controls.Add(this.pnlColor23);
            this.pnlTargetPalette.Controls.Add(this.pnlColor22);
            this.pnlTargetPalette.Controls.Add(this.pnlColor21);
            this.pnlTargetPalette.Controls.Add(this.pnlColor20);
            this.pnlTargetPalette.Controls.Add(this.pnlColor19);
            this.pnlTargetPalette.Controls.Add(this.pnlColor18);
            this.pnlTargetPalette.Controls.Add(this.pnlColor17);
            this.pnlTargetPalette.Controls.Add(this.pnlColor16);
            this.pnlTargetPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTargetPalette.Location = new System.Drawing.Point(20, 40);
            this.pnlTargetPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTargetPalette.Name = "pnlTargetPalette";
            this.pnlTargetPalette.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTargetPalette.Size = new System.Drawing.Size(521, 40);
            this.pnlTargetPalette.TabIndex = 40;
            // 
            // pnlColor31
            // 
            this.pnlColor31.AutoScroll = true;
            this.pnlColor31.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor31.BackColor = System.Drawing.Color.Black;
            this.pnlColor31.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor31.Centered = false;
            this.pnlColor31.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor31.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor31.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor31.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor31.Image = null;
            this.pnlColor31.ImageAlpha = 1F;
            this.pnlColor31.ImageScale = 1;
            this.pnlColor31.Location = new System.Drawing.Point(484, 4);
            this.pnlColor31.MinimumScale = 1;
            this.pnlColor31.Name = "pnlColor31";
            this.pnlColor31.Selected = false;
            this.pnlColor31.Size = new System.Drawing.Size(32, 32);
            this.pnlColor31.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor31.TabIndex = 20;
            this.pnlColor31.Tag = "15";
            this.pnlColor31.UseCanvas = false;
            this.pnlColor31.UseHatch = false;
            this.pnlColor31.UseMouseWheelScaling = false;
            // 
            // pnlColor30
            // 
            this.pnlColor30.AutoScroll = true;
            this.pnlColor30.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor30.BackColor = System.Drawing.Color.Black;
            this.pnlColor30.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor30.Centered = false;
            this.pnlColor30.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor30.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor30.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor30.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor30.Image = null;
            this.pnlColor30.ImageAlpha = 1F;
            this.pnlColor30.ImageScale = 1;
            this.pnlColor30.Location = new System.Drawing.Point(452, 4);
            this.pnlColor30.MinimumScale = 1;
            this.pnlColor30.Name = "pnlColor30";
            this.pnlColor30.Selected = false;
            this.pnlColor30.Size = new System.Drawing.Size(32, 32);
            this.pnlColor30.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor30.TabIndex = 6;
            this.pnlColor30.Tag = "14";
            this.pnlColor30.UseCanvas = false;
            this.pnlColor30.UseHatch = false;
            this.pnlColor30.UseMouseWheelScaling = false;
            // 
            // pnlColor29
            // 
            this.pnlColor29.AutoScroll = true;
            this.pnlColor29.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor29.BackColor = System.Drawing.Color.Black;
            this.pnlColor29.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor29.Centered = false;
            this.pnlColor29.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor29.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor29.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor29.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor29.Image = null;
            this.pnlColor29.ImageAlpha = 1F;
            this.pnlColor29.ImageScale = 1;
            this.pnlColor29.Location = new System.Drawing.Point(420, 4);
            this.pnlColor29.MinimumScale = 1;
            this.pnlColor29.Name = "pnlColor29";
            this.pnlColor29.Selected = false;
            this.pnlColor29.Size = new System.Drawing.Size(32, 32);
            this.pnlColor29.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor29.TabIndex = 22;
            this.pnlColor29.Tag = "13";
            this.pnlColor29.UseCanvas = false;
            this.pnlColor29.UseHatch = false;
            this.pnlColor29.UseMouseWheelScaling = false;
            // 
            // pnlColor28
            // 
            this.pnlColor28.AutoScroll = true;
            this.pnlColor28.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor28.BackColor = System.Drawing.Color.Black;
            this.pnlColor28.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor28.Centered = false;
            this.pnlColor28.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor28.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor28.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor28.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor28.Image = null;
            this.pnlColor28.ImageAlpha = 1F;
            this.pnlColor28.ImageScale = 1;
            this.pnlColor28.Location = new System.Drawing.Point(388, 4);
            this.pnlColor28.MinimumScale = 1;
            this.pnlColor28.Name = "pnlColor28";
            this.pnlColor28.Selected = false;
            this.pnlColor28.Size = new System.Drawing.Size(32, 32);
            this.pnlColor28.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor28.TabIndex = 23;
            this.pnlColor28.Tag = "12";
            this.pnlColor28.UseCanvas = false;
            this.pnlColor28.UseHatch = false;
            this.pnlColor28.UseMouseWheelScaling = false;
            // 
            // pnlColor27
            // 
            this.pnlColor27.AutoScroll = true;
            this.pnlColor27.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor27.BackColor = System.Drawing.Color.Black;
            this.pnlColor27.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor27.Centered = false;
            this.pnlColor27.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor27.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor27.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor27.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor27.Image = null;
            this.pnlColor27.ImageAlpha = 1F;
            this.pnlColor27.ImageScale = 1;
            this.pnlColor27.Location = new System.Drawing.Point(356, 4);
            this.pnlColor27.MinimumScale = 1;
            this.pnlColor27.Name = "pnlColor27";
            this.pnlColor27.Selected = false;
            this.pnlColor27.Size = new System.Drawing.Size(32, 32);
            this.pnlColor27.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor27.TabIndex = 24;
            this.pnlColor27.Tag = "11";
            this.pnlColor27.UseCanvas = false;
            this.pnlColor27.UseHatch = false;
            this.pnlColor27.UseMouseWheelScaling = false;
            // 
            // pnlColor26
            // 
            this.pnlColor26.AutoScroll = true;
            this.pnlColor26.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor26.BackColor = System.Drawing.Color.Black;
            this.pnlColor26.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor26.Centered = false;
            this.pnlColor26.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor26.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor26.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor26.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor26.Image = null;
            this.pnlColor26.ImageAlpha = 1F;
            this.pnlColor26.ImageScale = 1;
            this.pnlColor26.Location = new System.Drawing.Point(324, 4);
            this.pnlColor26.MinimumScale = 1;
            this.pnlColor26.Name = "pnlColor26";
            this.pnlColor26.Selected = false;
            this.pnlColor26.Size = new System.Drawing.Size(32, 32);
            this.pnlColor26.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor26.TabIndex = 25;
            this.pnlColor26.Tag = "10";
            this.pnlColor26.UseCanvas = false;
            this.pnlColor26.UseHatch = false;
            this.pnlColor26.UseMouseWheelScaling = false;
            // 
            // pnlColor25
            // 
            this.pnlColor25.AutoScroll = true;
            this.pnlColor25.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor25.BackColor = System.Drawing.Color.Black;
            this.pnlColor25.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor25.Centered = false;
            this.pnlColor25.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor25.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor25.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor25.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor25.Image = null;
            this.pnlColor25.ImageAlpha = 1F;
            this.pnlColor25.ImageScale = 1;
            this.pnlColor25.Location = new System.Drawing.Point(292, 4);
            this.pnlColor25.MinimumScale = 1;
            this.pnlColor25.Name = "pnlColor25";
            this.pnlColor25.Selected = false;
            this.pnlColor25.Size = new System.Drawing.Size(32, 32);
            this.pnlColor25.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor25.TabIndex = 26;
            this.pnlColor25.Tag = "9";
            this.pnlColor25.UseCanvas = false;
            this.pnlColor25.UseHatch = false;
            this.pnlColor25.UseMouseWheelScaling = false;
            // 
            // pnlColor24
            // 
            this.pnlColor24.AutoScroll = true;
            this.pnlColor24.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor24.BackColor = System.Drawing.Color.Black;
            this.pnlColor24.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor24.Centered = false;
            this.pnlColor24.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor24.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor24.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor24.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor24.Image = null;
            this.pnlColor24.ImageAlpha = 1F;
            this.pnlColor24.ImageScale = 1;
            this.pnlColor24.Location = new System.Drawing.Point(260, 4);
            this.pnlColor24.MinimumScale = 1;
            this.pnlColor24.Name = "pnlColor24";
            this.pnlColor24.Selected = false;
            this.pnlColor24.Size = new System.Drawing.Size(32, 32);
            this.pnlColor24.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor24.TabIndex = 27;
            this.pnlColor24.Tag = "8";
            this.pnlColor24.UseCanvas = false;
            this.pnlColor24.UseHatch = false;
            this.pnlColor24.UseMouseWheelScaling = false;
            // 
            // pnlColor23
            // 
            this.pnlColor23.AutoScroll = true;
            this.pnlColor23.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor23.BackColor = System.Drawing.Color.Black;
            this.pnlColor23.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor23.Centered = false;
            this.pnlColor23.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor23.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor23.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor23.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor23.Image = null;
            this.pnlColor23.ImageAlpha = 1F;
            this.pnlColor23.ImageScale = 1;
            this.pnlColor23.Location = new System.Drawing.Point(228, 4);
            this.pnlColor23.MinimumScale = 1;
            this.pnlColor23.Name = "pnlColor23";
            this.pnlColor23.Selected = false;
            this.pnlColor23.Size = new System.Drawing.Size(32, 32);
            this.pnlColor23.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor23.TabIndex = 28;
            this.pnlColor23.Tag = "7";
            this.pnlColor23.UseCanvas = false;
            this.pnlColor23.UseHatch = false;
            this.pnlColor23.UseMouseWheelScaling = false;
            // 
            // pnlColor22
            // 
            this.pnlColor22.AutoScroll = true;
            this.pnlColor22.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor22.BackColor = System.Drawing.Color.Black;
            this.pnlColor22.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor22.Centered = false;
            this.pnlColor22.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor22.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor22.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor22.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor22.Image = null;
            this.pnlColor22.ImageAlpha = 1F;
            this.pnlColor22.ImageScale = 1;
            this.pnlColor22.Location = new System.Drawing.Point(196, 4);
            this.pnlColor22.MinimumScale = 1;
            this.pnlColor22.Name = "pnlColor22";
            this.pnlColor22.Selected = false;
            this.pnlColor22.Size = new System.Drawing.Size(32, 32);
            this.pnlColor22.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor22.TabIndex = 29;
            this.pnlColor22.Tag = "6";
            this.pnlColor22.UseCanvas = false;
            this.pnlColor22.UseHatch = false;
            this.pnlColor22.UseMouseWheelScaling = false;
            // 
            // pnlColor21
            // 
            this.pnlColor21.AutoScroll = true;
            this.pnlColor21.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor21.BackColor = System.Drawing.Color.Black;
            this.pnlColor21.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor21.Centered = false;
            this.pnlColor21.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor21.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor21.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor21.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor21.Image = null;
            this.pnlColor21.ImageAlpha = 1F;
            this.pnlColor21.ImageScale = 1;
            this.pnlColor21.Location = new System.Drawing.Point(164, 4);
            this.pnlColor21.MinimumScale = 1;
            this.pnlColor21.Name = "pnlColor21";
            this.pnlColor21.Selected = false;
            this.pnlColor21.Size = new System.Drawing.Size(32, 32);
            this.pnlColor21.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor21.TabIndex = 30;
            this.pnlColor21.Tag = "5";
            this.pnlColor21.UseCanvas = false;
            this.pnlColor21.UseHatch = false;
            this.pnlColor21.UseMouseWheelScaling = false;
            // 
            // pnlColor20
            // 
            this.pnlColor20.AutoScroll = true;
            this.pnlColor20.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor20.BackColor = System.Drawing.Color.Black;
            this.pnlColor20.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor20.Centered = false;
            this.pnlColor20.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor20.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor20.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor20.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor20.Image = null;
            this.pnlColor20.ImageAlpha = 1F;
            this.pnlColor20.ImageScale = 1;
            this.pnlColor20.Location = new System.Drawing.Point(132, 4);
            this.pnlColor20.MinimumScale = 1;
            this.pnlColor20.Name = "pnlColor20";
            this.pnlColor20.Selected = false;
            this.pnlColor20.Size = new System.Drawing.Size(32, 32);
            this.pnlColor20.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor20.TabIndex = 31;
            this.pnlColor20.Tag = "4";
            this.pnlColor20.UseCanvas = false;
            this.pnlColor20.UseHatch = false;
            this.pnlColor20.UseMouseWheelScaling = false;
            // 
            // pnlColor19
            // 
            this.pnlColor19.AutoScroll = true;
            this.pnlColor19.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor19.BackColor = System.Drawing.Color.Black;
            this.pnlColor19.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor19.Centered = false;
            this.pnlColor19.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor19.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor19.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor19.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor19.Image = null;
            this.pnlColor19.ImageAlpha = 1F;
            this.pnlColor19.ImageScale = 1;
            this.pnlColor19.Location = new System.Drawing.Point(100, 4);
            this.pnlColor19.MinimumScale = 1;
            this.pnlColor19.Name = "pnlColor19";
            this.pnlColor19.Selected = false;
            this.pnlColor19.Size = new System.Drawing.Size(32, 32);
            this.pnlColor19.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor19.TabIndex = 32;
            this.pnlColor19.Tag = "3";
            this.pnlColor19.UseCanvas = false;
            this.pnlColor19.UseHatch = false;
            this.pnlColor19.UseMouseWheelScaling = false;
            // 
            // pnlColor18
            // 
            this.pnlColor18.AutoScroll = true;
            this.pnlColor18.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor18.BackColor = System.Drawing.Color.Black;
            this.pnlColor18.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor18.Centered = false;
            this.pnlColor18.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor18.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor18.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor18.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor18.Image = null;
            this.pnlColor18.ImageAlpha = 1F;
            this.pnlColor18.ImageScale = 1;
            this.pnlColor18.Location = new System.Drawing.Point(68, 4);
            this.pnlColor18.MinimumScale = 1;
            this.pnlColor18.Name = "pnlColor18";
            this.pnlColor18.Selected = false;
            this.pnlColor18.Size = new System.Drawing.Size(32, 32);
            this.pnlColor18.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor18.TabIndex = 33;
            this.pnlColor18.Tag = "2";
            this.pnlColor18.UseCanvas = false;
            this.pnlColor18.UseHatch = false;
            this.pnlColor18.UseMouseWheelScaling = false;
            // 
            // pnlColor17
            // 
            this.pnlColor17.AutoScroll = true;
            this.pnlColor17.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor17.BackColor = System.Drawing.Color.Black;
            this.pnlColor17.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor17.Centered = false;
            this.pnlColor17.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor17.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor17.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor17.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor17.Image = null;
            this.pnlColor17.ImageAlpha = 1F;
            this.pnlColor17.ImageScale = 1;
            this.pnlColor17.Location = new System.Drawing.Point(36, 4);
            this.pnlColor17.MinimumScale = 1;
            this.pnlColor17.Name = "pnlColor17";
            this.pnlColor17.Selected = false;
            this.pnlColor17.Size = new System.Drawing.Size(32, 32);
            this.pnlColor17.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor17.TabIndex = 34;
            this.pnlColor17.Tag = "1";
            this.pnlColor17.UseCanvas = false;
            this.pnlColor17.UseHatch = false;
            this.pnlColor17.UseMouseWheelScaling = false;
            // 
            // pnlColor16
            // 
            this.pnlColor16.AutoScroll = true;
            this.pnlColor16.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor16.BackColor = System.Drawing.Color.Black;
            this.pnlColor16.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor16.Centered = false;
            this.pnlColor16.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor16.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor16.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor16.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor16.Image = null;
            this.pnlColor16.ImageAlpha = 1F;
            this.pnlColor16.ImageScale = 1;
            this.pnlColor16.Location = new System.Drawing.Point(4, 4);
            this.pnlColor16.MinimumScale = 1;
            this.pnlColor16.Name = "pnlColor16";
            this.pnlColor16.Selected = false;
            this.pnlColor16.Size = new System.Drawing.Size(32, 32);
            this.pnlColor16.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor16.TabIndex = 4;
            this.pnlColor16.Tag = "0";
            this.pnlColor16.UseCanvas = false;
            this.pnlColor16.UseHatch = false;
            this.pnlColor16.UseMouseWheelScaling = false;
            // 
            // pnlImportPalette
            // 
            this.pnlImportPalette.Controls.Add(this.pnlColor15);
            this.pnlImportPalette.Controls.Add(this.pnlColor14);
            this.pnlImportPalette.Controls.Add(this.pnlColor13);
            this.pnlImportPalette.Controls.Add(this.pnlColor12);
            this.pnlImportPalette.Controls.Add(this.pnlColor11);
            this.pnlImportPalette.Controls.Add(this.pnlColor10);
            this.pnlImportPalette.Controls.Add(this.pnlColor9);
            this.pnlImportPalette.Controls.Add(this.pnlColor8);
            this.pnlImportPalette.Controls.Add(this.pnlColor7);
            this.pnlImportPalette.Controls.Add(this.pnlColor6);
            this.pnlImportPalette.Controls.Add(this.pnlColor5);
            this.pnlImportPalette.Controls.Add(this.pnlColor4);
            this.pnlImportPalette.Controls.Add(this.pnlColor3);
            this.pnlImportPalette.Controls.Add(this.pnlColor2);
            this.pnlImportPalette.Controls.Add(this.pnlColor1);
            this.pnlImportPalette.Controls.Add(this.pnlColor0);
            this.pnlImportPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImportPalette.Location = new System.Drawing.Point(20, 0);
            this.pnlImportPalette.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImportPalette.Name = "pnlImportPalette";
            this.pnlImportPalette.Padding = new System.Windows.Forms.Padding(4);
            this.pnlImportPalette.Size = new System.Drawing.Size(521, 40);
            this.pnlImportPalette.TabIndex = 37;
            // 
            // pnlColor15
            // 
            this.pnlColor15.AutoScroll = true;
            this.pnlColor15.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor15.BackColor = System.Drawing.Color.Black;
            this.pnlColor15.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor15.Centered = false;
            this.pnlColor15.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor15.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor15.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor15.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor15.Image = null;
            this.pnlColor15.ImageAlpha = 1F;
            this.pnlColor15.ImageScale = 1;
            this.pnlColor15.Location = new System.Drawing.Point(484, 4);
            this.pnlColor15.MinimumScale = 1;
            this.pnlColor15.Name = "pnlColor15";
            this.pnlColor15.Selected = false;
            this.pnlColor15.Size = new System.Drawing.Size(32, 32);
            this.pnlColor15.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor15.TabIndex = 20;
            this.pnlColor15.Tag = "15";
            this.pnlColor15.UseCanvas = false;
            this.pnlColor15.UseHatch = false;
            this.pnlColor15.UseMouseWheelScaling = false;
            this.pnlColor15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor14
            // 
            this.pnlColor14.AutoScroll = true;
            this.pnlColor14.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor14.BackColor = System.Drawing.Color.Black;
            this.pnlColor14.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor14.Centered = false;
            this.pnlColor14.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor14.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor14.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor14.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor14.Image = null;
            this.pnlColor14.ImageAlpha = 1F;
            this.pnlColor14.ImageScale = 1;
            this.pnlColor14.Location = new System.Drawing.Point(452, 4);
            this.pnlColor14.MinimumScale = 1;
            this.pnlColor14.Name = "pnlColor14";
            this.pnlColor14.Selected = false;
            this.pnlColor14.Size = new System.Drawing.Size(32, 32);
            this.pnlColor14.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor14.TabIndex = 6;
            this.pnlColor14.Tag = "14";
            this.pnlColor14.UseCanvas = false;
            this.pnlColor14.UseHatch = false;
            this.pnlColor14.UseMouseWheelScaling = false;
            this.pnlColor14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor13
            // 
            this.pnlColor13.AutoScroll = true;
            this.pnlColor13.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor13.BackColor = System.Drawing.Color.Black;
            this.pnlColor13.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor13.Centered = false;
            this.pnlColor13.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor13.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor13.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor13.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor13.Image = null;
            this.pnlColor13.ImageAlpha = 1F;
            this.pnlColor13.ImageScale = 1;
            this.pnlColor13.Location = new System.Drawing.Point(420, 4);
            this.pnlColor13.MinimumScale = 1;
            this.pnlColor13.Name = "pnlColor13";
            this.pnlColor13.Selected = false;
            this.pnlColor13.Size = new System.Drawing.Size(32, 32);
            this.pnlColor13.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor13.TabIndex = 22;
            this.pnlColor13.Tag = "13";
            this.pnlColor13.UseCanvas = false;
            this.pnlColor13.UseHatch = false;
            this.pnlColor13.UseMouseWheelScaling = false;
            this.pnlColor13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor12
            // 
            this.pnlColor12.AutoScroll = true;
            this.pnlColor12.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor12.BackColor = System.Drawing.Color.Black;
            this.pnlColor12.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor12.Centered = false;
            this.pnlColor12.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor12.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor12.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor12.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor12.Image = null;
            this.pnlColor12.ImageAlpha = 1F;
            this.pnlColor12.ImageScale = 1;
            this.pnlColor12.Location = new System.Drawing.Point(388, 4);
            this.pnlColor12.MinimumScale = 1;
            this.pnlColor12.Name = "pnlColor12";
            this.pnlColor12.Selected = false;
            this.pnlColor12.Size = new System.Drawing.Size(32, 32);
            this.pnlColor12.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor12.TabIndex = 23;
            this.pnlColor12.Tag = "12";
            this.pnlColor12.UseCanvas = false;
            this.pnlColor12.UseHatch = false;
            this.pnlColor12.UseMouseWheelScaling = false;
            this.pnlColor12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor11
            // 
            this.pnlColor11.AutoScroll = true;
            this.pnlColor11.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor11.BackColor = System.Drawing.Color.Black;
            this.pnlColor11.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor11.Centered = false;
            this.pnlColor11.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor11.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor11.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor11.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor11.Image = null;
            this.pnlColor11.ImageAlpha = 1F;
            this.pnlColor11.ImageScale = 1;
            this.pnlColor11.Location = new System.Drawing.Point(356, 4);
            this.pnlColor11.MinimumScale = 1;
            this.pnlColor11.Name = "pnlColor11";
            this.pnlColor11.Selected = false;
            this.pnlColor11.Size = new System.Drawing.Size(32, 32);
            this.pnlColor11.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor11.TabIndex = 24;
            this.pnlColor11.Tag = "11";
            this.pnlColor11.UseCanvas = false;
            this.pnlColor11.UseHatch = false;
            this.pnlColor11.UseMouseWheelScaling = false;
            this.pnlColor11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor10
            // 
            this.pnlColor10.AutoScroll = true;
            this.pnlColor10.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor10.BackColor = System.Drawing.Color.Black;
            this.pnlColor10.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor10.Centered = false;
            this.pnlColor10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor10.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor10.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor10.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor10.Image = null;
            this.pnlColor10.ImageAlpha = 1F;
            this.pnlColor10.ImageScale = 1;
            this.pnlColor10.Location = new System.Drawing.Point(324, 4);
            this.pnlColor10.MinimumScale = 1;
            this.pnlColor10.Name = "pnlColor10";
            this.pnlColor10.Selected = false;
            this.pnlColor10.Size = new System.Drawing.Size(32, 32);
            this.pnlColor10.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor10.TabIndex = 25;
            this.pnlColor10.Tag = "10";
            this.pnlColor10.UseCanvas = false;
            this.pnlColor10.UseHatch = false;
            this.pnlColor10.UseMouseWheelScaling = false;
            this.pnlColor10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor9
            // 
            this.pnlColor9.AutoScroll = true;
            this.pnlColor9.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor9.BackColor = System.Drawing.Color.Black;
            this.pnlColor9.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor9.Centered = false;
            this.pnlColor9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor9.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor9.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor9.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor9.Image = null;
            this.pnlColor9.ImageAlpha = 1F;
            this.pnlColor9.ImageScale = 1;
            this.pnlColor9.Location = new System.Drawing.Point(292, 4);
            this.pnlColor9.MinimumScale = 1;
            this.pnlColor9.Name = "pnlColor9";
            this.pnlColor9.Selected = false;
            this.pnlColor9.Size = new System.Drawing.Size(32, 32);
            this.pnlColor9.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor9.TabIndex = 26;
            this.pnlColor9.Tag = "9";
            this.pnlColor9.UseCanvas = false;
            this.pnlColor9.UseHatch = false;
            this.pnlColor9.UseMouseWheelScaling = false;
            this.pnlColor9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor8
            // 
            this.pnlColor8.AutoScroll = true;
            this.pnlColor8.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor8.BackColor = System.Drawing.Color.Black;
            this.pnlColor8.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor8.Centered = false;
            this.pnlColor8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor8.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor8.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor8.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor8.Image = null;
            this.pnlColor8.ImageAlpha = 1F;
            this.pnlColor8.ImageScale = 1;
            this.pnlColor8.Location = new System.Drawing.Point(260, 4);
            this.pnlColor8.MinimumScale = 1;
            this.pnlColor8.Name = "pnlColor8";
            this.pnlColor8.Selected = false;
            this.pnlColor8.Size = new System.Drawing.Size(32, 32);
            this.pnlColor8.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor8.TabIndex = 27;
            this.pnlColor8.Tag = "8";
            this.pnlColor8.UseCanvas = false;
            this.pnlColor8.UseHatch = false;
            this.pnlColor8.UseMouseWheelScaling = false;
            this.pnlColor8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor7
            // 
            this.pnlColor7.AutoScroll = true;
            this.pnlColor7.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor7.BackColor = System.Drawing.Color.Black;
            this.pnlColor7.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor7.Centered = false;
            this.pnlColor7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor7.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor7.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor7.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor7.Image = null;
            this.pnlColor7.ImageAlpha = 1F;
            this.pnlColor7.ImageScale = 1;
            this.pnlColor7.Location = new System.Drawing.Point(228, 4);
            this.pnlColor7.MinimumScale = 1;
            this.pnlColor7.Name = "pnlColor7";
            this.pnlColor7.Selected = false;
            this.pnlColor7.Size = new System.Drawing.Size(32, 32);
            this.pnlColor7.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor7.TabIndex = 28;
            this.pnlColor7.Tag = "7";
            this.pnlColor7.UseCanvas = false;
            this.pnlColor7.UseHatch = false;
            this.pnlColor7.UseMouseWheelScaling = false;
            this.pnlColor7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor6
            // 
            this.pnlColor6.AutoScroll = true;
            this.pnlColor6.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor6.BackColor = System.Drawing.Color.Black;
            this.pnlColor6.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor6.Centered = false;
            this.pnlColor6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor6.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor6.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor6.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor6.Image = null;
            this.pnlColor6.ImageAlpha = 1F;
            this.pnlColor6.ImageScale = 1;
            this.pnlColor6.Location = new System.Drawing.Point(196, 4);
            this.pnlColor6.MinimumScale = 1;
            this.pnlColor6.Name = "pnlColor6";
            this.pnlColor6.Selected = false;
            this.pnlColor6.Size = new System.Drawing.Size(32, 32);
            this.pnlColor6.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor6.TabIndex = 29;
            this.pnlColor6.Tag = "6";
            this.pnlColor6.UseCanvas = false;
            this.pnlColor6.UseHatch = false;
            this.pnlColor6.UseMouseWheelScaling = false;
            this.pnlColor6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor5
            // 
            this.pnlColor5.AutoScroll = true;
            this.pnlColor5.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor5.BackColor = System.Drawing.Color.Black;
            this.pnlColor5.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor5.Centered = false;
            this.pnlColor5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor5.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor5.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor5.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor5.Image = null;
            this.pnlColor5.ImageAlpha = 1F;
            this.pnlColor5.ImageScale = 1;
            this.pnlColor5.Location = new System.Drawing.Point(164, 4);
            this.pnlColor5.MinimumScale = 1;
            this.pnlColor5.Name = "pnlColor5";
            this.pnlColor5.Selected = false;
            this.pnlColor5.Size = new System.Drawing.Size(32, 32);
            this.pnlColor5.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor5.TabIndex = 30;
            this.pnlColor5.Tag = "5";
            this.pnlColor5.UseCanvas = false;
            this.pnlColor5.UseHatch = false;
            this.pnlColor5.UseMouseWheelScaling = false;
            this.pnlColor5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor4
            // 
            this.pnlColor4.AutoScroll = true;
            this.pnlColor4.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor4.BackColor = System.Drawing.Color.Black;
            this.pnlColor4.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor4.Centered = false;
            this.pnlColor4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor4.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor4.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor4.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor4.Image = null;
            this.pnlColor4.ImageAlpha = 1F;
            this.pnlColor4.ImageScale = 1;
            this.pnlColor4.Location = new System.Drawing.Point(132, 4);
            this.pnlColor4.MinimumScale = 1;
            this.pnlColor4.Name = "pnlColor4";
            this.pnlColor4.Selected = false;
            this.pnlColor4.Size = new System.Drawing.Size(32, 32);
            this.pnlColor4.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor4.TabIndex = 31;
            this.pnlColor4.Tag = "4";
            this.pnlColor4.UseCanvas = false;
            this.pnlColor4.UseHatch = false;
            this.pnlColor4.UseMouseWheelScaling = false;
            this.pnlColor4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor3
            // 
            this.pnlColor3.AutoScroll = true;
            this.pnlColor3.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor3.BackColor = System.Drawing.Color.Black;
            this.pnlColor3.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor3.Centered = false;
            this.pnlColor3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor3.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor3.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor3.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor3.Image = null;
            this.pnlColor3.ImageAlpha = 1F;
            this.pnlColor3.ImageScale = 1;
            this.pnlColor3.Location = new System.Drawing.Point(100, 4);
            this.pnlColor3.MinimumScale = 1;
            this.pnlColor3.Name = "pnlColor3";
            this.pnlColor3.Selected = false;
            this.pnlColor3.Size = new System.Drawing.Size(32, 32);
            this.pnlColor3.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor3.TabIndex = 32;
            this.pnlColor3.Tag = "3";
            this.pnlColor3.UseCanvas = false;
            this.pnlColor3.UseHatch = false;
            this.pnlColor3.UseMouseWheelScaling = false;
            this.pnlColor3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor2
            // 
            this.pnlColor2.AutoScroll = true;
            this.pnlColor2.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor2.BackColor = System.Drawing.Color.Black;
            this.pnlColor2.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor2.Centered = false;
            this.pnlColor2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor2.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor2.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor2.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor2.Image = null;
            this.pnlColor2.ImageAlpha = 1F;
            this.pnlColor2.ImageScale = 1;
            this.pnlColor2.Location = new System.Drawing.Point(68, 4);
            this.pnlColor2.MinimumScale = 1;
            this.pnlColor2.Name = "pnlColor2";
            this.pnlColor2.Selected = false;
            this.pnlColor2.Size = new System.Drawing.Size(32, 32);
            this.pnlColor2.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor2.TabIndex = 33;
            this.pnlColor2.Tag = "2";
            this.pnlColor2.UseCanvas = false;
            this.pnlColor2.UseHatch = false;
            this.pnlColor2.UseMouseWheelScaling = false;
            this.pnlColor2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor1
            // 
            this.pnlColor1.AutoScroll = true;
            this.pnlColor1.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor1.BackColor = System.Drawing.Color.Black;
            this.pnlColor1.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor1.Centered = false;
            this.pnlColor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor1.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor1.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor1.Image = null;
            this.pnlColor1.ImageAlpha = 1F;
            this.pnlColor1.ImageScale = 1;
            this.pnlColor1.Location = new System.Drawing.Point(36, 4);
            this.pnlColor1.MinimumScale = 1;
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Selected = false;
            this.pnlColor1.Size = new System.Drawing.Size(32, 32);
            this.pnlColor1.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor1.TabIndex = 34;
            this.pnlColor1.Tag = "1";
            this.pnlColor1.UseCanvas = false;
            this.pnlColor1.UseHatch = false;
            this.pnlColor1.UseMouseWheelScaling = false;
            this.pnlColor1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // pnlColor0
            // 
            this.pnlColor0.AutoScroll = true;
            this.pnlColor0.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.pnlColor0.BackColor = System.Drawing.Color.Black;
            this.pnlColor0.Canvas = new System.Drawing.Size(8, 8);
            this.pnlColor0.Centered = false;
            this.pnlColor0.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor0.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlColor0.HatchForeColor = System.Drawing.Color.White;
            this.pnlColor0.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlColor0.Image = null;
            this.pnlColor0.ImageAlpha = 1F;
            this.pnlColor0.ImageScale = 1;
            this.pnlColor0.Location = new System.Drawing.Point(4, 4);
            this.pnlColor0.MinimumScale = 1;
            this.pnlColor0.Name = "pnlColor0";
            this.pnlColor0.Selected = false;
            this.pnlColor0.Size = new System.Drawing.Size(32, 32);
            this.pnlColor0.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlColor0.TabIndex = 4;
            this.pnlColor0.Tag = "0";
            this.pnlColor0.UseCanvas = false;
            this.pnlColor0.UseHatch = false;
            this.pnlColor0.UseMouseWheelScaling = false;
            this.pnlColor0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(20, 40);
            this.btnLeft.TabIndex = 38;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.Location = new System.Drawing.Point(541, 0);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(20, 40);
            this.btnRight.TabIndex = 39;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemoveColor,
            this.mnuMoveColor,
            this.mnuCopyColor});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(224, 92);
            // 
            // mnuRemoveColor
            // 
            this.mnuRemoveColor.Name = "mnuRemoveColor";
            this.mnuRemoveColor.Size = new System.Drawing.Size(223, 22);
            this.mnuRemoveColor.Text = "Remove Color";
            this.mnuRemoveColor.Click += new System.EventHandler(this.mnuMain_Click);
            // 
            // mnuMoveColor
            // 
            this.mnuMoveColor.Name = "mnuMoveColor";
            this.mnuMoveColor.Size = new System.Drawing.Size(223, 22);
            this.mnuMoveColor.Text = "Move Color To Other Palette";
            this.mnuMoveColor.Click += new System.EventHandler(this.mnuMain_Click);
            // 
            // mnuCopyColor
            // 
            this.mnuCopyColor.Name = "mnuCopyColor";
            this.mnuCopyColor.Size = new System.Drawing.Size(223, 22);
            this.mnuCopyColor.Text = "Copy Color To Other Palette";
            this.mnuCopyColor.Click += new System.EventHandler(this.mnuMain_Click);
            // 
            // ColorEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Name = "ColorEditControl";
            this.Size = new System.Drawing.Size(561, 80);
            this.tpnlMain.ResumeLayout(false);
            this.pnlTargetPalette.ResumeLayout(false);
            this.pnlImportPalette.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ColorControl pnlColor0;
        private ColorControl pnlColor1;
        private ColorControl pnlColor2;
        private ColorControl pnlColor3;
        private ColorControl pnlColor4;
        private ColorControl pnlColor5;
        private ColorControl pnlColor6;
        private ColorControl pnlColor7;
        private ColorControl pnlColor8;
        private ColorControl pnlColor9;
        private ColorControl pnlColor10;
        private ColorControl pnlColor11;
        private ColorControl pnlColor12;
        private ColorControl pnlColor13;
        private ColorControl pnlColor14;
        private ColorControl pnlColor15;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Panel pnlImportPalette;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel pnlTargetPalette;
        private ColorControl pnlColor31;
        private ColorControl pnlColor30;
        private ColorControl pnlColor29;
        private ColorControl pnlColor28;
        private ColorControl pnlColor27;
        private ColorControl pnlColor26;
        private ColorControl pnlColor25;
        private ColorControl pnlColor24;
        private ColorControl pnlColor23;
        private ColorControl pnlColor22;
        private ColorControl pnlColor21;
        private ColorControl pnlColor20;
        private ColorControl pnlColor19;
        private ColorControl pnlColor18;
        private ColorControl pnlColor17;
        private ColorControl pnlColor16;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.ContextMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveColor;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveColor;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyColor;
    }
}
