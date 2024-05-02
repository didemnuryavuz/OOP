using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor
{

    /*
     * Custroctur => Yapici Metod Bir Siniftan instance alindiginda ilk calisan
     * 
     * Ozel bir metoddur. Bu metodun geri donus tipi yoktur.
     * 
     * Sinif ile ayni isimnde olmak zorundadir.
     * 
     * Nesne ilk olusturuldugunda dişaridan parametre almak icin yada
     * Bazi Property'lere default deger vermek icin Constructer kullanilir
     * 
     */

    public class Otomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public KnownColor Renk { get; set; }
        public Otomobil()
        {
            
        }
        //1.Overload Edilmis Method
        public Otomobil(string marka)
        {
            Marka= marka;
        }
        public Otomobil(string marka,string model)
        {
            Marka = marka;
            Model = model;
        }
        public Otomobil(string marka, string model,KnownColor renk)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
        }
        public void Start() { }
        public void Stop() { }
        public void KlimaCalistir() { }

    }
}
