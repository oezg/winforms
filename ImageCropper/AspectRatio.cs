using System;
using System.Drawing;

namespace ImageCropper
{
    public class AspectRatio : IEquatable<AspectRatio>
    {
        public AspectRatio(Size size)
        {
            try
            {
                var gcd = GreatestCommonDivisor(size.Width, size.Height);
                SimpleSize = new Size(size.Width / gcd, size.Height / gcd);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Bildbreite und -höhe muss positiv sein");
            }
        }

        public Size SimpleSize { get; set; }

        public float FloatValue => (float)SimpleSize.Width / SimpleSize.Height;

        public static int GreatestCommonDivisor(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Euclid algorithm works only with positive integers");
            }

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public override string ToString() => $"{SimpleSize.Width}:{SimpleSize.Height}";

        public override bool Equals(object obj) => obj is AspectRatio aspectRatio && aspectRatio.Equals(this);

        public bool Equals(AspectRatio other) => SimpleSize == other.SimpleSize;

        public override int GetHashCode()
        {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + SimpleSize.Width.GetHashCode();
            hashCode = hashCode * -1521134295 + SimpleSize.Height.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(AspectRatio left, AspectRatio right) => left.Equals(right);

        public static bool operator !=(AspectRatio left, AspectRatio right) => !(left == right);

        public static bool operator <(AspectRatio left, AspectRatio right) => left.FloatValue < right.FloatValue;

        public static bool operator >(AspectRatio left, AspectRatio right) => left.FloatValue > right.FloatValue;

        public static bool operator <=(AspectRatio left, AspectRatio right) => !(left > right);

        public static bool operator >=(AspectRatio left, AspectRatio right) => !(left < right);

        public static Size operator *(int left, AspectRatio right) 
            => left > 0
                ? new Size(left * right.SimpleSize.Width, left * right.SimpleSize.Height)
                : throw new ArgumentException("The multiplier must be positive");

        public static Size operator *(AspectRatio left, int right) => right * left;
    }
}