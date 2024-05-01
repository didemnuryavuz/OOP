using _4_Kalitim.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Kutuphanee
{
    public class Kutuphane
    {
        public string KutuphaneAdi { get; set; }
        public Adres Adres { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public List<YazılıMetin> YazılıMetinler { get; set; }
        public List<Uye> Uyeler { get; set; }
        public TimeOnly AcilisSaati { get; set; }
        public TimeOnly KapanisSaati { get; set; }
        public List<Personel> Personeller { get; set; }

    }
}
