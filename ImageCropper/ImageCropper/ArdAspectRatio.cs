namespace ImageCropper
{
    public class ArdAspectRatio : AspectRatio
    {
        private static Size s_audioMinimumSize = new(width: 1080, height: 1080);
        private static Size s_videoMinimumSize = new(width: 1920, height: 1080);

        private static Size s_audioAspectRatio = new(width: 1, height: 1);
        private static Size s_videoAspectRatio = new(width: 16, height: 9);

        public Size MinimumSize { get; }

        public int MinimumFactor => MinimumSize.Width / Size.Width;

        public ArdAspectRatio(MediaType mediaType) : base(getSize(mediaType))
        {
            switch (mediaType)
            {
                case MediaType.Audio:
                    MinimumSize = s_audioMinimumSize;
                    break;
                case MediaType.Video:
                    MinimumSize = s_videoMinimumSize;
                    break;
            }
        }

        private static Size getSize(MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.Audio:
                    return s_audioAspectRatio;
                case MediaType.Video:
                    return s_videoAspectRatio;
                default:
                    throw new ArgumentException("Only Audio and Video mediatypes have aspect ratio");
            }
        }

        public static bool operator <(Size left, ArdAspectRatio right) => left.Width < right.MinimumSize.Width || left.Height < right.MinimumSize.Height;

        public static bool operator >(Size left, ArdAspectRatio right) => throw new InvalidOperationException("> is not defined between Size and ArdAspectRatio");
    }
}
