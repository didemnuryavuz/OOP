using _12_OrnekInterface.Futbol.Abstract;

namespace _12_OrnekInterface.Futbol.Concrete
{
    public class Forvet : BaseFutbolcu, IForvet
    {
        public void GolAt()
        {
            Console.WriteLine(AdSoyad + " Gol Atti");
        }

        public void PenaltiCek()
        {
            Console.WriteLine(AdSoyad + " Penalti Kullandi");
        }
    }
}
