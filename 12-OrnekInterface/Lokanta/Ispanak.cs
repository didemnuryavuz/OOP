using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OrnekInterface.Lokanta
{
    public class Ispanak : IPisir
    {
        public void Pisir()
        {
            Console.WriteLine("Pişti.");
        }

    }
}
