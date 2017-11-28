using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Indigo.Core
{
    public static class Effects
    {
        private static readonly Rectangle Area = new Rectangle(Point.Empty, new Size(640, 480));
        private static readonly Color EmptyColor = Color.FromArgb(0, 0, 0, 0);

        // Done!
        #region Helpers

        // Done!
        private static Bitmap ResultFromSource(this Bitmap image, Func<UnsafeBitmap, UnsafeBitmap, Bitmap> callback)
        {
            Bitmap result;

            using (var source = new UnsafeBitmap(new Bitmap(image)))
            {
                using (var destination = new UnsafeBitmap(new Bitmap(image)))
                {
                    result = callback.Invoke(source, destination);
                }
            }

            return result;
        }

        // Done!
        private static Bitmap Iterate(this Bitmap image, Action<UnsafeBitmap, UnsafeBitmap, int, int> action)
        {
            return ResultFromSource(image, (source, destination) =>
            {
                var height = source.Bitmap.Height;
                var width = source.Bitmap.Width;

                //for (int y = 0; y < height; y++)
                Parallel.For(0, height, y =>
                {
                    for (int x = 0; x < width; x++)
                    {
                        action.Invoke(source, destination, x, y);
                    }
                });

                return destination.Bitmap;
            });

        }

        // Done!
        private static void Iterate(this Bitmap image, Action<Color> action)
        {
            ResultFromSource(image, (source, destination) =>
            {
                var height = source.Bitmap.Height;
                var width = source.Bitmap.Width;

                //for (int y = 0; y < height; y++)
                Parallel.For(0, height, y =>
                {
                    for (int x = 0; x < width; x++)
                    {
                        action.Invoke(source.GetPixel(x, y));
                    }
                });
                return null;
            });

        }

        // Done!
        private static Color[] GetNeighbours(UnsafeBitmap source, int x, int y)
        {

            const int offset = 1;
            int sy = y - offset;
            int sx = x - offset;
            int yl = y + offset;
            int xl = x + offset;

            Color[] pixelData = new Color[9];

            int counter = 0;

            for (int i = sy; i <= yl; ++i)
            {
                for (int k = sx; k <= xl; ++k)
                {
                    pixelData[counter++] = IsValid(k, i, Area.Width, Area.Height) == false ? EmptyColor : (Color)source.GetPixel(k, i);
                }
            }

            return pixelData;
        }


        #endregion

        // Done!
        #region Invert

        // Done!
        public static Bitmap Invert(this Bitmap image)
        {
            return Iterate(image, (source, destination, x, y) =>
            {
                var color = source.GetPixel(x, y);
                const int max = byte.MaxValue;
                var newColor = Color.FromArgb(max - color.Red, max - color.Green, max - color.Blue);
                destination.SetPixel(x, y, newColor);                              
            });
        }

        #endregion

        // Done!
        #region GrayScale

        // Done!
        public static Bitmap GrayScale(this Bitmap image)
        {
            return Iterate(image, (source, destination, x, y) =>
            {
                var color = source.GetPixel(x, y);
                var avg = (byte)(color.Red*0.299f + color.Green*0.587f + color.Blue*0.114f);
                destination.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
            });
        }

        #endregion

        // Done!
        #region Brightness

        // Done!
        public static Bitmap Brightness(this Bitmap image, byte brightness)
        {
            return Iterate(image, (source, destination, x, y) =>
            {
                var color = source.GetPixel(x, y);
                destination.SetPixel(x, y, Color.FromArgb(Clamp(color.Red + brightness), Clamp(color.Green + brightness), Clamp(color.Blue + brightness)));
            });
        }

        // Done!
        private static byte Clamp(int value)
        {
            if(value < 0)
            {
                return 0;
            }
            return value > 255 ? (byte)255 : (byte)value;
        }

        #endregion

        // Done!
        #region Contrast

        // Done!
        public static Bitmap Contrast(this Bitmap image, int contrast)
        {
            if (contrast < -100 || contrast > 100)
            {
                throw new ArgumentOutOfRangeException("contrast", contrast, "-100 < x < 100");
            }

            var nContrast = (100 + contrast)/100f; 

            return Iterate(image, (source, destination, x, y) =>
            {
                var color = source.GetPixel(x, y);
                destination.SetPixel(x, y, Color.FromArgb(
                    ContrastHelper(color.Red,   nContrast),
                    ContrastHelper(color.Green, nContrast),
                    ContrastHelper(color.Blue,  nContrast)));
            });
        }

        // Done!
        private static byte ContrastHelper(byte data, float contrast)
        {
            const float max = byte.MaxValue;

            double value = data;

            value /= max;
            value -= 0.5;
            value *= contrast;
            value += 0.5;
            value *= max;

            return (byte)(value < 0 ? 0 : value > 255 ? 255 : value);
        }

        #endregion

        // Done!
        #region Color Filter

        // Done!
        public static Bitmap ColorFilter(this Bitmap image, Color color)
        { 
            return Iterate(image, (source, destination, x, y) =>
            {
                var c = source.GetPixel(x, y);
                destination.SetPixel(x, y, ColorFilterHelper(c, color));
            });
        }

        // Done!
        private static Color ColorFilterHelper(Color color, Color filter)
        {
            if (Color.Red == filter)
            {
                return Color.FromArgb(color.A, color.R, 0, 0);
            }
            if (Color.Green == filter)
            {
                return Color.FromArgb(color.A, 0, color.G, 0);
            }
            if (Color.Blue == filter)
            {
                return Color.FromArgb(color.A, 0, 0, color.B);
            }
            return color;
        }

        #endregion

        // Done!
        #region Empty Filter

        // Done!
        public static Bitmap EmptyFilter(this Bitmap image)
        {
            var pm = PixelMatrix.EmptyFilter;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        #endregion

        // Done!
        #region Gaussian Blur Filter

        // Done!
        public static Bitmap GaussianBlurFilter(this Bitmap image)
        {
            var pm = PixelMatrix.GaussianBlurFilter;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        #endregion

        // Done!
        #region Sharpen Filter

        // Done!
        public static Bitmap SharpenFilter(this Bitmap image)
        {
            var pm = PixelMatrix.SharpenFilter;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        #endregion

        // Done!
        #region Mean Removal Filter

        // Done!
        public static Bitmap MeanRemovalFilter(this Bitmap image)
        {
            var pm = PixelMatrix.MeanRemovalFilter;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        #endregion

        // Done!
        #region Emboss Laplascian Filter

        // Done!
        public static Bitmap EmbossLaplascianFilter(this Bitmap image)
        {
            var pm = PixelMatrix.EmbossLaplascianFilter;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        #endregion

        // Done!
        #region Edge Detection Filter

        // Done!
        public static Bitmap EdgeDetectConvolution0Filter(this Bitmap image)
        {
            var pm = PixelMatrix.EdgeDetectFilter0;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        // Done!
        public static Bitmap EdgeDetectConvolution1Filter(this Bitmap image)
        {
            var pm = PixelMatrix.EdgeDetectFilter1;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        // Done!
        public static Bitmap EdgeDetectConvolution2Filter(this Bitmap image)
        {
            var pm = PixelMatrix.EdgeDetectFilter2;
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y))));
        }

        public static Bitmap EdgeDetection(this Bitmap image, float threshold, Color edge)
        {
            var area = new Rectangle(Point.Empty, image.Size);
            return Iterate(image, (source, destination, x, y) =>
                           FindEdgesHelper(source, destination, x, y, source.GetPixel(x, y), edge, area, threshold)
            );
        }

        // Done!
        public static Bitmap EdgeDetectSobelFilter(this Bitmap image)
        {
            var s1 = PixelMatrix.SobelX1;
            var s2 = PixelMatrix.SobelX2;
            var s3 = PixelMatrix.SobelY1;
            var s4 = PixelMatrix.SobelY2;
            return Iterate(image, (source, destination, x, y) =>
            {
                //destination.SetPixel(x, y, pm.Compute(GetNeighbours(source, x, y)));

			    // We need only one set of neighbours because they all share the same size!
			    Color[] neighbours = GetNeighbours(source, x, y);

                Color conv0 = s1.Compute(neighbours);
                Color conv1 = s2.Compute(neighbours);
                Color conv2 = s3.Compute(neighbours);
                Color conv3 = s4.Compute(neighbours);

                Color c = Color.FromArgb(
                    0xff,
                    Clamp((int)Math.Sqrt(conv0.R*conv0.R + conv1.R*conv1.R + conv2.R*conv2.R + conv3.R*conv3.R)),
                    Clamp((int)Math.Sqrt(conv0.G*conv0.G + conv1.G*conv1.G + conv2.G*conv2.G + conv3.G*conv3.G)),
                    Clamp((int)Math.Sqrt(conv0.B*conv0.B + conv1.B*conv1.B + conv2.B*conv2.B + conv3.B*conv3.B))
                    );

                destination.SetPixel(x, y, c);

            });
        }

        // Done!
        private static void FindEdgesHelper(UnsafeBitmap source, UnsafeBitmap destination, int x, int y, Color pixel, Color edge, Rectangle area, float threshold)
        {
            int sy = y - 1;
            int sx = x - 1;
            int yl = y + 1;
            int xl = x + 1;

            for (int i = sy; i <= yl; ++i)
            {
                for (int k = sx; k <= xl; ++k)
                {
                    if(k==i) continue;
                    if (IsValid(k, i, area.Width, area.Height) == false) continue;

                    PixelData temp = source.GetPixel(k, i);

                    int dr = temp.Red - pixel.R;
                    int dg = temp.Green - pixel.G;
                    int db = temp.Blue - pixel.B;

                    var distance = Math.Sqrt((dr * dr) + (dg * dg) + (db * db));

                    if (distance > threshold)
                    {
                        destination.SetPixel(x, y, edge);
                        return;
                    }

                }
            }
            destination.SetPixel(x, y, Color.White);
        }

        // Done!
        private static bool IsValid(int x, int y, int width, int height)
        {
            return x >= 0 && x < width && y >= 0 && y < height;
        }

        #endregion

        // Done!
        #region Fill

        public static Bitmap Fill(this Bitmap image, Color color)
        {
            return Iterate(image, (source, destination, x, y) => destination.SetPixel(x, y, color));
        }

        #endregion

        // Done!
        #region Histogram

        public static int[] GetFullHistogram(this Bitmap image)
        {
            int[] result = new int[byte.MaxValue+1];
            object locker = new object();

            Iterate(image, c =>
            {
                lock(locker)
                {
                    int v = 0;
                    v += c.R;
                    v += c.G;
                    v += c.B;

                    v = v / 3;
                    result[v]++;
                }
            });

            return result;
        }

        public static int[] GetRedHistogram(this Bitmap image)
        {
            int[] result = new int[byte.MaxValue + 1];
            object locker = new object();

            Iterate(image, c =>
            {
                lock (locker)
                {
                    result[c.R]++;
                }
            });

            return result;
        }

        public static int[] GetGreenHistogram(this Bitmap image)
        {
            int[] result = new int[byte.MaxValue + 1];
            object locker = new object();

            Iterate(image, c =>
            {
                lock (locker)
                {
                    result[c.G]++;
                }
            });

            return result;
        }

        public static int[] GetBlueHistogram(this Bitmap image)
        {
            int[] result = new int[byte.MaxValue + 1];
            object locker = new object();

            Iterate(image, c =>
            {
                lock (locker)
                {
                    result[c.B]++;
                }
            });

            return result;
        }

        #endregion

        // Done!
        #region Normalize

        public static Bitmap Normalize(this Bitmap image)
        {
            return Iterate(image, (source, destination, x, y) =>
            {
                var p = source.GetPixel(x, y);
                var sum = p.Red + p.Green + p.Blue;
                
                var r = (sum != 0) ? (byte)(255 * p.Red   / sum) : (byte)0;
                var g = (sum != 0) ? (byte)(255 * p.Green / sum) : (byte)0;
                var b = (sum != 0) ? (byte)(255 * p.Blue  / sum) : (byte)0;

                destination.SetPixel(x, y, Color.FromArgb(byte.MaxValue, r, g, b)); 

            });
        }

        #endregion

    }
}
