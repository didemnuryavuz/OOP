using _18_GenericRepository.Okul.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Abstract
{
    public interface IOgrenci :IManager<Ogrenci>
    {
        public void SinavOl();
        public void DersDinle();

    }
}
