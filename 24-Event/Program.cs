namespace _24_Event
{
    internal class Program
    {
        //Bir olayın gerçekleştiğini belirten bir tetikleyicidir.
        //Event tetiklendiğinde event için önceden atanmış olan metotlar çalışır.
        //Gövdesiz metota benzer. Lakin handler süreci farklıdır.
        //Metot ne yapacağını bildiğimiz ve ne zaman çalışacağını bildirdigmiz durumlarda kullanılır

        //Eventte en az iki obje vardır. bir taraf ne yapılacağını bilir ama ne zaman yapılacağını bilmez
        //Diğer taraf ne zaman yapılacağını bilir ama ne yapılacağını bilmez.
        static void Main(string[] args)
        {
            Araba toyota = new Araba("1dem5") { MarkaModel="Toyota Corolla"};
            Araba honda = new Araba("54c56") { MarkaModel = "Honda Civic" };
            Araba fiat = new Araba("jfj56") { MarkaModel = "Fiat Egea" };
            Kumanda kumanda = new Kumanda("1dem5");
     
            kumanda.AcmaEventi += toyota.SinyalAl;
            kumanda.AcmaEventi += honda.SinyalAl;
            kumanda.AcmaEventi += fiat.SinyalAl;
            kumanda.TusaBas();
        }
    }
}
