using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Bilgisayarlar
{
    
    public class Bilgisayar
    {
        public AnaKart Anakart { get; set; }  
        public CPU Cpu { get; set; }
        public List<Ram> Ramler { get; set; }
        public Kasa Kasa { get; set; }
        public float Fiyat { get; set; }
        public BilgisayarTipi BilgisayarTipi { get; set; }
    }
}
