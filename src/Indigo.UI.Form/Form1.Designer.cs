namespace Indigo.UI.Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Naive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EdgeDetectionNaiveEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FillEvent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(661, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Invert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.InvertColorEvent);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(661, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Gray Scale";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GrayScaleEvent);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(661, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Brightness";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BrightnessEvent);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(661, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Contrast";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ContrastEvent);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(661, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Filter By Red";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.FilterByRedEvent);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(661, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Filter By Green";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.FilterByGreenEvent);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(661, 151);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Filter By Blue";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.FilterByBlueEvent);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(661, 174);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(121, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Empty Convolution";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.EmptyFilterEvent);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(661, 197);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Gaussian Blur";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.GaussianBlurEvent);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(661, 220);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(121, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Sharpen";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.SharpenEvent);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(661, 390);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(121, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "Mean Removal";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.MeanRemovalEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(661, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Emboss Laplascian";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.EmbossLaplascianEvent);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 19);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 23);
            this.button16.TabIndex = 17;
            this.button16.Text = "ED C0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.EdgeDetectionConvolution0Event);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "ED C1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EdgeDetectionConvolution1Event);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 65);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 23);
            this.button17.TabIndex = 19;
            this.button17.Text = "ED C2";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.EdgeDetectionConvolution2Event);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(661, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 143);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edge Detection";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(661, 459);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(121, 23);
            this.button18.TabIndex = 21;
            this.button18.Text = "Normalize";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.NormalizeEvent);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Location = new System.Drawing.Point(788, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 120);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histogram";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 19);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(109, 23);
            this.button20.TabIndex = 17;
            this.button20.Text = "Full";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.GetFullHistogramEvent);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(6, 65);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(109, 23);
            this.button21.TabIndex = 19;
            this.button21.Text = "Green";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.GetGreenHistogramEvent);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(6, 42);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(109, 23);
            this.button22.TabIndex = 18;
            this.button22.Text = "Red";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.GetRedHistogramEvent);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(6, 88);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(109, 23);
            this.button23.TabIndex = 2;
            this.button23.Text = "Blue";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.GetBlueHistogramEvent);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(6, 111);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(109, 23);
            this.button19.TabIndex = 20;
            this.button19.Text = "Sobel";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.EdgeDetectionSobelEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Processor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button19;
    }
}

