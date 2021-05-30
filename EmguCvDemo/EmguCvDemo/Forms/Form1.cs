using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.UI;
using EmguCvDemo.Applications.Interfaces;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace EmguCvDemo
{
    public partial class Principal : Form
    {
        private Image<Bgr, byte> _inputImage;
        private Image<Gray, byte> _grayImage;

        private readonly IEmguCvBasicOperation _emguCvBasicOperation;
        public Principal(IEmguCvBasicOperation emguCvBasicOperation)
        {
            _emguCvBasicOperation = emguCvBasicOperation;
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            //string fileName = "D:\\Lenna.png";
            string fileName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            fileName = Directory.GetParent(Directory.GetParent(fileName).FullName).FullName;
            fileName = Directory.GetParent(Directory.GetParent(fileName).FullName).FullName;
            fileName += "\\images\\Lenna.png";


            _inputImage = _emguCvBasicOperation.CarregarImagem(fileName);

            if (_inputImage is null)
            {
                MessageBox.Show("Image is not read.");
                return;
            }

            imageBox1.Image = _inputImage;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Everything;

            _emguCvBasicOperation.ShowImagem("Imagem Loaded", _inputImage);
            Console.WriteLine($"Finished at :{DateTime.Now}");
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            _grayImage = _emguCvBasicOperation.ConverterEscalaDeCinza(_inputImage);
            panAndZoomPictureBox1.Image = _grayImage.ToBitmap();
        }

        private void btnColorHist_Click(object sender, EventArgs e)
        {
            var canalRGB = 0;
            histogramBoxColor.Image = _emguCvBasicOperation.ObterHistogramaPorCanalRGB(canalRGB, _inputImage);
            histogramBoxColor.Refresh();
            CvInvoke.Imshow("2", _emguCvBasicOperation.ObterHistogramaPorCanalRGB(1, _inputImage));
            CvInvoke.Imshow("3", _emguCvBasicOperation.ObterHistogramaPorCanalRGB(2, _inputImage));
        }

        private void btnGrayhist_Click(object sender, EventArgs e)
        {
            histogramBoxGray.DisplayedImage = _emguCvBasicOperation.ObterHistogramaEscalaDeCinza(_grayImage);
            histogramBoxGray.Refresh();
        }
    }
}
