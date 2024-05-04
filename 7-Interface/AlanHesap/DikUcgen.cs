namespace _7_Polimorfizm.AlanHesap
{
    public class DikUcgen : GeometrikSekil
    {

        public int Hipotenus { get; set; }

        public override double AlanHesapla()
        {
            return (KisaKenar * UzunKenar) / 2;
        }
        public override double CevreHesapla()
        {
            return (KisaKenar + UzunKenar + Hipotenus);
        }
    }
}
