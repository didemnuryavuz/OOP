using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class SatisPersoneli : Personel
    {
        private int _prim;
        public SatisPersoneli(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Maas += 3000+_prim;
        }
    }
}
