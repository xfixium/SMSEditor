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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class ListBoxControl : ListBox
    {
        /// <summary>
        /// Win32
        /// </summary>
        public const int SIF_TRACKPOS = 0x10;
        public const int SIF_RANGE = 0x1;
        public const int SIF_POS = 0x4;
        public const int SIF_PAGE = 0x2;
        public const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;
        public const int WM_NCPAINT = 0x85;

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetScrollInfo(IntPtr hWnd, int n, ref ScrollInfoStruct lpScrollInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct ScrollInfoStruct
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        /// <summary>
        /// Fields
        /// </summary>
        private int _offsetX = 0;
        private int _textOffsetX = 2;
        private int _textOffsetY = 0;
        private bool _disableHighlighting = false;

        /// <summary>
        /// Properties
        /// </summary>
        public int TextOffsetX { get { return _textOffsetX; } set { _textOffsetX = value; Invalidate(); } }
        public int TextOffsetY { get { return _textOffsetY; } set { _textOffsetY = value; Invalidate(); } }
        public bool DisableHighlighting { get { return _disableHighlighting; } set { _disableHighlighting = value; Invalidate(); } }

        /// <summary>
        /// Constructors
        /// </summary>
        public ListBoxControl()
        {
            InitializeComponent();

            DrawMode = DrawMode.OwnerDrawFixed;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Opaque, true);
        }

        /// <summary>
        /// On paint
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.None;
            e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.Default;

            int item = 0;
            int index = IndexFromPoint(0, 0);
            int count = (int)Math.Ceiling((double)ClientSize.Height / (double)this.ItemHeight) + index;

            count = count > this.Items.Count ? this.Items.Count : count;
            if (Items.Count > 0)
            {
                for (int i = index; i < count; i++)
                {
                    Font font = Font;
                    Rectangle bounds = new Rectangle(0 - _offsetX, item * this.ItemHeight, HorizontalExtent, this.ItemHeight);
                    if (Items[index] is GameAsset)
                    {
                        GameAsset asset = Items[index] as GameAsset;
                        if (asset.StatusType != StatusType.Good)
                        {
                            font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        }
                    }

                    DrawItemOptimized(new DrawItemEventArgs(e.Graphics, font, bounds, i, SelectedItems.Contains(Items[i]) && Enabled ? DrawItemState.Selected : DrawItemState.None));
                    item++;
                }
            }
            else
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
                e.Graphics.SmoothingMode = SmoothingMode.Default;
            }
        }

        /// <summary>
        /// On draw item
        /// </summary>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Do nothing, will flicker if used
        }

        /// <summary>
        /// On paint background
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do nothing, will flicker if used
        }

        /// <summary>
        /// On measure item
        /// </summary>
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            SetMaxWidth(e.Graphics);
        }

        /// <summary>
        /// Override window messages
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x114:
                    ScrollInfoStruct si = new ScrollInfoStruct();
                    si.fMask = SIF_ALL;
                    si.cbSize = Marshal.SizeOf(si);
                    GetScrollInfo(m.HWnd, 0, ref si);
                    _offsetX = si.nTrackPos;
                    break;

                case 0x85:
                    base.WndProc(ref m);

                    IntPtr hDC = GetWindowDC(m.HWnd);
                    bool drawFocus = ClientRectangle.Contains(PointToClient(Cursor.Position));
                    Pen border = new Pen(Color.FromArgb(171, 173, 179));

                    using (Graphics g = Graphics.FromHdc(hDC))
                    {
                        g.DrawRectangle(border, new Rectangle(0, 0, Width - 1, Height - 1));
                        g.DrawRectangle(SystemPens.Window, new Rectangle(1, 1, Width - 3, Height - 3));
                    }

                    ReleaseDC(m.HWnd, hDC);
                    border.Dispose();
                    break;

                default: base.WndProc(ref m); break;
            }
        }

        /// <summary>
        /// On key press
        /// </summary>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            Invalidate();
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (SelectionMode != SelectionMode.One)
                return;

            int index = IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right && IndexFromPoint(e.Location) != -1)
                SelectedIndex = index;

            Invalidate();
        }

        /// <summary>
        /// On mouse up
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Extra invalidation for multi select mode
            if (SelectionMode == SelectionMode.MultiExtended)
                Invalidate();
        }

        /// <summary>
        /// On size changed
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetMaxWidth(CreateGraphics());
            Invalidate();
        }

        /// <summary>
        /// Virtual method to render dynamic glyphs
        /// </summary>
        /// <param name="e">Draw item event arguments</param>
        public virtual Font OnGetFont(DrawItemEventArgs e)
        {
            Font font = Font;
            if (!_disableHighlighting && Items[e.Index] is GameAsset)
            {
                GameAsset asset = Items[e.Index] as GameAsset;
                font = asset.StatusType == StatusType.Good ? font : new Font(font.FontFamily, font.Size, FontStyle.Bold);
            }
            return font;
        }

        /// <summary>
        /// Virtual method to get dynamic string
        /// </summary>
        /// <param name="e">Draw item event arguments</param>
        public virtual string OnGetText(DrawItemEventArgs e)
        {
            return DisplayMember == "" ? Items[e.Index].ToString() : Items[e.Index].GetType().GetProperty(DisplayMember).GetValue(Items[e.Index], null).ToString();
        }

        /// <summary>
        /// Virtual method to render dynamic selected item drawing
        /// </summary>
        /// <param name="e">The draw item event arguments</param>
        /// <param name="font">The font to draw with</param>
        /// <param name="text">The text to draw</param>
        public virtual void OnDrawSelected(DrawItemEventArgs e, Font font, Rectangle rect, Color textForeColor, string text)
        {
            e.Graphics.SmoothingMode = SmoothingMode.None;
            e.Graphics.FillRectangle(SystemBrushes.Highlight, rect);
            e.Graphics.DrawRectangle(SystemPens.HotTrack, rect);
            e.Graphics.SmoothingMode = SmoothingMode.Default;

            StringAlignment alignment = StringAlignment.Near;
            TextFormatFlags position = alignment == StringAlignment.Near ? TextFormatFlags.Left : alignment == StringAlignment.Center ? TextFormatFlags.HorizontalCenter : TextFormatFlags.Right;
            TextFormatFlags flags = TextFormatFlags.WordEllipsis | TextFormatFlags.VerticalCenter | position;
            TextRenderer.DrawText(e.Graphics, text, font, rect, textForeColor, flags);
        }

        /// <summary>
        /// Virtual method to render dynamic selected item drawing
        /// </summary>
        /// <param name="e">The draw item event arguments</param>
        /// <param name="font">The font to draw with</param>
        /// <param name="rect">The drawing bounds</param>
        /// <param name="text">The text to draw</param>
        public virtual void OnDrawText(DrawItemEventArgs e, Font font, Rectangle rect, Color textForeColor, string text)
        {
            StringAlignment alignment = StringAlignment.Near;
            TextFormatFlags position = alignment == StringAlignment.Near ? TextFormatFlags.Left : alignment == StringAlignment.Center ? TextFormatFlags.HorizontalCenter : TextFormatFlags.Right;
            TextFormatFlags flags = TextFormatFlags.WordEllipsis | TextFormatFlags.VerticalCenter | position;
            TextRenderer.DrawText(e.Graphics, text, font, rect, textForeColor, flags);
        }

        /// <summary>
        /// Virtual method for text color
        /// </summary>
        /// <param name="e">The draw item event arguments</param>
        public virtual Color OnGetTextForeColor(DrawItemEventArgs e)
        {
            Color color = ForeColor;
            if (!_disableHighlighting && Items[e.Index] is GameAsset)
            {
                GameAsset asset = Items[e.Index] as GameAsset;
                color = asset.StatusType == StatusType.Good ? color : asset.StatusType == StatusType.Disabled ? Color.DarkGray : Color.Red;
            }

            return color;
        }

        /// <summary>
        /// Sets the maximum item width for horizontal scrolling, based on the current items
        /// </summary>
        /// <param name="gfx">The graphics object to measure the item strings with</param>
        private void SetMaxWidth(Graphics gfx)
        {
            int width = 0;
            int maxWidth = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                DrawItemEventArgs args = new DrawItemEventArgs(gfx, Font, Rectangle.Empty, i, DrawItemState.None);
                width = (int)gfx.MeasureString(OnGetText(args), Font).Width + _textOffsetX;
                if (width > maxWidth)
                    maxWidth = width;
            }

            if (maxWidth < ClientSize.Width)
            {
                maxWidth = ClientSize.Width;
                _offsetX = 0;
            }

            HorizontalExtent = maxWidth;
        }

        /// <summary>
        /// Custom draw item
        /// </summary>
        private void DrawItemOptimized(DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            
            string text = OnGetText(e);
            Color textForeColor = OnGetTextForeColor(e);
            Font font = OnGetFont(e);

            Rectangle textRect = e.Bounds;
            textRect.X = _textOffsetX;
            textRect.Y = e.Bounds.Y + _textOffsetY;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                OnDrawSelected(e, font, textRect, SystemColors.Window, text);
            else
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
                e.Graphics.SmoothingMode = SmoothingMode.Default;
                OnDrawText(e, font, textRect, textForeColor, text);
            }
        }
    }
}
