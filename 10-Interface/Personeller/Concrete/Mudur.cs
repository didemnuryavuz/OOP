using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class Mudur : Personel, IInsanKaynaklari
    {
        public Mudur(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
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
