using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_TekrarLib.Personeller.Concrete
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }

        public List<Adres> adresler { get; set; } = new List<Adres>();

        public Kisi()
        {
            Console.WriteLine("Kisi class Constructer calisti");
        }
        //Static constructor sadece ilk instance da calisir diger instance da calismaz
        static Kisi()
        {
            Console.WriteLine("Kisi class Static calisti");
        }

        public Kisi(string ad, string soyad, bool cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

    }
}
