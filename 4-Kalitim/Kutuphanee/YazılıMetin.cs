using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Kutuphanee
{
    public class YazılıMetin
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime BasimYili { get; set; }
        public string YayinEvi { get; set; }
        public Kategoriler Kategori { get; set; }
        public decimal Fiyat { get; set; }

    }
}
