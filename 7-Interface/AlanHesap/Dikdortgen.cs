namespace _7_Polimorfizm.AlanHesap
{
    public class Dikdortgen : GeometrikSekil
    {
        //Propertyler de overide edilebilir.

        public override int KisaKenar
        {
            get => base.KisaKenar;
            set
            {
                if (value > 0)
                {
                    base.KisaKenar = value;
                }
            }
        }
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
