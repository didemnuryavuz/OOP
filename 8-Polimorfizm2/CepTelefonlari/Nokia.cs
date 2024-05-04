using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _8_Polimorfizm2.CepTelefonlari
{
    public class Nokia : BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer(@"..\..\..\Sounds\nokia.wav"))   
                //Burada aradigi yer bulundugu yer biz ona sounda bak dedik
            {
                soundPlayer.Play();
            }
        }
    }

}
