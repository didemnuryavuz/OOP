using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation.Telefonlar
{
    public enum IsletimSistemi
    {
        Android, // Google
        IOS, // Apple
        HarmonyOS // Huwaei 
    }
    public class AkilliCepTelefonu
    {
        #region öZELLİKLERİ
        public bool Bluetooth { get; set; }
        public bool YuzTanima { get; set; }
        public bool NFC { get; set; }
        public bool ParmakIzi { get; set; }

        public int DahiliHazifa { get; set; }
        #endregion



        #region Yeteknekleri
        public bool SelfiCek()
        {
            return true;
        }
        public bool OnKameradanFotografCek()
        {
            return true;
        }
        public bool NfcAc()
        {
            return true;
        }
        public bool TelefonAc()
        {
            return true;
        }
        public bool TelefonKapat()
        {
            return true;
        }
        #endregion
    }
}
