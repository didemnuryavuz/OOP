using _12_OrnekInterface.Futbol.Abstract;

namespace _12_OrnekInterface.Futbol.Concrete
{
    public class Kaleci : BaseFutbolcu, IKaleci
    {
        public void DegajYap()
        {
            Console.WriteLine(AdSoyad + " Degaj Yapti");
        }

        public void PenaltiKurtar()
        {
            Console.WriteLine(AdSoyad + " Penalti kurtardi");
        }

        public void TopuElleYakala()
        {
            Console.WriteLine(AdSoyad + " topu yakaladi");
        }
    }
}
