using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class InsanKaynaklari : Personel, IInsanKaynaklari
    {
        public InsanKaynaklari(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
        }

        public void IlanVer()
        {

        }

        public void MaasHesapla()
        {

        }

        public void MulakatYap()
        {

        }
    }
}
