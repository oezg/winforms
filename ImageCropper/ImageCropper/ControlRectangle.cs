namespace ImageCropper
{
    internal class ControlRectangle
    {
        private readonly Size _displaySize;
        private readonly Size _imageSize;
        private int _factorImage;
        public Rectangle RectangleInDisplay;

        public ControlRectangle(Size displaySize, Size imageSize, ArdAspectRatio ardAspectRatio)
        {
            _displaySize = displaySize;
            _imageSize = imageSize;
            ArdAspectRatio = ardAspectRatio;
            FactorImage = MaxFactorImage;
            RectangleInDisplay = new Rectangle(new Point(), SizeInDisplay);
        }

        public ArdAspectRatio ArdAspectRatio { get; }

        public int FactorDisplay => FactorImage * MaxFactorDisplay / MaxFactorImage;

        public int FactorImage
        {
            get => _factorImage;
            set
            {
                _factorImage = value;
                RectangleInDisplay.Size = SizeInDisplay;
            }
        }

        public int MaxFactorDisplay
            //=> Math.Min(_displaySize.Width / ArdAspectRatio.Size.Width, _displaySize.Height / ArdAspectRatio.Size.Height);
            => _maxFactor(_displaySize);

        public int MaxFactorImage
            //=> Math.Min(_imageSize.Width / ArdAspectRatio.Size.Width, _imageSize.Height / ArdAspectRatio.Size.Height);
            => _maxFactor(_imageSize);

        //public int MinFactorImage 
        //    =>  ImageCropper.MinimumWidthPixel / AspectRatio.Width;

        public Rectangle RectangleInImage 
            => new(LocationInImage, SizeInImage);

        public Point LocationInImage
            => new( Math.Min(RectangleInDisplay.X * MaxFactorImage / MaxFactorDisplay, _imageSize.Width - SizeInImage.Width),
                    Math.Min(RectangleInDisplay.Y * MaxFactorImage / MaxFactorDisplay, _imageSize.Height - SizeInImage.Height) );
        
        public Size SizeInDisplay
            => ArdAspectRatio * FactorDisplay;

        public Size SizeInImage
            => ArdAspectRatio * FactorImage;

        public bool PermitTrackbarValue(int value)
        {
            Rectangle rectangle = new(LocationInImage, ArdAspectRatio * value);
            return rectangle.Right <= _imageSize.Width && rectangle.Bottom <= _imageSize.Height;
        }

        //private Point _initialLocationRectangleDisplay()
        //    => new( (_displaySize.Width - SizeInDisplay.Width) / 2,
        //            (_displaySize.Height - SizeInDisplay.Height) / 2 );

        private int _maxFactor(Size size)
            => Math.Min(size.Width / ArdAspectRatio.Size.Width, size.Height / ArdAspectRatio.Size.Height);
    }
}
