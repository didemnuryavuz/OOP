using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class MuhasebePersoneli : Personel
    {
        public MuhasebePersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Departman = Departman.Finans;
            Maas += 5000;
        }
    }
}
