using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Personel : Kisi
    {
        // Burada Miras aldigimiz base sinifin yapici metoduna parametre gondermek icin 
        //base keyword'u kullanilir
        public Personel(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Departman = Departman.Satis;
        }
        public Departman Departman { get; set; }
        public decimal Maas { get; set; } = 17001.0m;
    }
}
