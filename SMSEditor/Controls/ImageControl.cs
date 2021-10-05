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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace SMSEditor.Controls
{
    public partial class ImageControl : Panel
    {
        public event ScaleChangedHandler ScaleChanged;
        public delegate void ScaleChangedHandler(object sender);
        private Bitmap _image = null;
        private Size _canvas = new Size(8, 8);
        private Size _snapSize = new Size(8, 8);
        private int _scale = 1;
        private bool _centered = false;
        private bool _useHatch = false;
        private HatchStyle _hatchStyle = HatchStyle.OutlinedDiamond;
        private Color _hatchForeColor = Color.White;
        private Color _hatchBackColor = Color.DarkGray;

        /// <summary>
        /// Gets the backbuffer
        /// </summary>
        public Bitmap BackBuffer { get; private set; } = null;

        /// <summary>
        /// Image to draw, cached to a backbuffer to reduce flickering and offer smooth scrolling
        /// </summary>
        public virtual Bitmap Image
        {
            get { return _image; }
            set
            {
                if (_image != null)
                    _image.Dispose();

                _image = value;

                // If there is an image, set the correct resolution
                if (_image != null)
                {
                    // Create graphics to ensure the proper dpi is used
                    Graphics gfx = CreateGraphics();
                    _image.SetResolution(gfx.DpiX, gfx.DpiY);
                    _canvas = _image.Size;
                    gfx.Dispose();
                    OnImageSet(ref _image);
                }

                // Update
                UpdateBackBuffer();
            }
        }


        /// <summary>
        /// Back color of the control
        /// </summary>
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Fore color of the control
        /// </summary>
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// The scale amount to draw the image
        /// </summary>
        public int ImageScale
        {
            get { return _scale; }
            set { _scale = value < 1 ? 1 : value > 10 ? 10 : value; OnImageScaleChanged(); UpdateBackBuffer(); }
        }

        /// <summary>
        /// The vertical scrollbar incrememnt
        /// </summary>
        public int VScrollIncrememnt
        {
            set { VerticalScroll.SmallChange = value * ImageScale; VerticalScroll.LargeChange = value * ImageScale; }
        }

        /// <summary>
        /// If centering the image within the control, or drawing at top-left corner
        /// </summary>
        public bool Centered
        {
            get { return _centered; }
            set { _centered = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// If using a hatch pattern for the background of the control
        /// </summary>
        public bool UseHatch
        {
            get { return _useHatch; }
            set { _useHatch = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// If using a hartch pattern for the background of the control
        /// </summary>
        public bool UseMouseWheelScaling { get; set; } = false;

        /// <summary>
        /// The hatch pattern style, if hatch background enabled
        /// </summary>
        public HatchStyle HatchStyle
        {
            get { return _hatchStyle; }
            set { _hatchStyle = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// The fore color of the hatch pattern, if hatch background enabled
        /// </summary>
        public Color HatchForeColor
        {
            get { return _hatchForeColor; }
            set { _hatchForeColor = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// The back color of the hatch pattern, if hatch background enabled
        /// </summary>
        public Color HatchBackColor
        {
            get { return _hatchBackColor; }
            set { _hatchBackColor = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// Gets or sets the snap to cell size
        /// </summary>
        public Size SnapSize
        {
            get { return _snapSize; }
            set { _snapSize = value; }
        }

        /// <summary>
        /// Set the canvas size if free drawing to the backbuffer without using the image
        /// </summary>
        public bool UseCanvas { get; set; } = false;

        /// <summary>
        /// Gets or sets the canvas size
        /// </summary>
        public Size Canvas
        {
            get { return _canvas; }
            set { _canvas = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// Gets or sets the minimum scale value
        /// </summary>
        public int MinimumScale { get; set; } = 1;

        /// <summary>
        /// Gets or sets the backbuffer transparency value
        /// </summary>
        public float ImageAlpha { get; set; } = 1F;

        /// <summary>
        /// Constructors
        /// </summary>
        public ImageControl()
        {
            InitializeComponent();

            AutoScroll = true;
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, true);
            UpdateBackBuffer();
        }

        /// <summary>
        /// On control paint
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!Enabled || BackBuffer == null)
            {
                e.Graphics.FillRectangle(SystemBrushes.ControlDark, ClientRectangle);
                return;
            }

            Rectangle src = new Rectangle(0, 0, BackBuffer.Width, BackBuffer.Height);
            using (Bitmap image = BackBuffer.Clone(src, BackBuffer.PixelFormat))
            {
                Point srcPoint = GetTranslatePoint(Point.Empty);
                Size size = UseCanvas && _canvas != Size.Empty ? _canvas : _image != null ? _image.Size : BackBuffer.Size;
                AutoScrollMinSize = new Size(size.Width * _scale, size.Height * _scale);
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.ScaleTransform(_scale, _scale);
                e.Graphics.DrawImage(image, ClientRectangle, srcPoint.X, srcPoint.Y, ClientSize.Width, ClientSize.Height, GraphicsUnit.Pixel);
                e.Graphics.ResetTransform();
                OnDrawAfterOnPaint(ref e);
            }
        }

        /// <summary>
        /// On client size changed
        /// </summary>
        protected override void OnClientSizeChanged(EventArgs e)
        {
            UpdateBackBuffer();
        }

        /// <summary>
        /// On scroll
        /// </summary>
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);
            Invalidate();
        }

        /// <summary>
        /// On mouse wheel
        /// </summary>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (UseMouseWheelScaling)
            {
                if (e.Delta < 0)
                    ImageScale--;
                else
                    ImageScale++;

                if (ImageScale < MinimumScale)
                    ImageScale = MinimumScale;

                ScaleChanged?.Invoke(this);
            }
            else
                base.OnMouseWheel(e);
        }

        /// <summary>
        /// On enter
        /// </summary>
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            // Allows for wheel scrolling
            Focus();
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Allows for wheel scrolling
            Focus();
        }

        /// <summary>
        /// Place for user code to call a method after the image has been set
        /// </summary>
        /// <param name="image">A reference of the original image</param>
        protected virtual void OnImageSet(ref Bitmap image)
        {
            // User method OnImageSet
        }

        /// <summary>
        /// Draw after on paint method
        /// </summary>
        protected virtual void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            // On draw after on paint
        }

        /// <summary>
        /// Place for user code to on after draw backbuffer method
        /// </summary>
        protected virtual void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            // User method OnBackbuffer
        }

        /// <summary>
        /// Place for user code to call a method after the image scale has been set
        /// </summary>
        protected virtual void OnImageScaleChanged()
        {
            // User method OnImageScaleChanged
        }

        /// <summary>
        /// Updates the backbuffer
        /// </summary>
        public void UpdateBackBuffer()
        {
            if (BackBuffer != null)
                BackBuffer.Dispose();

            Size size = GetSize();
            BackBuffer = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
            Graphics gfx = Graphics.FromImage(BackBuffer);
            gfx.Clear(BackColor);
            if (_useHatch)
            {
                using (HatchBrush brush = new HatchBrush(_hatchStyle, _hatchForeColor, _hatchBackColor))
                {
                    gfx.FillRectangle(brush, new Rectangle(Point.Empty, size));
                }
            }

            Point origin = GetOrigin();
            if (_image != null && !UseCanvas)
                gfx.DrawImage(ImageAlpha != 1 ? BitmapTransparency(_image, ImageAlpha) : _image, origin);

            OnAfterDrawOnBackbuffer(ref gfx, ref origin);

            if (gfx != null)
                gfx.Dispose();

            // Flip to screen
            Invalidate();
        }

        /// <summary>
        /// Gets the image origin point for centering primarily
        /// </summary>
        /// <returns>Image origin position</returns>
        public Point GetOrigin()
        {
            Size size = UseCanvas ? _canvas : _image == null ? new Size(1, 1) : _image.Size;
            int xOffset = ((size.Width * _scale) / 2) + _scale > 1 ? (size.Width / 2) : 0;
            int yOffset = ((size.Height * _scale) / 2) + _scale > 1 ? (size.Height / 2) : 0;
            int x = ((ClientSize.Width / _scale) / 2) - xOffset;
            int y = ((ClientSize.Height / _scale) / 2) - yOffset;
            return !_centered ? Point.Empty : new Point(size.Width * _scale > ClientSize.Width ? 0 : x, size.Height * _scale > ClientSize.Height ? 0 : y);
        }

        /// <summary>
        /// Translates a point with scaling and scrolling values considered
        /// </summary>
        /// <param name="point">Point to translate</param>
        /// <returns>A Translated point</returns>
        public Point GetTranslatePoint(Point point)
        {
            return new Point((point.X - AutoScrollPosition.X) / (_scale == 0 ? 1 : _scale), (point.Y - AutoScrollPosition.Y) / (_scale == 0 ? 1 : _scale));
        }

        /// <summary>
        /// Calculates a snapped version of a point
        /// </summary>
        /// <param name="position">The point to calculate</param>
        /// <returns>A snapped point</returns>
        public Point GetSnappedPoint(Point position)
        {
            int width = _snapSize.Width * _scale;
            int height = _snapSize.Height * _scale;
            int x = (position.X - AutoScrollPosition.X) / width * width / _scale;
            int y = (position.Y - AutoScrollPosition.Y) / height * height / _scale;
            return new Point(x, y);
        }

        /// <summary>
        /// Gets a snapped size, for transformed size
        /// </summary>
        /// <param name="size">The size to convert to snapped value</param>
        /// <returns>A snapped size</returns>
        public Size GetTransformedSnap(Size size)
        {
            int cols = (int)Math.Ceiling(size.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Ceiling(size.Height / (double)(SnapSize.Height));
            return new Size(cols, rows);
        }

        /// <summary>
        /// Gets the backbuffer size
        /// </summary>
        public Size GetSize()
        {
            Size size = UseCanvas ? _canvas : _image == null || _image.Size.Width <= 0 || _image.Height <= 0 ? new Size(1, 1) : _image.Size;
            size.Width = Math.Max(ClientSize.Width, size.Width);
            size.Height = Math.Max(ClientSize.Height, size.Height);
            return size;
        }

        /// <summary>
        /// Gets the color of the backbuffer under the mouse position
        /// </summary>
        /// <returns>A color</returns>
        public Color GetColorUnderMouse()
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                Point location = Cursor.Position;
                Rectangle bounds = new Rectangle(location.X, location.Y, 1, 1);
                using (Graphics gfx = Graphics.FromImage(bmp))
                    gfx.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                return bmp.GetPixel(0, 0);
            }
        }

        /// <summary>
        /// Changes a bitmap's transparency
        /// </summary>
        /// <param name="image">The bitmap to change the transparency on</param>
        /// <param name="amount">The desired transparency</param>
        /// <returns>A bitmap with new transparency values</returns>
        public static Bitmap BitmapTransparency(Bitmap image, float amount)
        {
            // Create a new bitmap to draw on
            Bitmap bm = new Bitmap(image.Width, image.Height);
            Graphics gfx = Graphics.FromImage(bm);

            // Alpha changing color matrix
            ColorMatrix cm = new ColorMatrix(new float[][] {
                new float[]{ 1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
                new float[]{ 0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
                new float[]{ 0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
                new float[]{ 0.0f, 0.0f, 0.0f, amount, 0.0f},
                new float[]{ 0.0f, 0.0f, 0.0f, 0.0f, 1.0f} });

            // Create new image attributes
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);

            // Draw the original image with new image attributes
            gfx.DrawImage(image, new Rectangle(0, 0, bm.Width, bm.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ia);

            // Dispose
            gfx.Dispose();
            ia.Dispose();

            // Return changed bitmap
            return bm;
        }
    }
}
