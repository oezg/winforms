namespace ImageCropper
{
    public class ArdAspectRatio : AspectRatio
    {
        private const int MAXIMUM_SIZE = 3840;

        private static Size s_audioMinimumSize;
        private static Size s_videoMinimumSize;

        private static Size s_audioMaximumSize;
        private static Size s_videoMaximumSize;

        private static Size s_audioAspectRatio;
        private static Size s_videoAspectRatio;

        static ArdAspectRatio()
        {
            s_audioAspectRatio = new(width: 1, height: 1);
            s_videoAspectRatio = new(width: 16, height: 9);

            s_audioMinimumSize = new(width: 1080, height: 1080);
            s_videoMinimumSize = new(width: 1920, height: 1080);
            
            s_audioMaximumSize = new(width: MAXIMUM_SIZE, height: MAXIMUM_SIZE);
            s_videoMaximumSize = new(width: MAXIMUM_SIZE, height: MAXIMUM_SIZE * s_videoAspectRatio.Height / s_videoAspectRatio.Width);
        }

        public Size MinimumSize { get; }
        public Size MaximumSize { get; }

        public int MinimumFactor => MinimumSize.Width / SimpleSize.Width;
        public int MaximumFactor => MaximumSize.Width / SimpleSize.Width;

        public ArdAspectRatio(MediaType mediaType) : base(getSize(mediaType))
        {
            switch (mediaType)
            {
                case MediaType.Audio:
                    MinimumSize = s_audioMinimumSize;
                    MaximumSize = s_audioMaximumSize;
                    break;
                case MediaType.Video:
                    MinimumSize = s_videoMinimumSize;
                    MaximumSize = s_videoMaximumSize;
                    break;
            }
        }

        private static Size getSize(MediaType mediaType) 
            => mediaType switch
            {
                MediaType.Audio => s_audioAspectRatio,
                MediaType.Video => s_videoAspectRatio,
            };

        // true if size is smaller than minimum size in width or height
        public static bool operator <(Size left, ArdAspectRatio right) => left.Width < right.MinimumSize.Width || left.Height < right.MinimumSize.Height;

        // true if size is larger than maximum size in width or height
        public static bool operator >(Size left, ArdAspectRatio right) => left.Width > right.MaximumSize.Width || left.Height > right.MaximumSize.Height;
    }
}
