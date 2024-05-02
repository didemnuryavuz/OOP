using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Kalitim.Bilgisayarlar
{
    public enum RamTipi : byte     //Defult int biz byte atadik
    {
        DDR1 = 1,
        DDR2,
        DDR3,
        DDR4,
        DDR5,
        DDR6
    }

    public enum BilgisayarTipi
    {
        Ogrenci = 1,
        Oyun,
        İs,
        Grafiker
    }

    public enum KasaTipi
    {
        Mini,
        Midi,
        Tower,
        BigTower
    }

}
