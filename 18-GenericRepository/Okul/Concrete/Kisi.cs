using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Concrete
{
    public abstract class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }

        public List<Adres> adresler { get; set; } = new List<Adres>();

        public Kisi(string ad, string soyad, bool cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

    }
}
