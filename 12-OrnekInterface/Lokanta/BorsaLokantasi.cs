namespace _12_OrnekInterface.Lokanta
{
    public class BorsaLokantasi
    {
        public void Pisir(Tavuk tavuk)
        {
            tavuk.Pisir();
        }
        public void Pisir(Tavuk tavuk,Pilav pilav)
        {
            tavuk.Pisir();
            pilav.Pisir();
        }
        public void Pisir(Tavuk tavuk, Pilav pilav,Kofte kofte)
        {
            tavuk.Pisir();
            pilav.Pisir();
            kofte.Pisir();
        }
    }
}
