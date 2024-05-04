using _7_Polimorfizm.Hayvanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizim.Hayvanlar
{
    public class Leopar : Kedi
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hıss!"); 
        }

        public override void HareketEt()
        {
            Console.WriteLine("Cok Hizli Kos");
        }
    }
}
