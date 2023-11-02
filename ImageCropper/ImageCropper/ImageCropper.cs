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
            adjustHeightPictureBoxAndForm(image.Size);
            pictureBox.Image = image;
            _controlRectangle = new ControlRectangle(pictureBox.Size, image.Size, ardAspectRatio);
            initializeTrackBar();
            updateLabelFactor();
        }

        #endregion

        #region properties

        public Image CroppedImage => new Bitmap(pictureBox.Image)
            .Clone(_controlRectangle.RectangleSource,
            pictureBox.Image.PixelFormat);

        public Rectangle CropRectangle => _controlRectangle.RectangleDisplay;

        #endregion

        #region methods

        // picture box gets same aspect ratio as the source image
        private void adjustHeightPictureBoxAndForm(Size size)
        {
            int newPictureBoxHeight = pictureBox.Width * size.Height / size.Width;
            this.Height += newPictureBoxHeight - pictureBox.Height;
            pictureBox.Height = newPictureBoxHeight;
        }

        private void initializeTrackBar()
        {
            trackBar.Maximum = _controlRectangle.FactorSource;
            trackBar.Minimum = _controlRectangle.ArdAspectRatio.MinimumFactor;
            trackBar.Value = trackBar.Maximum;
        }

        private void updateLabelFactor()
            => labelFactor.Text = $"Minim: {trackBar.Minimum}\nFactor: {trackBar.Value}\nMaxim: {trackBar.Maximum}";

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
            => e.Graphics.DrawRectangle(new Pen(Color.Red, 2), _controlRectangle.RectangleDisplay);

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
            => _isMouseDown = false;

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                _controlRectangle.RectangleDisplay.X += e.X - _pointMouseDown.X;
                _controlRectangle.RectangleDisplay.Y += e.Y - _pointMouseDown.Y;
                _pointMouseDown = e.Location;

                if (_controlRectangle.RectangleDisplay.Right > pictureBox.Width)
                {
                    _controlRectangle.RectangleDisplay.X = pictureBox.Width - _controlRectangle.RectangleDisplay.Width;
                }
                if (_controlRectangle.RectangleDisplay.Top < 0)
                {
                    _controlRectangle.RectangleDisplay.Y = 0;
                }
                if (_controlRectangle.RectangleDisplay.Left < 0)
                {
                    _controlRectangle.RectangleDisplay.X = 0;
                }
                if (_controlRectangle.RectangleDisplay.Bottom > pictureBox.Height)
                {
                    _controlRectangle.RectangleDisplay.Y = pictureBox.Height - _controlRectangle.RectangleDisplay.Height;
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
            if (_controlRectangle.IsValidFactor(trackBar.Value))
            {
                _controlRectangle.FactorSource = trackBar.Value;
                Refresh();
            }
            else
            {
                trackBar.Value = _controlRectangle.FactorSource;
            }

            updateLabelFactor();
        }

        #endregion
    }
}
