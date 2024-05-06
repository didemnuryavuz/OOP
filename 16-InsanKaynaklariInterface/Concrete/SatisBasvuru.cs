using _16_InsanKaynaklariInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Concrete
{
    public class SatisBasvuru :BaseBasvuru,ISatisBasvuru
    {
        public bool isEhliyet { get; set; }
        public bool SeyahateEngelDurum { get; set; }
        public void MusteriZiyaretEt()
        {
            throw new NotImplementedException();
        }

        public void SatisRaporuHazirla()
        {
            throw new NotImplementedException();
        }
    }
}

