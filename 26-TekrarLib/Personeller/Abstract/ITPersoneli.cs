using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26_TekrarLib.Personeller.Concrete;

namespace _26_TekrarLib.Personeller.Abstract
{
    public class ITPersoneli : Personel, IITPersonel
    {
        public ITPersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Departman = Departman.IT;
            Maas += 10000;
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
