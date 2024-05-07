using _19_OPPGenelTekrar.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OPPGenelTekrar.Loglama.Concrete
{
    public class NewLogger :ILogger
    {
        //Nesnenin ismi degil , yapabildikleri onemli
        //Bana logla öetodunu iceren ve icerisinde string bir deger alan methodu varsa
        //Gerisi bizim icin onemli degil

        readonly ILogger _logger;

        public NewLogger(ILogger logger)
        {
            _logger= logger;
        }

        public void Logla(string message)
        {
            _logger.Logla(message);
        }

        
    }
}
