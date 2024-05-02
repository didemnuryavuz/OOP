using _5_Constructor.Personeller;
using System.Data.SqlClient;

namespace _5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Otomobil

            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Tofaş";
            otomobil.Model = "Kartal";
            otomobil.Renk = System.Drawing.KnownColor.White;

            //Bu Kullanima Yapici Metodu olan kullanim bicimi denir
            //İnstance alirken defualt deger atamak istiyorsak ctor kullanilmali
            Otomobil otomobil1 = new Otomobil("Tofas", "Serce", System.Drawing.KnownColor.Black);
            #endregion

            #region Personel

            //Burada sekreteri newleyebilmek icin base personele gider oradan personeli newleyebilmek icin base kisiye gider.
            //Orada ad soyad cinsiyeti atayip doner personeli newler sonrasinda sekreteri newler.

            //Sekreter ayse = new Sekreter("Ayse","Kaya",true);

            ITPersoneli Ali = new ITPersoneli("Ali","Yilmaz",false);

            SatisPersoneli satis = new("", "", false); //Kisideki is kuralini kontrol

            FinansMuduru finansMuduru = new("", "", false);

            //Personel mudur = new Personel("ayse", "kaya", false, Departman.Yonetim);
            //SatisPersoneli satis = new("", "", false);

            #endregion

            #region Sql Connection

            SqlConnection sqlCon = SqlBaglanti.BaglantiVer();
            #endregion


        }
    }
}
