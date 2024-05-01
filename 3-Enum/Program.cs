namespace _3_Enum
{
    internal class Program
    {
        //Enumlar,belirli bir veri tipindeki sabit degerleri temsil etmek icin kullanilir.
        //Bu sabit degerler,sembolik adlarla temsil edilir ve belirli bir siraya sahiptir.
        //Ornegin bir gunun haftanin hangi günü temsil ettiğini düsünün
        //Bu sabit degerleri enum kullanarak tanimlanabilir.
        //Defualt veri tipi integerdir.
        //Eger veri tipi degistirilmek istenirse : operatoru ile byte,sbyte,short v.b tanimlanabilir.
        //Belirli bir veri kümesini temsil etmek icin kullanilirlar.


        public enum Gun
        {
            pazartesi = 1,
            salı,
            çarşamba,
            perşembe,
            cuma,
            cumartesi, pazar
        }


        static void Main(string[] args)
        {
            #region Enum Degerlerine Erisim

            Gun bugun = Gun.çarşamba;

            Console.WriteLine($"Bugün : {bugun}");
            #endregion

            #region Enum Icerisindeki Degerlere Ulasim

            foreach (var gun in Enum.GetValues(typeof(Gun)))
            {
                Console.WriteLine(gun);
            }

            #endregion
        }
    }
}
