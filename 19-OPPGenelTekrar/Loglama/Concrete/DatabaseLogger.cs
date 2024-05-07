using _19_OPPGenelTekrar.Loglama.Abstract;

namespace _19_OPPGenelTekrar.Loglama.Concrete
{
    public class DatabaseLogger : ILogger
    {
        public void Logla(string message)
        {
            Console.WriteLine(DateTime.Now + " => " + message + " loglandi");
        }
    }
}
