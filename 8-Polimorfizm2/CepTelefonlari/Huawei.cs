using System.Media;

namespace _8_Polimorfizm2.CepTelefonlari
{
    public class Huawei :BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"..\..\..\Sounds\default.wav"))   //Burada aradigi yer bulundugu yer biz ona sounda bak dedik
            {
                player.Play();
            }
        }
    }

}
