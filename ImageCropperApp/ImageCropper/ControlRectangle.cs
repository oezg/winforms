namespace ImageCropper
{
    internal class ControlRectangle
    {
        private readonly Size _displaySize;
        private readonly Size _imageSize;
        private int _factorImage;
        public Rectangle RectangleInDisplay;

        public ControlRectangle(Size displaySize, Size imageSize, ImageCropper.AspectRatio aspectRatio)
        {
            _displaySize = displaySize;
            _imageSize = imageSize;
            AspectRatio = aspectRatio;
            FactorImage = Math.Max(MinFactorImage, (MaxFactorImage - MinFactorImage) / 2);
            RectangleInDisplay = new Rectangle(_initialLocationRectangleDisplay(), SizeInDisplay);
        }

        public ImageCropper.AspectRatio AspectRatio { get; }

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
            => Math.Min(_displaySize.Width / AspectRatio.Width, _displaySize.Height / AspectRatio.Height);

        public int MaxFactorImage
            => Math.Min(_imageSize.Width / AspectRatio.Width, _imageSize.Height / AspectRatio.Height);

        public int MinFactorImage 
            =>  ImageCropper.MinimumWidthPixel / AspectRatio.Width;

        public Rectangle RectangleInImage 
            => new Rectangle(LocationInImage, SizeInImage);

        public Point LocationInImage
            => new( Math.Min(RectangleInDisplay.X * MaxFactorImage / MaxFactorDisplay, _imageSize.Width - SizeInImage.Width),
                    Math.Min(RectangleInDisplay.Y * MaxFactorImage / MaxFactorDisplay, _imageSize.Height - SizeInImage.Height) );
        
        public Size SizeInDisplay
            => AspectRatio.SizeBy(FactorDisplay);

        public Size SizeInImage
            => AspectRatio.SizeBy(FactorImage);

        public bool PermitValue(int value)
        {
            Rectangle rectangle = new(LocationInImage, AspectRatio.SizeBy(value));
            return rectangle.Right <= _imageSize.Width && rectangle.Bottom <= _imageSize.Height;
        }

        private Point _initialLocationRectangleDisplay()
            => new( (_displaySize.Width - SizeInDisplay.Width) / 2,
                    (_displaySize.Height - SizeInDisplay.Height) / 2 );
        
    }
}
