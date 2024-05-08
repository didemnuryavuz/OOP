namespace _24_Event
{
    public class Araba
    {
        private readonly string _kod;
        public string MarkaModel;
        public Araba(string kod)
        {
            _kod= kod;
        }
        public void SinyalAl(string kod)
        {
            Console.WriteLine("Sinyal Alindi");
            if (kod==_kod)
            {
                KapilariAc();
            }
        }
        private void KapilariAc()
        {
            Console.WriteLine($"{MarkaModel} Kapısını Açtı");
        }
    }
   
}
