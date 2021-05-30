using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using EmguCvDemo.Applications.Interfaces;
using System.Drawing;

namespace EmguCvDemo.Applications.App
{
    public class EmguCvBasicOperation : IEmguCvBasicOperation
    {
        private HistogramBox _histogramBox;
        private DenseHistogram _denseHistogram;
        private Mat _mat;

        public EmguCvBasicOperation()
        {
            _histogramBox = new HistogramBox();
            _mat = new Mat();
        }

        public Image<Bgr, byte> CarregarImagem(string path)
        {
            return new Image<Bgr, byte>(path);
        }

        public Image<Gray, byte> ConverterEscalaDeCinza(Image<Bgr, byte> image)
        {
            return image.Convert<Gray, byte>();
        }

        //Todo: receber via parametros os valores de 0 a 256
        public Mat ObterHistogramaEscalaDeCinza(Image<Gray, byte> image)
        {
            _denseHistogram = new DenseHistogram(256, new RangeF(0, 255));
            _denseHistogram.Calculate(new Image<Gray, byte>[] { image }, false, null);
            _denseHistogram.CopyTo(_mat);
            return _histogramBox.GenerateHistogram("Grayscale histogram", Color.Blue, _mat, 256, new float[] { 0, 256 });
        }

        //Todo: receber via parametros os valores de 0 a 256
        public Mat ObterHistogramaPorCanalRGB(int canal, Image<Bgr, byte> image)
        {
            _denseHistogram = new DenseHistogram(256, new RangeF(0, 255));
            _denseHistogram.Calculate(new Image<Gray, byte>[] { image[canal] }, false, null);
            _denseHistogram.CopyTo(_mat);
            var nomeCanal = (canal == 1) ? "Blue" : (canal == 2) ? "Green" : "Red";
            return _histogramBox.GenerateHistogram("Channel histogram "+nomeCanal, Color.Blue, _mat, 256, new float[] { 0, 256 });
        }

        public void ShowImagem(string titulo, Image<Bgr, byte> image)
        {
            CvInvoke.Imshow(titulo, image);
        }
    }
}
