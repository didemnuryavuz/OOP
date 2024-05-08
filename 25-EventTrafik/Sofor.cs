using static _25_EventTrafik.Program;

namespace _25_EventTrafik

{
    public class Sofor : Insan
    {
        public event TrafikHadler GazaBastim;
        private string _ad;
        public Sofor(string ad) : base(ad)
        {
            _ad = ad;
        }
        public void GazaBas()
        {
            Random rnd = new Random();
           int gazOrani = rnd.Next(50, 100);
            GazaBastim(gazOrani,this);
        }
    }
}
