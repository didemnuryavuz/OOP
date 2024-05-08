using static _25_EventTrafik.Program;

namespace _25_EventTrafik
{
    public class  Araba
    {
        public event TrafikHadler HareketEdiyorum;
        public string Plaka { get; private set; }
        public string soforAdi { get; set; }
        public bool ArabaCalisiyorMu { get; set; }
        public int MaxHiz { get; set; }
        public Araba(string plaka)
        {
            Plaka = plaka;
        }
        public void Hizlan(int gazOrani,object gazaBasan)
        {
            ArabaCalisiyorMu = true;
            Sofor sofor = gazaBasan as Sofor;
            Console.WriteLine($"{Plaka} , {MaxHiz} km hizla gidiyor");
            while (ArabaCalisiyorMu)
            {
                MaxHiz += gazOrani;
                HareketEdiyorum(MaxHiz, this);
            }
        }
    }
}
