using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26_TekrarLib.Personeller.Abstract;

namespace _26_TekrarLib.Personeller.Concrete
{
    public class Personel : Kisi, IPersonel
    {
        public Departman Departman { get; set; }
        public decimal Maas { get; set; } = 17001.0m;  //İlk default degere girer sonrasinda cons. girer.
        public Personel(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {

        }
        public void IseZamanindaGel() { }
        public void VerilenGoreviYap() { }
    }
}
