using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Indigo.Core
{
    public unsafe class UnsafeBitmap : IDisposable
    {
        #region Internal Data

        private readonly Bitmap bitmap;
        private int length;
        private BitmapData data;
        private Byte* pBase = null;

        #endregion

        #region .Ctor

        public UnsafeBitmap(Image image)
        {
            this.bitmap = new Bitmap(image);
            this.Lock();
        }

        #endregion

        #region Properties

        public Bitmap Bitmap
        {
            get { return (bitmap); }
        }

        #endregion

        #region Helpers

        private void Lock()
        {
            Rectangle bounds = new Rectangle(Point.Empty, bitmap.Size);

            length = bounds.Width * sizeof(PixelData);
            if (length % 4 != 0)
            {
                length = 4 * (length / 4 + 1);
            }

            data = bitmap.LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            pBase = (byte*)data.Scan0.ToPointer();
        }

        private void Unlock()
        {
            bitmap.UnlockBits(data);
            data = null;
            pBase = null;
        }

        private PixelData* PixelAt(int x, int y)
        {
            return (PixelData*)(pBase + y * length + x * sizeof(PixelData));
        }

        #endregion

        public void Dispose()
        {
            this.Unlock();
        }

        public PixelData GetPixel(int x, int y)
        {
            return *PixelAt(x, y);
        }

        public void SetPixel(int x, int y, PixelData colour)
        {
            PixelData* pixel = PixelAt(x, y);
            *pixel = colour;
        }

    }

    public struct PixelData
    {
        public byte Blue    { get; set;}
        public byte Green   { get; set; }
        public byte Red     { get; set; }
        
        public static implicit operator Color(PixelData p)
        {
            return Color.FromArgb(
                byte.MaxValue,
                p.Red,
                p.Green,
                p.Blue);
        }

        public static implicit operator PixelData(Color c)
        {
            return new PixelData
            {
                Blue = c.B,
                Green = c.G,
                Red = c.R,
            };
        }
    }
}
