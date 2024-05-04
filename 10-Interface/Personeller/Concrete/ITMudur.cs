using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class ITMudur : Mudur, IITPersonel
    {
        public ITMudur(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
        }

        public void BilgisayarArizasiCoz()
        {

        }

        public void KodYaz()
        {

        }

        public void NetworkProblemiCoz()
        {

        }

        public void WebSitesiTasarla()
        {

        }
    }
}
