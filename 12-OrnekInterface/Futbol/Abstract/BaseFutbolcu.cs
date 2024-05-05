using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OrnekInterface.Futbol.Abstract
{
    public enum Mevki
    {
        Kaleci = 1,
        Defans,
        OrtaSaha,
        Forvet
    }
    public abstract class BaseFutbolcu : IFutbolcu
    {

        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Millimi { get; set; }
        public int SutGucu { get; set; }
        public int Agresiflik { get; set; }
        public int Dayaniklilik { get; set; }
        public Mevki Mevki { get; set; }

        public void Kos()
        {
            Console.WriteLine(AdSoyad + " Kostu");
        }

        public void SutCek()
        {
            Console.WriteLine(AdSoyad + " Sut Cekti");
        }


    }
}
