using _18_GenericRepository.Okul.Abstract;
using _18_GenericRepository.Okul.Concrete;

namespace _18_GenericRepository
{
    internal class Program
    {
        //Kalitim alinan yerler ayni interfaceden besleniyorsa sorun olmaz.
        //IOgrenci : IManager<Ogrenci>
        static void Main(string[] args)
        {
            //Buradaki amac ben IOgrenciden instance aldigimde crud islemleri de gelsin istedim
            IOgrenci ogrenci = new Ogrenci("Didem", "Yavuz", true);
            
        }
    }
}
