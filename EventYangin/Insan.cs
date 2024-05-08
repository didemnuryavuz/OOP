namespace EventYangin
{
    public class Insan
    {
        public string Ad { get; private set; }
        public Insan(string ad)
        {
            Ad = ad;
        }

        public void RahatsizOl(object rahatsizEden)
        {
            if (rahatsizEden is Alarm)
            {
                Console.WriteLine($"{Ad} alarm caldigi icin rahatsiz oldu");
            }
            else if (rahatsizEden is Kablo)
            {
                Console.WriteLine($"{Ad} kablo yandigi icin rahatsiz oldu");
            }
            else if (rahatsizEden is Sigara)
            {
                Console.WriteLine($"{Ad} sigara icildigi icin rahatsiz oldu");
            }
        }

        public void Kac(object sorun)
        {
            if (sorun is Alarm)
            {
                Console.WriteLine($"{Ad} alarmdan dolayi kacti");
            }
            else if (sorun is Kablo)
            {
                Console.WriteLine($"{Ad} kablo yandigindan dolayi kacti ");
            }
            else if (sorun is Sigara)
            {
                Console.WriteLine($"{Ad} sigara icildiginden dolayi kacti ");
            }
        }

        public void TepkiVer(object sorun)
        {
            if (sorun is Alarm)
            {
                Console.WriteLine($"{Ad} alarma mudahale etti");
            }
            else if (sorun is Kablo)
            {
                Console.WriteLine($"{Ad} kablo yanginina mudahale etti");
            }
            else if (sorun is Sigara)
            {
                Console.WriteLine($"{Ad} sigara icilmemesi icin uyardi ");
            }
        }
    }
}
