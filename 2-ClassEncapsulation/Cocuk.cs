using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation
{
    public class Cocuk
    {
        private string _name;

        //Property de kendi kendine deger atamasi yapilamaz(Ad=values gibi)
        //Bunun onune gecmek icin private field olusturulup onunla atama yapilir
        //Buna full prop denir.
        public string Ad { 
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        //Propfull code snipt ile cikan bir kod blogudur
        //Bir adet private field ve bir adet public property kodu olusturur.
        //Bizlerde olusturulan private filed alanina kontrollu veri ekleme ve 
        //kontrollu veri disariya verme islemlerini gerçekleştiririz

        private string _tcno;

        public string TcNo
        {
            get { return _tcno.Substring(7); }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Tc No Boş Olamaz");
                }
                else if (value.Length!=11)
                {
                    throw new Exception("Tc No 11 Karekter Olmalıdır");
                }
                else
                {
                    foreach (Char ch in value)
                    {
                        if (!Char.IsDigit(ch))
                        {
                            throw new Exception("Tc No Sayısal Olmalıdr");
                        }
                    }

                    _tcno = value;
                }
                
            }
        }
        private string _email;

        public string Email
        {
            get 
            { 
                return _email; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email Alani Boş Olamaz");
                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("Düzgün Formatta Değil");
                }
                _email = value;
            }
        }


        public string Soyad { get; set; }

        private int _birikitirdigiPara;     //Private bir fielda sadece o classta deger atamasi yapilir.

        public int Boyu { get; }  //ReadOnly Property.Sadece okuma yapilir deger atanamaz

        public int Kilo { get; private set; }        //Class harici Readonly
        public bool Cinsiyet { private get; set; }   //Class harici WriteOnly
        public int Yas { set { } }  //WriteOnly Pro. Sadece deger atanır okuma yapamaz

        private bool _guveniyorMu;  //Sadece class ici ulasilabilir.

        //Alttaki ornek sartli geri bildirim encapsulation denir.Private alanlara sartlı property

        public int BiriktirdigiPara 
        { 
            get
            {
                if (_guveniyorMu)
                {
                    return _birikitirdigiPara;
                }
                return 0;
            }
            set
            {
                if (value>0)
                {
                    _birikitirdigiPara = value;
                }
            }
        
        }
        
        public void HarclikAl(int harclik)
        {
            if (harclik<5 )
            {
                throw new Exception("Baba Beni Mi Kandiriyorsun");
            }
            else if (harclik<50)
            {
                throw new Exception("Baba Sadaka Mi Veriyorsun");
            }

            _birikitirdigiPara += harclik;
        }

        //Private olan _biriktirdigiPara fieldini disari sartli yollamak=>Encapsulation
        public void Harca(int miktar)
        {
            if (_birikitirdigiPara<miktar)
            {
                throw new Exception("Bu Kadar Param Yok");
            }
            _birikitirdigiPara -= miktar;
        }

        public int KacParanVar(string kimsin)
        {
            if (kimsin=="baban")
            {
                return _birikitirdigiPara / 10;

            }
            else
            {
                return _birikitirdigiPara;
            }
        }
    }
}
