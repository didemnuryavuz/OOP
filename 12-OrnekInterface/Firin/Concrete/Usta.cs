using _12_OrnekInterface.Firin.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OrnekInterface.Firin.Concrete
{
    public class Usta : IYogurma
    {
        public string AdSoyad { get; set; }
        public void HamurYogur()
        {
            Console.WriteLine($"{AdSoyad} Usta Hamur Yoğurdu");
        }
    }
}
