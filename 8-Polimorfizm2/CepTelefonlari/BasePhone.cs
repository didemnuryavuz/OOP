namespace _8_Polimorfizm2.CepTelefonlari
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public virtual void CallSound()
        {

        }
    }
}
