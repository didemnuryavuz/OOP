using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26_TekrarLib.Personeller.Abstract;

namespace _26_TekrarLib.Personeller.Concrete
{
    public class Sekreter : Personel, ISekreter
    {
        public Sekreter(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {

        }

        public void TelefonlaraBak()
        {

        }

        public void ToplantilariOrganizeEt()
        {

        }
    }


}
