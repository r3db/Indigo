using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Indigo.UI.Form
{
    public partial class Histogram : System.Windows.Forms.Form
    {
        private readonly int[] data;
        private const int HistogramHeight = 400;
        private readonly int max;

        public Histogram()
        {
            InitializeComponent();
            this.Width = byte.MaxValue+16;
            this.Height = HistogramHeight + 40;
            base.DoubleBuffered = true;
            base.BackColor = Color.Black;
        }

        public Histogram(int[] data, string title) : this()
        {
            if(data == null || data.Length != byte.MaxValue+1)
            {
                throw new ArgumentException("data");
            }

            this.data = data;
            this.max = data.Max();
            base.Text = title;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            for(int i=0;i<byte.MaxValue;++i)
            {
                var h = (data[i] * HistogramHeight) / (float)max;
                gp.StartFigure();
                gp.AddLine(i, 0, i, HistogramHeight - h);
                gp.CloseFigure();
            }

            g.DrawPath(Pens.White, gp);
        }
    }
}
