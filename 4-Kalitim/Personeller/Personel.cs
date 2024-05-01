using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Personeller
{
    public class Personel : Kisi
    {
        public Departman Departman { get; set; }
        public decimal Maas { get; set; } = 17001.0m;
    }
}
