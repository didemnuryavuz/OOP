using _13_OtomobilInterface.Abstract;

namespace _13_OtomobilInterface.Concrete
{
    public class MultiMedya :  IMultiMedya
    {
        public void InterneteBaglan()
        {
            Console.WriteLine("Internete Baglanabilir");
        }

        public void SpotifyCal()
        {
            Console.WriteLine("Spotify Calabilir");
        }

        public void YoutubeCal()
        {
            Console.WriteLine("Youtube Calabilir");
        }
    }
}
