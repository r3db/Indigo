using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Indigo.Core;

namespace Indigo.UI.Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region Internal Data

        private Bitmap image;
        
        #endregion

        public Form1()
        {
            InitializeComponent();
            //this.image = new Bitmap(new Bitmap(@"D:\Wallpaper\Tdot.jpg"), this.pictureBox1.Width, this.pictureBox1.Height);
            this.image = new Bitmap(new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height));
            this.pictureBox1.Image = image;
            this.pictureBox1.AllowDrop = true;
        }

        // Done!
        private void DragEvent(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Link;
                string path = ((string[])e.Data.GetData("FileNameW"))[0];
                this.image = new Bitmap(new Bitmap(path), this.pictureBox1.Width, this.pictureBox1.Height);
                this.pictureBox1.Image = image;
            }
            catch
            {
                MessageBox.Show("Invalid Image");
            }
        }

        // Done!
        private void TimeEllapsed(Stopwatch sw)
        {
            var et = sw.ElapsedMilliseconds;
            this.Text = et > 1000 ? et / 1000f + "s" : et + "ms";
        }

        // Done!
        private void InvertColorEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.Invert();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void GrayScaleEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.GrayScale();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void BrightnessEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.Brightness(5);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void ContrastEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.Contrast(10);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void FilterByRedEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.ColorFilter(Color.Red);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void FilterByGreenEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.ColorFilter(Color.Green);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void FilterByBlueEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.ColorFilter(Color.Blue);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EmptyFilterEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EmptyFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void GaussianBlurEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.GaussianBlurFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void SharpenEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.SharpenFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void MeanRemovalEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.MeanRemovalFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EmbossLaplascianEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EmbossLaplascianFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EdgeDetectionConvolution0Event(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EdgeDetectConvolution0Filter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EdgeDetectionConvolution1Event(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EdgeDetectConvolution1Filter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EdgeDetectionConvolution2Event(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EdgeDetectConvolution2Filter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void EdgeDetectionNaiveEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EdgeDetection(30, Color.Black);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        private void EdgeDetectionSobelEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.EdgeDetectSobelFilter();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void FillEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.Fill(Color.Green);

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

        // Done!
        private void GetFullHistogramEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] data = image.GetFullHistogram();

            sw.Stop();
            TimeEllapsed(sw);

            new Histogram(data, "Combined Histogram").Show();
        }

        // Done!
        private void GetRedHistogramEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] data = image.GetRedHistogram();

            sw.Stop();
            TimeEllapsed(sw);

            new Histogram(data, "Red Histogram").Show();
        }

        // Done!
        private void GetGreenHistogramEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] data = image.GetGreenHistogram();

            sw.Stop();
            TimeEllapsed(sw);

            new Histogram(data, "Green Histogram").Show();
        }

        // Done!
        private void GetBlueHistogramEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] data = image.GetBlueHistogram();

            sw.Stop();
            TimeEllapsed(sw);

            new Histogram(data, "Blue Histogram").Show();
        }

        private void NormalizeEvent(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.image = image.Normalize();

            sw.Stop();
            this.pictureBox1.Image = image;
            TimeEllapsed(sw);
        }

    }
}
