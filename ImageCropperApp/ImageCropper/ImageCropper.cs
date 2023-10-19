namespace ImageCropper
{
    public partial class ImageCropper : Form
    {
        #region constants
        public const int MinimumWidthPixel = 320;
        #endregion

        #region fields
        private Point _pointMouseDown;
        private bool _isMouseDown;
        private ControlRectangle _controlRectangle;
        #endregion

        #region constructors
        public ImageCropper(Image image, AspectRatio aspectRatio)
        {
            if (image.Width < MinimumWidthPixel)
            {
                MessageBox.Show($"Das hochgeladene Bild muss mindestens {MinimumWidthPixel} Pixel breit sein.");
                return;
            }
            InitializeComponent();
            _adjustSizePictureBoxAndForm(image);
            _controlRectangle = new ControlRectangle(pictureBox.Size, image.Size, aspectRatio);
            _adjustTrackBar();
        }

        public ImageCropper(Image image) : this(image, new AspectRatio(width: 16, height: 9)) { }
        #endregion

        #region properties
        public Image CroppedImage => new Bitmap(pictureBox.Image).Clone(
                _controlRectangle.RectangleInImage,
                pictureBox.Image.PixelFormat);
        #endregion

        #region methods
        public void _adjustSizePictureBoxAndForm(Image image)
        {
            int newPictureBoxHeight = pictureBox.Width * image.Height / image.Width;
            Height = Height + newPictureBoxHeight - pictureBox.Height;
            pictureBox.Height = newPictureBoxHeight;
            pictureBox.Image = image;
        }

        public void _adjustTrackBar()
        {
            trackBar.Maximum = _controlRectangle.MaxFactorImage;
            trackBar.Minimum = _controlRectangle.MinFactorImage;
            trackBar.TickFrequency = trackBar.Maximum - trackBar.Minimum;
            trackBar.Value = _controlRectangle.FactorImage;
        }
        #endregion

        #region event handlers
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
            => e.Graphics.DrawRectangle(new Pen(Color.Red, 2), _controlRectangle.RectangleInDisplay);

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
            => _isMouseDown = false;

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                _controlRectangle.RectangleInDisplay.X += e.X - _pointMouseDown.X;
                _controlRectangle.RectangleInDisplay.Y += e.Y - _pointMouseDown.Y;
                _pointMouseDown = e.Location;

                if (_controlRectangle.RectangleInDisplay.Right > pictureBox.Width)
                {
                    _controlRectangle.RectangleInDisplay.X = pictureBox.Width - _controlRectangle.RectangleInDisplay.Width;
                }
                if (_controlRectangle.RectangleInDisplay.Top < 0)
                {
                    _controlRectangle.RectangleInDisplay.Y = 0;
                }
                if (_controlRectangle.RectangleInDisplay.Left < 0)
                {
                    _controlRectangle.RectangleInDisplay.X = 0;
                }
                if (_controlRectangle.RectangleInDisplay.Bottom > pictureBox.Height)
                {
                    _controlRectangle.RectangleInDisplay.Y = pictureBox.Height - _controlRectangle.RectangleInDisplay.Height;
                }
                Refresh();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _pointMouseDown = e.Location;
            _isMouseDown = true;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (_controlRectangle.PermitValue(trackBar.Value))
            {
                _controlRectangle.FactorImage = trackBar.Value;
                Refresh();
            }
            else
            {
                trackBar.Value = _controlRectangle.FactorImage;
            }
        }
        #endregion

        #region structs
        public readonly struct AspectRatio
        {
            public AspectRatio(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Width { get; }

            public int Height { get; }

            public readonly float FloatValue => (float)Width / Height;

            public readonly Size UnitSize => new(Width, Height);

            public Size SizeBy(int factor)
                => new(Width * factor, Height * factor);
        }
        #endregion
    }
}
