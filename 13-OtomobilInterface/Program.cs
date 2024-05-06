using _13_OtomobilInterface.Abstract;
using _13_OtomobilInterface.Concrete;

namespace _13_OtomobilInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOtomobil otomobil1 = new Otomobil();

            BaseOtomobil otomobil2 = new Otomobil();

            Otomobil otomobil3 = new Otomobil();
        }
    }
}
