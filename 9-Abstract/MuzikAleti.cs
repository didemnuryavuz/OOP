using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Abstract
{
    //MuzikAleti Base Clas oldugu icin Instance alinmasi mantikli degil Bunun icin abstract olarak(Sanal İsaretleme) yapilir.
    //Abstract methodlar sadece abstract classlar icerisinde olusturulabilir.
    //Abstract olarak isaretlenmis tum yapilar mutlaka override edilmelidir.
    //Propertylerde abstract olarak tanimlanabilir.
    public abstract class MuzikAleti
    {
        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }

        //Abstract methodlarin govdesi olmaz.
        //Kalitim verdigi classlarda mutlaka implimente edilmeleri gerekir
        //Metod govdesinin yazilmesi zorunludur.

        public abstract string Cal();
    }
}
