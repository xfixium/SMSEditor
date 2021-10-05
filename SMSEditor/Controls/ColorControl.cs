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

namespace SMSEditor.Controls
{
    public partial class ColorControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Bitmap _checker;
        private Timer _timer = new Timer();
        private bool _selected = false;
        private bool _blink = false;
        private int _timerCount = 0;

        /// <summary>
        /// Properties
        /// </summary>
        public bool Selected { get { return _selected; } set { _selected = value; _timerCount = 0; if (_selected) _timer.Start(); else _timer.Stop(); UpdateBackBuffer(); } }

        public ColorControl()
        {
            InitializeComponent();
            _timer.Interval = 20;
            _timer.Tick += new EventHandler(Timer_Tick);
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (_checker == null)
                CreateChecker();

            using (TextureBrush tbrush = new TextureBrush(_checker))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    Rectangle rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
                    gfx.FillRectangle(tbrush, rect);
                    gfx.DrawRectangle(_selected && !_blink ? Pens.Red : Pens.Black, rect);
                    rect.Inflate(-1, -1);
                    gfx.DrawRectangle(_selected && !_blink ? Pens.Red : Pens.White, rect);
                    rect.X += 1;
                    rect.Y += 1;
                    rect.Width -= 1;
                    rect.Height -= 1;
                    gfx.FillRectangle(brush, rect);
                }
            }
        }

        /// <summary>
        /// Creates a checker texture
        /// </summary>
        private void CreateChecker()
        {
            _checker = new Bitmap(16, 16);
            using (Graphics gfx = Graphics.FromImage(_checker))
            {
                gfx.FillRectangle(Brushes.DarkGray, 0, 0, 8, 8);
                gfx.FillRectangle(Brushes.White, 8, 0, 8, 8);
                gfx.FillRectangle(Brushes.White, 0, 8, 8, 8);
                gfx.FillRectangle(Brushes.DarkGray, 8, 8, 8, 8);
            }
        }

        /// <summary>
        /// Selection blink timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timerCount++;

            if (_timerCount % 8 == 0 && _selected)
            {
                _blink = !_blink;
                _timerCount = 0;
                UpdateBackBuffer();
            }
        }
    }
}
