using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm.Hayvanlar
{
    public  class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
