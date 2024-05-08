namespace _24_Event
{
    public delegate void KumandaHandler(string kod);
    public class Kumanda
    {
        private readonly string _kod;
        public event KumandaHandler AcmaEventi;
       
        public Kumanda(string kod)
        {
            _kod = kod;
        }
        public void TusaBas()
        {
            Console.WriteLine("Tuşa Basıldı");
            AcmaEventi(_kod);
        }

    }
}
