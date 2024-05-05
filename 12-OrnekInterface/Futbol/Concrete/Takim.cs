using _12_OrnekInterface.Futbol.Abstract;

namespace _12_OrnekInterface.Futbol.Concrete
{
    public class Takim
    {

        //readonly filed alanlarina sadece tanimlandiklari yerde 
        // Yada Constructer icerisinde atama yapilabilir
        private readonly List<BaseFutbolcu> _futbolcular;

        //Constructor injection
        public Takim(List<BaseFutbolcu> futbolcular)
        {
            _futbolcular = futbolcular;
        }

        public override string ToString()
        {

            string sonuc = "";
            foreach (var item in _futbolcular)
            {
                sonuc += item.AdSoyad + "=>" + item.Mevki + "\n";
            }

            return sonuc;
        }
    }
}
