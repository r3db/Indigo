using System;
using System.Drawing;

namespace Indigo.Core
{
    public sealed class PixelMatrix
    {
        #region Filters

        // Done!
        public static PixelMatrix EmptyFilter
        {
            get { return new PixelMatrix(new[] {0, 0, 0, 0, 1, 0, 0, 0, 0,}, 1, 0); }
        }

        // Done!
        public static PixelMatrix GaussianBlurFilter
        {
            get { return new PixelMatrix(new[] { 1, 2, 1, 2, 4, 2, 1, 2, 1, }, 16, 0); }
        }

        // Done!
        public static PixelMatrix SharpenFilter
        {
            get { return new PixelMatrix(new[] { 0, -2, 0, -2, 11, -2, 0, -2, 0, }, 3, 0); }
        }

        // Done!
        public static PixelMatrix MeanRemovalFilter
        {
            get { return new PixelMatrix(new[] { -1, -1, -1, -1, 9, -1, -1, -1, -1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix EmbossLaplascianFilter
        {
            get { return new PixelMatrix(new[] { -1, 0, -1, 0, 4, 0, -1, 0, -1, }, 1, 127); }
        }

        // Done!
        public static PixelMatrix EdgeDetectFilter0
        {
            get { return new PixelMatrix(new[] { 1, 1, 1, 0, 0, 0, -1, -1, -1, }, 1, 127); }
        }

        // Done!
        public static PixelMatrix EdgeDetectFilter1
        {
            get { return new PixelMatrix(new[] { -1, 0, -1, 0, 4, 0, -1, 0, -1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix EdgeDetectFilter2
        {
            get { return new PixelMatrix(new[] { 1, 1, 1, 0, 0, 0, -1, -1, -1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix SobelX1
        {
            get { return new PixelMatrix(new[] { -1, -2, -1, 0, 0, 0, 1, 2, 1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix SobelX2
        {
            get { return new PixelMatrix(new[] { 1, 2, 1, 0, 0, 0, -1, -2, -1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix SobelY1
        {
            get { return new PixelMatrix(new[] { -1, 0, 1, -2, 0, 2, -1, 0, 1, }, 1, 0); }
        }

        // Done!
        public static PixelMatrix SobelY2
        {
            get { return new PixelMatrix(new[] { 1, 0, -1, 2, 0, -2, 1, 0, -1, }, 1, 0); }
        }

        #endregion

        // Done!
        #region Internal Data

        private readonly int[]  filter;
        private readonly int    factor;
        private readonly int    offset;

        #endregion

        // Done!
        #region .Ctor

        // Done!
        public PixelMatrix(int[] filter, int factor, int offset)
        {
            this.filter = filter;
            this.factor = factor;
            this.offset = offset;
        }

        #endregion

        // Done!
        #region Methods

        // Done!
        public Color Compute(Color[] data)
        {
            float r = 0;
            float g = 0;
            float b = 0;
            for (int i = 0; i < filter.Length; ++i)
            {
                r += this.filter[i] * data[i].R;
                g += this.filter[i] * data[i].G;
                b += this.filter[i] * data[i].B;
            }
            r = (r / factor) + offset;
            g = (g / factor) + offset;
            b = (b / factor) + offset;
            return Color.FromArgb(byte.MaxValue, Clamp(r), Clamp(g), Clamp(b));

        }

        // Done!
        private static byte Clamp(float value)
        {
            return (byte)(value < byte.MinValue ? byte.MinValue : value > byte.MaxValue ? byte.MaxValue : value);
        }

        #endregion
    }
}
