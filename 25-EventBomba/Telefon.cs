namespace _25_EventBomba
{
    public class Telefon
    {

        public event BombaPatlat KelimeKullanildi;
        public void Gorusme() 
        {
            Console.WriteLine("Alo Anlamadim");
            string input=Console.ReadLine();
            if (input.Contains("elma"))
            {
                KelimeKullanildi();
                
            }
            if (input.Contains("kapat"))
            {
                return;
            }
            Gorusme();

        }

    }
}
