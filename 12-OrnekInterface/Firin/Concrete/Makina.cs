using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_OrnekInterface.Firin.Abstract;

namespace _12_OrnekInterface.Firin.Concrete
{
    public class Makina : IYogurma,IMakinaCalis
    {
        public string Marka { get; set; }

      

        public void HamurYogur()
        {
            Console.WriteLine($"{Marka} Makine Hamur Yogurdu");
        }

        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}
