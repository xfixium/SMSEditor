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
using SMSEditor.Data;

namespace SMSEditor.Controls
{
    public partial class TilesControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileSelectionHandler TileSelectionChanged;
        public delegate void TileSelectionHandler();
        private Rectangle _selection = new Rectangle();
        private Timer _antsTimer = new Timer();
        private int _antOffset = 0;
        private bool _useGrid = true;
        private int _tileID = 0;
        private bool _indexed = false;

        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get { return _tileID; } set { _tileID = value; } }
        public int TileCount { get; set; }
        public int Offset { get; set; }
        public bool UseOffset { get; set; }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool AllowSelection { get; set; } = true;
        public bool Indexed
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                ImageAlpha = _indexed ? 0.5F : 1F;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public TilesControl()
        {
            InitializeComponent();
            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            DrawGrid(gfx);
            DrawSelection(gfx);
        }

        /// <summary>
        /// On image set
        /// </summary>
        /// <param name="image">Image reference</param>
        protected override void OnImageSet(ref Bitmap image)
        {
            _selection = new Rectangle(Point.Empty, SnapSize);
            _tileID = 0;
            UpdateBackBuffer();
            AutoScrollPosition = Point.Empty;
        }

        /// <summary>
        /// Mouse down override
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || !AllowSelection)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            Point snap = GetSnappedPoint(e.Location);
            if (new Rectangle(0, 0, Image.Width, Image.Height).Contains(snap) == false)
                return;

            int cols = Image.Width / SnapSize.Width;
            int col = snap.X / SnapSize.Width;
            int row = snap.Y / SnapSize.Height;
            int tileID = (row * cols) + col;
            if (tileID >= TileCount)
                return;

            _selection = new Rectangle(snap, SnapSize);
            _tileID = tileID;
            TileSelectionChanged?.Invoke();
        }

        /// <summary>
        /// Draws a selection rectangle
        /// </summary>
        private void DrawSelection(Graphics gfx)
        {
            if (Image == null || !AllowSelection)
                return;

            using (Pen pen = new Pen(Color.White, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 4, 4 };
                pen.DashOffset = _antOffset;
                Rectangle rect = _selection;
                gfx.DrawRectangle(Pens.Black, rect);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Draws a grid based on grid size
        /// </summary>
        private void DrawGrid(Graphics gfx)
        {
            if (!UseGrid || Image == null)
                return;

            int cols = (int)Math.Floor(Image.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Floor(Image.Height / (double)(SnapSize.Height));
            Rectangle cell = new Rectangle(0, 0, SnapSize.Width, SnapSize.Height);
            using (Pen gridPen = new Pen(Color.FromArgb(80, Color.Black)))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        cell.X = col * SnapSize.Width;
                        cell.Y = row * SnapSize.Height;
                        gfx.DrawRectangle(gridPen, cell);
                    }
                }
            }
        }

        /// <summary>
        /// Draws tile indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (!Indexed || Image == null)
                return;

            int index = 0;
            int cols = Image.Width / SnapSize.Width;
            int rows = Image.Height / SnapSize.Height;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (index >= TileCount)
                        continue;
                    Point point = new Point((col * SnapSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                    RectangleF rect = new RectangleF(point.X, point.Y, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                    BitmapUtility.DrawTextOutline(gfx, (index + (UseOffset ? Offset : 0)).ToString(), font, Brushes.Black, rect, format);
                    gfx.DrawString((index + (UseOffset ? Offset : 0)).ToString(), font, Brushes.White, rect, format);

                    index++;
                }
            }
        }

        /// <summary>
        /// Marching ants timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _antOffset++;

            if (_antOffset % 8 == 0)
                _antOffset = 0;

            if (_selection != Rectangle.Empty)
                UpdateBackBuffer();
        }
    }
}