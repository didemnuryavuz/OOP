using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OrnekInterface.Lokanta
{
    public class BalkanLokantasi
    {
        //SOLİD in D si
        //2 Mayıs 1.00 saat
        public void YemekPisir(List<IPisir> pisirilecekler)
        {
            foreach (var item in pisirilecekler)
            {
                item.Pisir();
            }
        }
    }
}
