using _19_OPPGenelTekrar.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OPPGenelTekrar.Loglama.Concrete
{
    public class EmailLogger :ILogger
    {
        public string Email { get; set; }
        public void Logla(string message)
        {
            Console.WriteLine(DateTime.Now + " => " + message + " loglandi");
        }
    }
}
