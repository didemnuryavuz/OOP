using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface.Personeller.Concrete
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }

        public Kisi(string ad, string soyad, bool cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

    }
}
