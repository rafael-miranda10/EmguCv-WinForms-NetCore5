
namespace EmguCvDemo
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.histogramBoxColor = new Emgu.CV.UI.HistogramBox();
            this.histogramBoxGray = new Emgu.CV.UI.HistogramBox();
            this.btnColorHist = new System.Windows.Forms.Button();
            this.btnGrayhist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBoxGray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 21);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(133, 29);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 67);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(523, 442);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(559, 67);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(520, 442);
            this.panAndZoomPictureBox1.TabIndex = 3;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.Location = new System.Drawing.Point(167, 21);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(133, 29);
            this.btnGrayScale.TabIndex = 4;
            this.btnGrayScale.Text = "Grayscale Image";
            this.btnGrayScale.UseVisualStyleBackColor = true;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // histogramBoxColor
            // 
            this.histogramBoxColor.Location = new System.Drawing.Point(12, 515);
            this.histogramBoxColor.Name = "histogramBoxColor";
            this.histogramBoxColor.Size = new System.Drawing.Size(523, 321);
            this.histogramBoxColor.TabIndex = 2;
            this.histogramBoxColor.TabStop = false;
            // 
            // histogramBoxGray
            // 
            this.histogramBoxGray.Location = new System.Drawing.Point(559, 515);
            this.histogramBoxGray.Name = "histogramBoxGray";
            this.histogramBoxGray.Size = new System.Drawing.Size(520, 321);
            this.histogramBoxGray.TabIndex = 2;
            this.histogramBoxGray.TabStop = false;
            // 
            // btnColorHist
            // 
            this.btnColorHist.Location = new System.Drawing.Point(322, 20);
            this.btnColorHist.Name = "btnColorHist";
            this.btnColorHist.Size = new System.Drawing.Size(138, 29);
            this.btnColorHist.TabIndex = 5;
            this.btnColorHist.Text = "Color Histogram";
            this.btnColorHist.UseVisualStyleBackColor = true;
            this.btnColorHist.Click += new System.EventHandler(this.btnColorHist_Click);
            // 
            // btnGrayhist
            // 
            this.btnGrayhist.Location = new System.Drawing.Point(476, 20);
            this.btnGrayhist.Name = "btnGrayhist";
            this.btnGrayhist.Size = new System.Drawing.Size(166, 29);
            this.btnGrayhist.TabIndex = 6;
            this.btnGrayhist.Text = "Grayscale Histogram";
            this.btnGrayhist.UseVisualStyleBackColor = true;
            this.btnGrayhist.Click += new System.EventHandler(this.btnGrayhist_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 848);
            this.Controls.Add(this.btnGrayhist);
            this.Controls.Add(this.btnColorHist);
            this.Controls.Add(this.histogramBoxGray);
            this.Controls.Add(this.histogramBoxColor);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Principal";
            this.Text = "Emgu Cv Demo";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBoxGray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.Button btnGrayScale;
        private Emgu.CV.UI.HistogramBox histogramBoxColor;
        private Emgu.CV.UI.HistogramBox histogramBoxGray;
        private System.Windows.Forms.Button btnColorHist;
        private System.Windows.Forms.Button btnGrayhist;
    }
}

