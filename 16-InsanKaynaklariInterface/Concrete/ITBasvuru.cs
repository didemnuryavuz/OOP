using _16_InsanKaynaklariInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Concrete
{
    public class ITBasvuru :BaseBasvuru,IITBasvuru
    {
        public bool isHtml { get; set; }
        public bool isCSharp { get; set; }
        public bool isCSS { get; set; }
        public bool isTSql { get; set; }
        public bool isEntityFrameWork { get; set; }
        public bool isDapper { get; set; }
        public bool ASPNetMVC { get; set; }

        public bool WebApi { get; set; }

        public override bool Equals(object? obj)
        {
            var gelenkisi = (BaseBasvuru)obj;
            if (gelenkisi.Kisi.Email == this.Kisi.Email)
            {
                return true;
            }
            else if (gelenkisi.Kisi.Gsm == this.Kisi.Gsm)
            {

                return true;
            }
            if (gelenkisi.Kisi.AdSoyad == this.Kisi.AdSoyad && gelenkisi.Kisi.Email == this.Kisi.Email && gelenkisi.Kisi.Gsm == this.Kisi.Gsm)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Debug()
        {
            throw new NotImplementedException();
        }

        public void DeployWebSite()
        {
            throw new NotImplementedException();
        }

        public void KodYaz()
        {
            throw new NotImplementedException();
        }

        public void WebSite()
        {
            throw new NotImplementedException();
        }
    }
}
