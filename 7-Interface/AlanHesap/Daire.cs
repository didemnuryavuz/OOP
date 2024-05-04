using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm.AlanHesap
{
    public class Daire :  GeometrikSekil
    {
        public override double AlanHesapla()
        {
            return ((Math.PI) * (Math.Pow(Yaricap, 2)));
        }
        public override double CevreHesapla()
        {
            return (2 * (Math.PI) * Yaricap);
        }
    }
}
