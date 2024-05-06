using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OtomobilInterface.Abstract
{
    public class BaseOtomobil : IOtomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public KnownColor Renk { get; set; }
        public int Yas { get; set; }

        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}
