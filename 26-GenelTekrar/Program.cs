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

            #region Database Ornegi

            //string sqlConstr = "Server=.;Database=Northwind;Trusted_Connection=true;";
            //string postreConstr = "Server=127.0.0.1;Port=5432;Database=Northwind;User Id=postgres;Password=qweasd;";
            //SqlConnection sqlcon = new SqlConnection(sqlConstr);
            //NpgsqlConnection npgsqlConnection = new NpgsqlConnection(postreConstr);

            //IDbConnection postgre = new NpgsqlConnection(postreConstr);
            //IDbConnection sqlcon2 = new SqlConnection(sqlConstr);
            //postgre.Open();
            //sqlcon2.Open();
            //IDbCommand dbCommand = sqlcon2.CreateCommand();
            //IDbCommand dbCommand1 = postgre.CreateCommand();
            //dbCommand.CommandText = "Select * from Shippers";
            //dbCommand1.CommandText = "Select * from Shippers";
            // IDataReader postgreReader= dbCommand1.ExecuteReader();
            // IDataReader sqlReader = dbCommand.ExecuteReader();
            //Console.WriteLine("PostgreSql Gelen Data.............");
            //while (postgreReader.Read())
            //{
            //    Console.WriteLine($"{postgreReader[0].ToString()}\t{postgreReader[1].ToString()}\t{postgreReader[2].ToString()}  ");
            //}
            //Console.WriteLine("Sql ServerDan Gelen Data.............");
            //while (sqlReader.Read())
            //{
            //    Console.WriteLine($"{sqlReader[0].ToString()}\t{sqlReader[1].ToString()}\t{sqlReader[2].ToString()}  ");
            //}
            #endregion

            #region Delegate

            //Test test = EkranaYaz;
            //Test2 test2 = EkranaYazStr;
            //test2 += EkranaYazStr2;
            //test2 += EkranaYazStr3;

            //DelegateKullan(test2);

            #region Action Delegate
            //Geri Donus degeri olmayan ve herhangi bir parametre almayan tum methodlari temsil eder.

            Action action = () => 
            { 
               // string str = Console.ReadLine();
               // Console.WriteLine("Deneme Action "+str); 
            };

            action();
            #endregion

            #region Generic Action
            //Geri donusu olmayan ve parametre alan methodlar icin kullanilir.

            Action<string> genericAction1 = EkranaYazStr;
            Action<string> genericAction2 = (str) => { Console.WriteLine(str); };
            Action<string> genericAction3 = (str) =>  Console.WriteLine(str);


            #endregion

            #region Predicate 
            //geriye deger donen delegateler.Bool Doner 16 adet parametre alir

            Predicate<string> predicate = (str) =>  str.Contains("d"); 
            Predicate<DateTime> predicate1 =(trh) => DateTime.IsLeapYear(trh.Year);


            #endregion

            #region Func Delegate
            //Func geri donus tipini kendimiz belirledigiimz ve aldigi parametreleride kendimiz belirleyebildigimiz bir delegate tipi

            Func<DateTime,int> FuncYas= (dogum) => (DateTime.Now.Year-dogum.Year);
            DateTime dogumGunu = new DateTime(1997,3,27);
            FuncYas(dogumGunu);
            Console.WriteLine(FuncYas(dogumGunu));

            #endregion

            #endregion
        }
        public delegate void Test();

        public delegate void Test2(string str);
        public static void EkranaYaz()
        {
            Console.WriteLine("Hello Mars");
        }

        public static void EkranaYazStr(string str)
        {
            Console.WriteLine(str);
        }
        public static void EkranaYazStr2(string str)
        {
            Console.WriteLine(str);
        }
        public static void EkranaYazStr3(string str)
        {
            Console.WriteLine(str);
        }

        public static void DelegateKullan(Test2 test2)
        {
            test2("Delegate varlik sebebi methoda method yollayabilmek");
        }
    }
}
