using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface.Personeller.Abstract
{
    public interface IFinans
    {
        public void KdvHesapla();

        public void GelirVergisiHesapla();

        public void FaturaKes();

    }
}
