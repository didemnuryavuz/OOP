using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Abstract
{
    public class Kisi
    {
        private string _adSoyad;
        private string _gsm;
        private string _email;
        public string AdSoyad
        {
            get
            {
                return _adSoyad;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _adSoyad = value;
                }
                else
                {
                    _adSoyad = "Ad Soyad Girilmemis";
                }
            }

        }
        public string Gsm
        {
            get
            {
                return _gsm;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _gsm = value;
                }
                else
                {
                    _gsm = "Gsm Girilmemis";
                }
            }
        }
        public string Email
        {
            get
            {
                if (!string.IsNullOrEmpty(_email))
                {
                    return _email;
                }
                else
                {
                    return "Email Tanimsiz";
                }


            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _email = value;
                }
                else
                {
                    _email = "email Girilmemis";
                }
            }
        }
        public bool Cinsiyet { get; set; }
    }

}
