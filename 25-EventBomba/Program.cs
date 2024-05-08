namespace _25_EventBomba
{
    public delegate void BombaPatlat();
    internal class Program
    {
        //Telefon görüşmesinde gizli bir kod kullanildiginda bomba patlasin
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon();
            Bomba c4 = new Bomba();

            telefon.KelimeKullanildi += c4.Patlat;

            telefon.Gorusme();
        }
    }
}
