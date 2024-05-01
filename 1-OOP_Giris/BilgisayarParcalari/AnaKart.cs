using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOP_Giris.BilgisayarParcalari
{
    public enum RamTipi : byte     //Defult int biz byte atadik
    {
        DDR1=1,
        DDR2, 
        DDR3, 
        DDR4, 
        DDR5, 
        DDR6
    }
    public class AnaKart
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public RamTipi RamTipi { get; set; }
        public bool Wifi { get; set; }
        public float Fiyat { get; set; }
    }
}
