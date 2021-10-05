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
using System.Collections.Generic;
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class TileControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event PixelChangedHandler PixelChanged;
        public delegate void PixelChangedHandler();
        private List<byte> _pixels = new List<byte>();
        private List<Color> _palette = new List<Color>();
        private Rectangle _selection = new Rectangle();
        private byte _targetColor = 255;

        /// <summary>
        /// Properties
        /// </summary>
        public List<byte> Pixels { get { return _pixels; } set { _pixels = value; UpdateBackBuffer(); } }
        public List<Color> Palette { get { return _palette; } set { _palette = value; UpdateBackBuffer(); } }
        public int SelectedTileID { get; set; }
        public byte SelectedColor { get; set; } = 255;
        public byte TargetColor { get { return _targetColor; } set { _targetColor = value; if (value == 255) { _selection = Rectangle.Empty; } UpdateBackBuffer(); } }

        /// <summary>
        /// 
        /// </summary>
        public TileControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (_pixels == null || _pixels.Count <= 0)
                return;

            DrawSelection(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || _pixels.Count <= 0)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            Size snap = new Size(ClientSize.Width / SnapSize.Width, ClientSize.Height / SnapSize.Height);
            int x = (e.Location.X - rect.X) / ImageScale / snap.Width * snap.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / snap.Height * snap.Height;
            int col = (int)Math.Floor((double)x / snap.Width);
            int row = (int)Math.Floor((double)y / snap.Height);
            int index = (row * 8) + col;
            if (index >= _pixels.Count)
                return;

            if (e.Button == MouseButtons.Left && SelectedColor <= _palette.Count - 1)
            {
                _pixels[index] = SelectedColor;
                PixelChanged?.Invoke();
            }

            _selection = new Rectangle(new Point(x, y), snap);
            TargetColor = _pixels[index];
            UpdateBackBuffer();
        }

        /// <summary>
        /// Draws tile indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (_pixels.Count <= 0)
                return;

            int index = 0;
            Size snap = new Size(ClientSize.Width / 8, ClientSize.Height / 8);
            Font font = new Font(Font.Name, 7 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (index < _pixels.Count)
                    {
                        Point point = new Point((col * snap.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * snap.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y + 1, (snap.Width + 1) * ImageScale, (snap.Height + 1) * ImageScale);
                        BitmapUtility.DrawTextOutline(gfx, _pixels[index].ToString(), font, Brushes.Black, rect, format);
                        gfx.DrawString(_pixels[index].ToString(), font, Brushes.White, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Draws the selected tile rectangle
        /// </summary>
        private void DrawSelection(Graphics gfx, Point origin)
        {
            if (_selection == Rectangle.Empty)
                return;

            using (Pen pen = new Pen(Color.White, 1))
            {
                Rectangle rect = _selection;
                rect.X += origin.X;
                rect.Y += origin.Y;
                gfx.DrawRectangle(Pens.Black, rect);
                rect.Inflate(-1, -1);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Clear control
        /// </summary>
        public void Clear()
        {
            Image = null;
            _pixels.Clear();
            _palette.Clear();
            _selection = Rectangle.Empty;
            SelectedColor = 255;
            TargetColor = 255;
            UpdateBackBuffer();
        }

        /// <summary>
        /// Update tile with given clors
        /// </summary>
        /// <param name="palette">Color palette</param>
        public void UpdateImage(List<Color> palette)
        {
            if (Pixels == null || Pixels.Count <= 0)
                return;

            Palette = palette;
            Image = BitmapUtility.GetPixelTileImage(Pixels, Palette, ClientSize);
        }
    }
}