using _16_InsanKaynaklariInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Concrete
{
    public class FinansBasvuru :BaseBasvuru,IFinansBasvuru
    {
        public bool isExcel { get; set; }
        public bool isLogo { get; set; }

        public void BilancoHazirla()
        {
            throw new NotImplementedException();
        }

        public void MaasHesapla()
        {
            throw new NotImplementedException();
        }

        public void NakitAkisDuzenle()
        {
            throw new NotImplementedException();
        }

        public void VergiHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
