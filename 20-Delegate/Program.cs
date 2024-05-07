namespace _20_Delegate
{
    //Delegate
    //Metot Tipi deklerasyonunu sağlar.
    /*
     Örnek delege:

    <erişim belirleyici> delegate <geri dönüş tipi> <delege adı>(<parametreler>)

    public delegate int Hesaplayici(int a,int b);

    Örnek delegemizin tanımlanış biçimindeki ifadelerin ne anlama geldiklerini ise sırayla şu şeklide ifade edebiliriz.

    Public: delegenin erişim belirleyicisi. Public veya private olabilir.

    int: metodun geri dönüş tipi. Yani geri dönüş tipi int olan metodları temsil ediyor.

    Hesaplayici: delegenin adı.

    int a, int b: delegemiz, int tipinde iki adet parametre alan metodları temsil ediyor.

    Yukarıda tanımlanan Hesaplayici adlı delege, int tipinde değerler döndüren ve int tipinde iki adet parametre alan metodları temsil etmektedir.
   */
    internal class Program
    {
        // Burada Delegasyon ,tanimalamisi yapilir.
        // Bu su anlamdadir.
        // icerisine iki adet integer parametre alan ve geri donus tipi int olan herhangi bir metodu temsil edebilir

        public delegate int Hesaplayici(int a, int b);
        public delegate bool FilterCriteria(int number);
        static void Main(string[] args)
        {
            // Burada tanimlanan delegasyondan bir instance alinir.
            // Delegeler referans tipli tanimlamalardir
            // burada toplama metodu temsil eden bir instance alinmistir.
            // instance alinirken sadece metod ismi verilir.
            // Bu metodu cagircak olan temsilcinin Invoke isminde bir metodu vardir.

            Hesaplayici hesap = new Hesaplayici(Topla);


            //Asagida ise Testc Metoduna bu delegate'i parametre olarak gectim 
            //Testc(hesap,3,5);
            //Console.WriteLine( hesap.Invoke(5, 3));

            #region Delegate'ler birden fazla metodu temsil edebilirler
            // Boylersi durumda tanimlama sirasina gore temsil ettigi butun metodlari cagirir
            //hesap += Carp;
            //Console.WriteLine("En Son Cagriln Metodun Sonucu :"+hesap.Invoke(5, 3));
            //hesap += Cikart;
            //Console.WriteLine("En Son Cagrilan Metodun Sonucu :" + hesap.Invoke(5, 3));

            #endregion
            #region Delegate ve Listeler

            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> sonuc = IkiyeBolunenler(sayilar);
            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> sonuc2 = UceBolunenler(sayilar);


            #region Delegasyon ile

            //FilterCriteria ciftSayilar = new FilterCriteria(CiftSayilar);
            //FilterCriteria tekSayilar = new FilterCriteria(TekSayilar);

            //List<int> ciftSonuc = Filter(sayilar, ciftSayilar);
            //List<int> tekSonuc = Filter(sayilar, tekSayilar);
            #endregion

            #region  Diger Tanimlama Turu

            // Buradaki tanimlama tipi => Lamda expresion ile yapilir 
            // C# arka tarafta buna anonim bir isim verir.
            // Yani Anonim bir metod tanimlamasi yapilabilir.
            // Burada sayi metoun aldigi paramtre ismidir
            // Tipini geri donus işleminden anlar. 

            FilterCriteria ciftSayilar = (sayi) => { return sayi % 2 == 0; };

            List<int> sonuclar = Filter(sayilar, ciftSayilar);

            
            List<int> sonuclarLamda = sayilar.Where(sayi => sayi % 2 == 0).ToList();

            #endregion
            #endregion

            Console.WriteLine("Hello, World!");
        }
        static bool TekSayilar(int sayi)
        {
            return sayi % 2 == 1;
        }
        static bool CiftSayilar(int sayi)
        {
            return sayi % 2 == 0;
        }
        static List<int> Filter(List<int> numbers, FilterCriteria filter)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static List<int> IkiyeBolunenler(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static List<int> UceBolunenler(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static void Testc(Hesaplayici hesaplayici, int a, int b)
        {
            hesaplayici.Invoke(a, b);
        }

        public static int Topla(int a, int b)
        {
            Console.WriteLine("Toplam:" + (a + b));
            return a + b;
        }
        public static int Carp(int a, int b)
        {
            Console.WriteLine("Carpim:" + (a * b));
            return a * b;
        }
        public static int Cikart(int a, int b)
        {
            Console.WriteLine("Çıkartma Sonucu:" + (b - a));
            return b - a;
        }
    
    }
}
