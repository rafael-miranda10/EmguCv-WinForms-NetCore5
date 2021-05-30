using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCvDemo.Applications.Interfaces
{
    public interface IEmguCvBasicOperation
    {
        Image<Bgr, byte> CarregarImagem(string path);
        void ShowImagem(string titulo, Image<Bgr, byte> image);
        Image<Gray, byte> ConverterEscalaDeCinza(Image<Bgr, byte> image);
        Mat ObterHistogramaPorCanalRGB(int canal, Image<Bgr, byte> image);
        Mat ObterHistogramaEscalaDeCinza(Image<Gray, byte> image);
    }
}
