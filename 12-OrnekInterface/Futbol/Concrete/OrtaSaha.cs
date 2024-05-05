using _12_OrnekInterface.Futbol.Abstract;

namespace _12_OrnekInterface.Futbol.Concrete
{
    public class OrtaSaha : BaseFutbolcu, IOrtaSaha
    {
        public void OyunuKur()
        {
            Console.WriteLine(AdSoyad + " Oyun Kurdu");
        }

        public void PasTrafigiYap()
        {
            Console.WriteLine(AdSoyad + " Pas Yapti");
        }

        public void PressYap()
        {
            Console.WriteLine(AdSoyad + " Pres Yapti");
        }
    }
}
