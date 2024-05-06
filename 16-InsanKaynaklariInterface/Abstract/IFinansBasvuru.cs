using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Abstract
{
    public interface IFinansBasvuru
    {
        public void BilancoHazirla();
        public void VergiHesapla();
        public void MaasHesapla();
        public void NakitAkisDuzenle();
    }
}
