using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set 
            {
                if (value<18)
                {
                    throw new Exception("18 Yaşından Küçük Eleman Çalıştırılamaz");
                }
                _yas = value; 
            }
        }

        public string GSM { get; set; }
        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                if (!value.Contains("@") && !value.Contains("com"))
                {
                    throw new Exception("Email Düzgün Formatta Olmalı");
                }
                _email = value; 
            }
        }

        public bool Cinsiyet { get; set; }
        
        public Kisi(string ad , string soyad, bool cinsiyet)
        {
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
            {
                Ad = ad;
                Soyad = soyad;
                Cinsiyet = cinsiyet;
            }
            else
            {
                throw new Exception("Isim Ve Soy isim alanlari Boş Gecilemez");
            }
            //Eger Adres Class'i Kalitim Vermeseydi Property olarak tanimlanabilirdi.
            //Boyle bir durumda Bu proerty'i new lemek gerekir
            //Adress = new Adres { Sehir = "Istanbul", Ilce = "Kadikoy", Ulke = "Turkiye" };

            Sehir = "İstanbul";
            Ilce = "Kadikoy";
            Ulke="Turrkiye";
            
        }
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

        
    }
}
