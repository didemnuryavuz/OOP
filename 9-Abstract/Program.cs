namespace _9_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Piyano piyano = new Piyano();
            piyano.Marka = "Yamaha";
            piyano.Cal();
            Gitar gitar = new Gitar();
            gitar.Marka = "Fender";
            gitar.Model = "xyz";
            Flut flut = new Flut();
            flut.Marka = "Helvacioğlu";

            Muzisyen muzisyen = new Muzisyen();

            muzisyen.muzikAletleri.Add(flut);
            muzisyen.muzikAletleri.Add(piyano);
        }
    }
}
