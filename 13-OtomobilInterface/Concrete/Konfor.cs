using _13_OtomobilInterface.Abstract;

namespace _13_OtomobilInterface.Concrete
{
    public class Konfor :  IKonfor
    {
        public void KlimaCalistir()
        {
            Console.WriteLine("Klima Var");
        }

        public void KoltukIsitma()
        {
            Console.WriteLine("Koltuk Isıtma Mevcut");
        }
    }
}
