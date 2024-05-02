using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class FinansMuduru : Personel
    {
        public FinansMuduru(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Departman=Departman.Yonetim;
            Maas += 20000;
        }
    }
}
