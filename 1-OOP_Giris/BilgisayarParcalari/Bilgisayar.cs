using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOP_Giris.BilgisayarParcalari
{
    public enum BilgisayarTipi
    {
        Ogrenci = 1,
        Oyun,
        İs,
        Grafiker
    }
    public class Bilgisayar
    {
        public AnaKart Anakart { get; set; }  
        public CPU Cpu { get; set; }
        public Ram Ram { get; set; }
        public Kasa Kasa { get; set; }
        public float Fiyat { get; set; }
        public BilgisayarTipi BilgisayarTipi { get; set; }
    }
}
