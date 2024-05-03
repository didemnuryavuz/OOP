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

            //Bir Nesnenin Instance Alindigindaki Durum

            #region GetHashCode

            Temp temp = new Temp();     //Burada farklı bolgelerde tutulur hafizada
            Temp temp1 = new Temp();
            Temp temp2 = new Temp();

            //GetHashCode metodu nesnenin hash algoritmasina gore kodunu verir
            //İnstance alinan nesnelerin ayni nesne olup olmadigini anlamaya yarar.

            
            Console.WriteLine(temp.GetHashCode());
            Console.WriteLine(temp1.GetHashCode());
            Console.WriteLine(temp2.GetHashCode());

            
            Console.WriteLine("---------------------");

            SqlConnection connection = SqlBaglanti.BaglantiVer();    //Burada hepsi ayni adresi tutar hafizada
            SqlConnection connection1 = SqlBaglanti.BaglantiVer();   //Singleton Dizayn Pattern = Bir Nesne Olusturur 
            SqlConnection connection2 = SqlBaglanti.BaglantiVer();   //Ve Her istendiginde o nesne kullanilir

            Console.WriteLine(connection.GetHashCode());
            Console.WriteLine(connection1.GetHashCode());
            Console.WriteLine(connection2.GetHashCode());
            #endregion

            #region Equals

            //Console.WriteLine("********************");
            //Console.WriteLine( temp.Equals(temp1));
            //Console.WriteLine(temp1.Equals(temp1));
            //Console.WriteLine(temp1.Equals(temp2));
            //Console.WriteLine("********************");

            //Console.WriteLine(connection1.Equals(connection2));
            //Console.WriteLine(connection2.Equals(connection3));
            //Console.WriteLine(connection3.Equals(connection1)); 


            #endregion


            #region GetType

            //Reflections konusu ile ilgiildir.
            //GetType(). field ,method,prop enum ctor gibi ozellikleri gorebiliriz
            Console.WriteLine(temp.GetType().Name);
            Console.WriteLine(temp.GetType().FullName);    //Namespace+Name
            Console.WriteLine(temp.GetType().Namespace);

            //var sonuc = ali.GetType().GetProperties();
            //foreach (var prop in sonuc)
            //{
            //    Console.WriteLine(prop.Name + " " + prop.CanWrite);
            //    Console.WriteLine();
            //}
            //var metodlar = ali.GetType().GetMethods();
            //foreach (var method in metodlar)
            //{
            //    Console.WriteLine(method.Name);

            //}

            #endregion


        }
    }
}
