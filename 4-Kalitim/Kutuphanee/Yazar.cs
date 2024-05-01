using _4_Kalitim.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4_Kalitim.Kutuphanee
{
    //Kisi Sinifi Tekrar Tanimlamayip using namespace vererek personellerden alabiliriz
    public class Yazar : Kisi
    {

        public DateTime  DogumTarihi { get; set; }
        public List<Kitap> Kitaplar { get; set; }   //Bire çok bir kitabım bir yazari olur bir yazarin bir cok kitabi olabilir.


    }
}
