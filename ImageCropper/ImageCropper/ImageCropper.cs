namespace ImageCropper
{
    public partial class ImageCropper : Form
    {
        #region fields
        
        private Point _pointMouseDown;
        private bool _isMouseDown;
        private readonly ControlRectangle _controlRectangle;
        
        #endregion

        #region constructors
        
        public ImageCropper(Image image, ArdAspectRatio ardAspectRatio)
        {
            InitializeComponent();
            _adjustSizePictureBoxAndForm(image.Size);
            pictureBox.Image = image;
            _controlRectangle = new ControlRectangle(pictureBox.Size, image.Size, ardAspectRatio);
            _adjustTrackBar();
        }

        public ImageCropper(Image image) : this(image, new ArdAspectRatio(MediaType.Video)) { }

        #endregion

        #region properties
        
        public Image CroppedImage => new Bitmap(pictureBox.Image)
            .Clone(_controlRectangle.RectangleInImage, 
            pictureBox.Image.PixelFormat);

        #endregion

        #region methods

        // the height of the image cropper window is changed as much as the adjustment in height to the picture box
        private void _adjustSizePictureBoxAndForm(Size size)
        {
            int newPictureBoxHeight = pictureBox.Width * size.Height / size.Width;
            this.Height += newPictureBoxHeight - pictureBox.Height;
            pictureBox.Height = newPictureBoxHeight;
        }

        public void _adjustTrackBar()
        {
            trackBar.Maximum = _controlRectangle.MaxFactorImage;
            trackBar.Minimum = _controlRectangle.ArdAspectRatio.MinimumFactor;
            trackBar.TickFrequency = trackBar.Maximum - trackBar.Minimum;
            trackBar.Value = trackBar.Maximum;
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
            if (_controlRectangle.PermitTrackbarValue(trackBar.Value))
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

        //#region structs
        //public readonly struct AspectRatio
        //{
        //    public AspectRatio(int width, int height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public int Width { get; }

        //    public int Height { get; }

        //    public readonly float FloatValue => (float)Width / Height;

        //    public readonly Size UnitSize => new(Width, Height);

        //    public Size SizeBy(int factor)
        //        => new(Width * factor, Height * factor);
        //}
        //#endregion
    }
}
