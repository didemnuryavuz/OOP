using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Bilgisayarlar
{
    public class Kasa : Parca
    {
       
        public PowerSupplier PowerSupplier { get; set; }
        
        public KasaTipi KasaTipi { get; set; }
    }
}
