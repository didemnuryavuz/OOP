using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Interface.Personeller.Abstract;

namespace _10_Interface.Personeller.Concrete
{
    public class MuhasebePersoneli : Personel, IFinans
    {
        public MuhasebePersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

        public void FaturaKes()
        {

        }

        public void GelirVergisiHesapla()
        {

        }

        public void KdvHesapla()
        {

        }
    }
}
