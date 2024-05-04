namespace _7_Polimorfizm.AlanHesap
{
    public class GeometrikSekil
    {
        public virtual int UzunKenar { get; set; }
        public virtual int KisaKenar { get; set; }

        public int Yaricap { get; set; }

        public virtual double AlanHesapla()
        {
            return 0;
        }
        public virtual double CevreHesapla()
        {
            return 0;
        }
    }
}
