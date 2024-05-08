using _26_TekrarLib.Personeller.Concrete;
namespace _26_GenelTekrar
{
    internal class Program
    {
        //Constructorlardan biri public digeri static olarak ayni parametreli tanimlandiginda
        //Statik kurucu, sınıfınızın somutlaştırılmasından önce yalnızca bir kez çalışır.
        //Bir şeyin sadece bir kez olmasını istiyorsanız kullanılır

        //SqlConnection class'i sealed classtir. İnstance alinir kalitim vermez.Abstract class'in tersi
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi("Didem","Yavuz",true);
           

        }
    }
}
