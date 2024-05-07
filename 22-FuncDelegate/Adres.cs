using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_FuncDelegate
{
    public enum AdresTipi
    {
        Ev = 1,
        Isyeri,
        Yazlik,
        Kislik
    }
    public class Adres
    {
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string CaddeSokak { get; set; }
        public AdresTipi AdresTipi { get; set; }
    }
}
