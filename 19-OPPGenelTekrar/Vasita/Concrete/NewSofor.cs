using _19_OPPGenelTekrar.Vasita.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OPPGenelTekrar.Vasita.Concrete
{
    public class NewSofor : IEhliyet
    {
        private readonly ISurulebilir arac;
        private readonly ICollection<ISurulebilir> araclar;

        public NewSofor(ISurulebilir arac)
        {
            this.arac = arac;
        }
        public NewSofor(ICollection<ISurulebilir> araclar)
        {

            this.araclar = araclar;
        }

        public bool EhliyetVarmi { get; set; }
        public EhliyetTipi EhliyetTipi { get; set; }

        public void AracKullan()
        {
            arac.Sur();
        }

        public void AraclariKullan()
        {

            switch (EhliyetTipi)
            {
                case EhliyetTipi.A:
                    break;
                case EhliyetTipi.B:
                    {
                        foreach (var item in araclar)
                        {
                            if (item is Otomobil)
                            {
                                item.Sur();
                            }
                        }

                    }
                    break;
                case EhliyetTipi.C:
                    foreach (var item in araclar)
                    {
                        if (item is Otomobil || item is Minibus)
                        {
                            item.Sur();
                        }
                    }
                    break;
                case EhliyetTipi.D:
                    foreach (var item in araclar)
                    {
                        if (item is Otomobil || item is Minibus || item is Otobus)
                        {
                            item.Sur();
                        }
                    }
                    break;
                case EhliyetTipi.E:
                    foreach (var item in araclar)
                    {
                        item.Sur();

                    }
                    break;
            }

        }
    }
}
