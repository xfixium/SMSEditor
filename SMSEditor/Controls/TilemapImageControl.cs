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
using System.Collections.Generic;

namespace SMSEditor.Controls
{
    public partial class TilemapImageControl : ImageControl
    {
        private int _index = 0;
        private int _antOffset = 0;
        private Timer _antsTimer = new Timer();
        private List<Rectangle> _frames = new List<Rectangle>();

        public int Index { get { return _index; } set { _index = value; UpdateBackBuffer(); } }
        public Point FrameLocation { get { return new Point(_frames[_index].X / 8, _frames[_index].Y / 8); } }
        public Size FrameSize { get { return new Size(_frames[_index].Width / 8, _frames[_index].Height / 8); } }
        public int FrameCount { get { return _frames.Count; } }
        public List<Rectangle> Frames { get { return _frames; } set { _frames = value; UpdateBackBuffer(); } }

        public TilemapImageControl()
        {
            InitializeComponent();
            _frames.Add(new Rectangle(0, 0, 8, 8));
            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null || _frames.Count <= 0)
                return;

            DrawFrames(gfx, origin);
        }

        /// <summary>
        /// Marching ants timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _antOffset++;

            if (_antOffset % 8 == 0)
                _antOffset = 0;

            if (_frames.Count > 0)
                UpdateBackBuffer();
        }

        /// <summary>
        /// Draws the selected tiles rectangles
        /// </summary>
        private void DrawFrames(Graphics gfx, Point origin)
        {
            foreach (Rectangle frame in _frames)
            {
                Rectangle rect = new Rectangle(frame.X + origin.X, frame.Y + origin.Y, frame.Width, frame.Height);
                gfx.DrawRectangle(Pens.Black, rect);
                rect.Inflate(-1, -1);
                gfx.DrawRectangle(Pens.White, rect);
            }
            using (Pen framePen = new Pen(Color.White, 1))
            {
                using (Pen dashPen = new Pen(Color.White, 1))
                {
                    dashPen.DashStyle = DashStyle.Dash;
                    dashPen.DashPattern = new float[2] { 4, 4 };
                    dashPen.DashOffset = _antOffset;
                    Rectangle selected = _frames[_index]; // Rectangle.Empty;
                    selected.X += origin.X;
                    selected.Y += origin.Y;
                    gfx.DrawRectangle(Pens.Black, selected);
                    gfx.DrawRectangle(dashPen, selected);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        public void SetFramePosition(int col, int row)
        {
            if (!ValidIndex())
                return;

            Rectangle rect = _frames[_index];
            rect.X = col == -1 ? rect.X : col * 8;
            rect.Y = row == -1 ? rect.Y : row * 8;
            _frames[_index] = rect;
            UpdateBackBuffer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public void SetFrameSize(int cols, int rows)
        {
            if (!ValidIndex())
                return;

            Rectangle rect = _frames[_index];
            rect.Width = cols == -1 ? rect.Width : cols * 8;
            rect.Height = rows == -1 ? rect.Height : rows * 8;
            _frames[_index] = rect;
            UpdateBackBuffer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidIndex()
        {
            return Image != null && _index < _frames.Count && _frames.Count > 0 && _index >= 0;
        }
    }
}
