using Bogus;

namespace _23_DelegateTekrar
{
    internal class Program
    {
        /*
        * 
          C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.
          C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.
          Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur.
          Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.
          C# programlama dilinde int, float, double, char, byte gibi verilerin bellekte tutulmasını ifade eden veri türleri yer alır.
        * 
        */
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            #region Multicast Delegate
            //MultiCast Delegate Ornegi.
            // Birden Fazla metod temsil edebilir
            //Print printDel = PrintNumber;
            //printDel += PrintHexadecimal;
            //printDel += PrintMoney;

            //Print printDel = PrintNumber;
            //printDel += PrintHexadecimal;
            //printDel += PrintMoney;

            //printDel(100000);
            #endregion

            #region Özel Delegate Türleri

            #region Action Delegate => Bir Action'i temsil eder .
            // Herhangi bir geri donus tipi olmayan ve Herhangi bir parametre almayan delegelere Action Delagate Denir
            //1. Kullanim 
            //Action action = EkranaYaz;
            //action();
            ////2. Kullanim
            //Action action2 = ()=>Console.WriteLine("Test 2");
            //action2();
            #endregion

            #region Generic Action Delegate
            //Geriye bir deger donmeyen icerisine parametre alan metodlari tanimlar

            //1. Kullanim

            Action<int> action = EkranaYaz2;
            //action(50);

            //2. Kullanim

            Action<int> action1 = (value) => Console.WriteLine(value);
           // action1(212);

            Action<int,int> ActionUstAl=(x,y) => Console.WriteLine(Math.Pow(x,y));
            //ActionUstAl(3,4);
            #endregion

            #region Func Delegate
            //Geriye T tipinde Generic olarak geri donusu bildirebildigimiz bir delege tipidir.
            //Verilen parametreden en sonuncusu geri donus tipini belirler.

            //1.Kullanim
            Func<int, long> kareAl = (value) => value * value;

            //2.Kullanim 
            kareAl += kareAlMetod;
            //Console.WriteLine(kareAl(6)); 

            Func<int,int,int,int,int> Topla =(value1,value2,value3,value4) => value1 + value2 + value3 + value4;
           // Topla(3, 11, 84, 56);

            #endregion

            #region Predicate Delegate
            //Bu da geriye bool donen en fazla 16 adet generic tip alabilen
            //ozel bir sistem delegesidir.

            Predicate<int> TekCift = (value) => value % 2 == 0;
            // Console.WriteLine(TekCift(5));
            #endregion

            #endregion


            #region Bogus ile Fake Data Ornegi
            Faker faker = new Faker("tr");

            List<Person> people = new List<Person>();

            for (int i = 0; i < 500; i++)
            {
                people.Add(new Person("tr"));
            }

            //Linq sorgusu ile 
            //var result = people.Where(p => p.Address.City == "Giresun").ToList();
            // result.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender+" "+p.DateOfBirth));

            //Methodu yazip cagirma
            //var result2 = people.Where(p => AdanaliMi(p)).ToList();
            //result2.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.DateOfBirth));


            #endregion

            #region Bogus Sorulari
            //Yasi 20 altinda olanlarin listesi
            var liste1 = people.Where(p => (DateTime.Now.Year - p.DateOfBirth.Year) <= 20).ToList();
            foreach (Person p in liste1)
            {
                Console.WriteLine($"{p.FullName,25}, Dogum Yili: {p.DateOfBirth.Year,4}, Yasi: {DateTime.Now.Year - p.DateOfBirth.Year}");
            }

            //gmail hesabi var mi
            var liste2 = people.Where(p => p.Email != null).ToList();
            liste2.ForEach(p => Console.WriteLine(p.FullName + " " + p.Email));

            //Istanbulda yasayan erkek ve kadin dagilim
            var liste3 = people.Where(p => p.Gender.ToString() == "Male" && p.Address.City=="İstanbul").ToList();
            liste3.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender+ " "+p.Address.City));
            int erkekSayi=liste3.Count;
            var liste4 = people.Where(p => p.Gender.ToString() == "Female" && p.Address.City == "İstanbul").ToList();
            liste4.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.Address.City));
            int kadinSayi = liste4.Count;

            Console.WriteLine("İstanbulda yaşayan erkek sayisi : " + erkekSayi);
            Console.WriteLine("İstanbulda yaşayan kadin sayisi : " + kadinSayi);

            


            #endregion
        }
        public static int Yas(Person person)
        {
            DateTime dateTime = new DateTime();
            return  (person.DateOfBirth.Year) - (dateTime.Year);
        }
        public static bool AdanaliMi(Person person)
        {
            if (person.Address.City == "Adana")
                return true;
            else
                return false;
        }
        public static long kareAlMetod(int value)
        {
            return value*value;
        }
        public static void UstAl(int x, int y)
        {
            Console.WriteLine("Face Metod");
        }
        public static void EkranaYaz2(int value)
        {
            Console.WriteLine(value);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    
    }
}
