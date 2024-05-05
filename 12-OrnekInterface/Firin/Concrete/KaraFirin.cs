using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_OrnekInterface.Firin.Abstract;

namespace _12_OrnekInterface.Firin.Concrete
{
    public class KaraFirin
    {
        public void EkmekPisir(IYogurma yogurucu) 
        {
            yogurucu.HamurYogur();
        }
       

    }
}
