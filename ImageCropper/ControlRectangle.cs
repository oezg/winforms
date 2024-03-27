namespace ImageCropper
{
    internal class ControlRectangle
    {
        private readonly Size _displaySize;
        private readonly Size _sourceSize;
        private int _factorSource;
        public Rectangle RectangleDisplay;

        public ControlRectangle(Size displaySize, Size sourceSize, ArdAspectRatio ardAspectRatio)
        {
            _displaySize = displaySize;
            _sourceSize = sourceSize;
            ArdAspectRatio = ardAspectRatio;
            FactorSource = Math.Min(ArdAspectRatio.MaximumFactor, maxFactor(_sourceSize));
            RectangleDisplay = new Rectangle(new Point(), SizeDisplay);
        }

        public ArdAspectRatio ArdAspectRatio { get; }

        public int FactorSource
        {
            get => _factorSource;
            set
            {
                _factorSource = value;
                RectangleDisplay.Size = SizeDisplay;
            }
        }

        public Rectangle RectangleSource 
            => new(LocationDisplay, SizeSource);

        public Point LocationDisplay
            => new(Math.Min(projectToSource(RectangleDisplay.X), _sourceSize.Width - SizeSource.Width),
                    Math.Min(projectToSource(RectangleDisplay.Y), _sourceSize.Height - SizeSource.Height));

        public Size SizeDisplay
            => ArdAspectRatio * (FactorSource * _displaySize.Width / _sourceSize.Width);

        public Size SizeSource
            => ArdAspectRatio * FactorSource;

        public bool IsValidFactor(int factor)
        {
            if (factor > ArdAspectRatio.MaximumFactor || factor < ArdAspectRatio.MinimumFactor)
            {
                return false;
            }
            Rectangle rectangle = new(LocationDisplay, ArdAspectRatio * factor);
            return rectangle.Right <= _sourceSize.Width && rectangle.Bottom <= _sourceSize.Height;
        }

        private int projectToSource(int distanceDisplay) 
            => distanceDisplay * _sourceSize.Width / _displaySize.Width;

        private int maxFactor(Size size)
            => Math.Min(size.Width / ArdAspectRatio.SimpleSize.Width, size.Height / ArdAspectRatio.SimpleSize.Height);
    }
}
