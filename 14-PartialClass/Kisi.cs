using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PartialClass
{
    //Bir class'in kodlarini 2 farkli dosyada tutmak istedigimizde partial class kullanilir
    public partial class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
    }
}
