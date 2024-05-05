using _12_OrnekInterface.Firin.Abstract;
using _12_OrnekInterface.Firin.Concrete;
using _12_OrnekInterface.Futbol.Abstract;
using _12_OrnekInterface.Futbol.Concrete;
using _12_OrnekInterface.Lokanta;

namespace _12_OrnekInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Firin

            #region Concrete Instance Alma

            //Usta HasanUsta = new Usta();
            //HasanUsta.AdSoyad = "HAsan Yılmaz";

            //Makina makina = new Makina();
            //makina.Marka = "Yamaha"; 
            #endregion

            #region Interface Uzerinden Instance Alma
            //Gevsek Baglılık Denir

            IYogurma Yogurucu = new Usta();
            IYogurma Yogurucu1 = new Makina();


            #endregion

            KaraFirin karaFirin = new KaraFirin();
            // karaFirin.EkmekPisir(HasanUsta);
            // karaFirin.EkmekPisir(makina); 

            #endregion

            #region Lokanta 

            Tavuk tavuk = new Tavuk();
            Kofte kofte = new Kofte();
            Pilav pilav = new Pilav();
            KuruFasulye kuru = new KuruFasulye();

            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir(tavuk, pilav, kuru, kofte);

            // balkan Lokantasi icin 

            List<IPisir> yemekler = new List<IPisir>();
            yemekler.Add(pilav);
            yemekler.Add(kuru);
            yemekler.Add(kofte);
            yemekler.Add(tavuk);
            Salata salata = new Salata();
            //yemekler.Add(salata);
            BalkanLokantasi balkanLokantasi = new();
            balkanLokantasi.YemekPisir(yemekler);


            #endregion

            #region Futbol

            //Hepsi Farkli Methodlar Gosterir. Kullanim Amacina gore secim yapilir.

            IKaleci kaleci = new Kaleci();        //Sadece IKaleci Ozellikleri gelir.(Tipi IKaleci old. icin )

            BaseFutbolcu kaleci2 = new Kaleci();  //Base Abstract old icin sadece kalitim alan classlar newlenebilir.

            IFutbolcu kaleci3 = new Kaleci();     //Sadece IFutbolcu Ozellikleri gelir 

            Kaleci kaleci4 = new Kaleci() { AdSoyad = "Ali Yılmaz", Mevki = Mevki.Kaleci }; //Kalecinin Tum Ozellikleri Burada Gozukur.

            //Kaleci4 e object initializer ile veri girildi.



            List<BaseFutbolcu> futbolcular = new List<BaseFutbolcu>();

            futbolcular.Add(kaleci2);      //BaseFutbolcu Turunden Oldugu İcin kaleci ve kaleci3 kabul etmez.
            futbolcular.Add(kaleci4);

            Takim Besiktas = new Takim(futbolcular); 
            #endregion

        }
    }
}
