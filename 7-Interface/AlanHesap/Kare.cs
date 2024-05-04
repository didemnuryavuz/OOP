namespace _7_Polimorfizm.AlanHesap
{
    public class Kare : GeometrikSekil
    {

        public override double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
        public override double CevreHesapla()
        {
            return (KisaKenar + UzunKenar) * 2;
        }
    }
}
