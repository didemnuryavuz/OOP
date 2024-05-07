namespace _22_FuncDelegate
{
    internal class Program
    {
        //Func delegesi Action’a benzer bir yapıdadır ama Actiondan farklı olarak bir dönüş değeri vardır.
        //Func delegesinin tanımlarına baktığımızda iki farklı kullanım görebiliriz.Hiç parametre almadan bir değer dönebilir.
        // Func delegate T tipinden geri donus degeri olan metodlari temsil eder.
        // Func Delegate'lere predicate de denir. Linq sorgularinda siklikla kullanilir
        /* Func<T>
         * Func<T,Tresult>
         * Func<T,T2,Tresult>
         * Func<T,T2.......,Tresult> 16 parametre alabilecek sekildedir
         * 
         * En son parametre mutlaka geri donus tipi olmak zorundadir
        */
        static void Main(string[] args)
        {
            #region Func Delegate

            ////Bu Func delegate int alip ,geriye integer doner
            //Func<int,int> kareAl =(sayi)=> sayi*sayi;
            //Console.WriteLine(kareAl(3));

            //// iki adet int deger alan ve geriye int donen Func delegate 
            //Func<int, int, int> topla = (a, b) => (a + b);

            //Console.WriteLine(topla(3,5)); 
            #endregion
            Adres adres1 = new Adres()
            {
                Sehir = "Istanbul",
                Ilce = "Kadikoy",
                AdresTipi = AdresTipi.Ev

            };
            Adres adres2 = new Adres()
            {
                Sehir = "Istanbul",
                Ilce = "Taksim",
                AdresTipi = AdresTipi.Isyeri

            };
            Adres adres3 = new Adres()
            {
                Sehir = "Istanbul",
                Ilce = "Besiktas",
                AdresTipi = AdresTipi.Isyeri

            };

            Adres adres4 = new Adres()
            {
                Sehir = "Izmir",
                Ilce = "Foca",
                AdresTipi = AdresTipi.Yazlik

            };
            Adres adres5 = new Adres()
            {
                Sehir = "Bursa",
                Ilce = "Cekirge",
                AdresTipi = AdresTipi.Kislik

            };

            List<Adres> adresler = new List<Adres>();
            adresler.Add(adres1);
            adresler.Add(adres2);
            adresler.Add(adres3);
            adresler.Add(adres4);
            adresler.Add(adres5);

            List<Adres> result = adresler.Where(p => p.Sehir == "Istanbul").ToList();

            result.ForEach(p => Console.WriteLine(p.Sehir + " " + p.Ilce + " " + p.AdresTipi));
        }
    }
}
