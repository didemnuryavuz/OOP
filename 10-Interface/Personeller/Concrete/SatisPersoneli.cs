using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class SatisPersoneli : Personel, ISatisPersoneli
    {
        //Base classta bulunan yapici metod. onu miras alan yerde onu karsilayan bir yapici method barindirmali
        //Burada miras aldigimiz sinifin yapici methoduna parametre yollamak icin base tanimlanir
        public SatisPersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Maas += 1000;
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
