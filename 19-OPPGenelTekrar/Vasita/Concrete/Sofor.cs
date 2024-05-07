using _19_OPPGenelTekrar.Vasita.Abstract;

namespace _19_OPPGenelTekrar.Vasita.Concrete
{
    public class Sofor 
    {
        private readonly Otomobil otomobil;
        private readonly Minibus minibus;
        private readonly Otobus otobus;

        public Sofor(Otomobil otomobil)
        {
            this.otomobil = otomobil;
        }

        public Sofor(Minibus minibus)
        {
            this.minibus = minibus;
        }
        public Sofor(Otobus otobus)
        {
            this.otobus = otobus;
        }
    }
}
