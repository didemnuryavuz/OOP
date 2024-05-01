using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Personeller
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        public string KisiBilgileriVer()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }

        // object veri tipinden gelen ToString() Metodunu ezip Yerine kendi
        // kodlarimi calistirmasini istiyorum

        public override string ToString()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }

        //public Adres Adres { get; set; }
    }
}
