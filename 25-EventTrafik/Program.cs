namespace _25_EventTrafik
{
    public class Program
    {
        /*
         * 
         * Bir arac 120 km hizi gecince polis ceza kessin
         * 
         * Arac , sofor gaza basacak
         * Arac gaza basilinca hizlanacak
         * polis 120 km hizi gecince cezayi yapistiracak
         */
        public delegate void TrafikHadler(int a , object b);
        static void Main(string[] args)
        {
            Araba toyota = new Araba("37acv715");
            toyota.soforAdi = "Ugur Caglayan";
            Polis polis = new Polis("Ali Yilmaz");
            Sofor veli = new Sofor("Ugur Caglayan");
            
            veli.GazaBastim += toyota.Hizlan;
            toyota.HareketEdiyorum += polis.HizKontrolEt;

            veli.GazaBas();
        }
    }
}
