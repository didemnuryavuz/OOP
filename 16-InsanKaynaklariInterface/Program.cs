using _16_InsanKaynaklariInterface.Concrete;

namespace _16_InsanKaynaklariInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IK ik = new IK();


            #region Insan Kaynaklari Basvurusu
            //ITBasvuru itBasvuru1 = new ITBasvuru()
            //{
            //    isCSS = true,
            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,
            //    isHtml  = true,
            //    Kisi = new Abstract.Kisi { AdSoyad="Ali Yilmaz",Gsm="532 111 22 33"}
            //};
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);

            //ITBasvuru itBasvuru2 = new ITBasvuru()
            //{
            //    isCSS = true,
            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,
            //    isHtml = true,
            //    Kisi = new Abstract.Kisi { AdSoyad = "Ali Yilmaz", Gsm = "532 111 22 33" ,Email="ali@gmail.com" }
            //};
            //ik.ITBasvurAl(itBasvuru2);
            //ITBasvuru itBasvuru3 = new ITBasvuru()
            //{

            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,

            //    Kisi = new Abstract.Kisi { AdSoyad = "Ayse Kaya", Gsm = "532 444 22 33" ,Email = "ayse@gmail.com"   }
            //};
            //ik.ITBasvurAl(itBasvuru3);


            //ik.BasvuruListele(Departman.It); 
            #endregion

            #region IK Genel Basvuru
            ITBasvuru itBasvuru1 = new ITBasvuru()
            {
                isCSS = true,
                isCSharp = true,
                isDapper = true,
                isEntityFrameWork = true,
                isHtml = true,
                Kisi = new Abstract.Kisi { AdSoyad = "Ali Yilmaz", Gsm = "532 111 22 33" }
            };
            ik.GenelBasvuruAl(itBasvuru1);
            FinansBasvuru finansBasvuru3 = new FinansBasvuru()
            {
                isLogo = true,


                Kisi = new Abstract.Kisi { AdSoyad = "Ayse Kaya", Gsm = "532 444 22 33", Email = "ayse@gmail.com" }
            };

            ik.GenelBasvuruAl(finansBasvuru3);
            //ik.BasvuruListele(Departman.It);
            //ik.BasvuruListele(Departman.Finans);
            ik.GenelVasvuruListele();

            #endregion
            
        }
    }
    
}
