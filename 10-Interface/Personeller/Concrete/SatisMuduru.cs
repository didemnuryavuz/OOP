using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class SatisMuduru : Mudur, ISatisPersoneli
    {
        public SatisMuduru(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
        }

        public void MusteriAra()
        {

        }

        public void MusterilerleToplantiYap()
        {

        }

        public void SatisRaporuHazirla()
        {

        }
    }
}
