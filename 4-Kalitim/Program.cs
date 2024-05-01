using _4_Kalitim;
using _4_Kalitim.Personeller;
using _4_Kalitim.Kutuphanee;
using _4_Kalitim.Hayvanlar;

namespace _4_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
            
            //Bir Class Tek Bir Classtan Kalitim alir
        {
            #region Personel
            Sekreter sekreter = new Sekreter();
            //sekreter.Adres.Sehir = "Ankara";  
            //Yukaridaki kisideki => public Adres Adres { get; set; }
            //Alttaki ise kisinin adresten miras almasi
            sekreter.Sehir = "Istanbul";
            sekreter.Departman = Departman.Yonetim;
            //Asagıda kendi yazdigimiz methodun kullanimi
            sekreter.KisiBilgileriVer();
            //Asagida Object Sinifindan gelen override ettigimiz ToString Methodu
            Console.WriteLine(sekreter);
            MuhasebePersoneli muhasebe = new MuhasebePersoneli();
            muhasebe.Sehir = "Izmir";


            #endregion

            #region Temp
            object obj = new object();
           // Console.WriteLine(obj);

            Temp temp = new Temp();
           // Console.WriteLine(temp);
            #endregion

            #region Hayvan

            Kuslar karga = new Kuslar();

            karga.HareketEt();
            karga.TuyVar = true;
            karga.Yası = 5;
            karga.Yumurtlama();
            karga.BeslenmeSekli = BeslenmeSekli.HemEtHemOt.ToString();
            #endregion

            #region Kutuphane

            Kitap kitap1 = new Kitap();
            kitap1.Ad = "Sineklerin Tanrısı";
            kitap1.SayfaSayisi = 261;
            kitap1.Yazar = "William Golding";
            kitap1.Kategori = Kategoriler.Kitap;

            kitap1.Fiyat = 50;

            Kitap kitap2 = new();
            kitap2.Ad = "Otomatik Portakal";

            #endregion



        }
    }
}
