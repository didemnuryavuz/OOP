using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Sekreter : Personel
    {
        public Sekreter(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Maas += 1000;
        }
    }
}
