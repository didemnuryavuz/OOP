using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InsanKaynaklariInterface.Concrete
{
    public enum Departman
    {
        Satis = 1,
        Finans = 2,
        It = 3
    }

    public class IK
    {
        //HashSet ayni objeden ikinci bir objeyi atmaz.Ama farkli instance yine atar.

        private HashSet<FinansBasvuru> _finansBasvuru = new HashSet<FinansBasvuru>();
        private HashSet<SatisBasvuru> _satisBasvuru = new HashSet<SatisBasvuru>();
        private HashSet<ITBasvuru> _itBasvuru = new HashSet<ITBasvuru>();
        private HashSet<object> _genelBasvuru = new HashSet<object>();

        public bool GenelBasvuruAl(object basvuru)
        {


            if (basvuru == null) return false;
            if (basvuru is ITBasvuru)
            {

                var tempBasvuru = (ITBasvuru)basvuru;


                Console.WriteLine("Bu bir It Personel Basvurusudur");
                _itBasvuru.Add((ITBasvuru)basvuru);
                _genelBasvuru.Add(tempBasvuru);
            }
            else if (basvuru is FinansBasvuru)
            {
                Console.WriteLine("Bu bir Finans Personel Basvurusudur");
                _finansBasvuru.Add((basvuru as FinansBasvuru));            //As İfadesi Kullanilabilir
                _genelBasvuru.Add(basvuru);

            }
            else if (basvuru is SatisBasvuru)
            {

                Console.WriteLine("Bu bir Satis  Personel Basvurusudur");
                _satisBasvuru.Add((SatisBasvuru)basvuru);
                _genelBasvuru.Add(basvuru);

            }
            return false;
        }

        public bool ITBasvurAl(ITBasvuru basvuru)
        {
            bool flag = false;

            //if (basvuru == null) return false;

            //if(!_itBasvuru.Contains(basvuru)) //Ayni icerik olsada farklı instance old icin kacamaz ekler.
            if (_itBasvuru.Count == 0)          //İlk Basvuru icin yapildi.
            {
                _itBasvuru.Add(basvuru);
            }
            foreach (var item in _itBasvuru)    //İlk Basvuru olmali kiyaslamak icin.
            {
                if (!item.Equals(basvuru))      //Farkli instance direkt equals olmaz override ederiz itbasvuruda
                {
                    flag = true;
                }
            }
            if (flag) _itBasvuru.Add(basvuru);

            return true;
        }
        public bool FinansBasvurAl(FinansBasvuru basvuru)
        {
            if (basvuru == null) return false;
            _finansBasvuru.Add(basvuru);

            return true;
        }
        public bool SatisPersonelBasvurAl(SatisBasvuru basvuru)
        {
            if (basvuru == null) return false;
            _satisBasvuru.Add(basvuru);

            return true;
        }
        public void BasvuruListele(Departman departman)
        {

            switch (departman)
            {
                case Departman.Satis:
                    {
                        foreach (var item in _satisBasvuru)
                        {
                            Console.WriteLine($"{item.Kisi.AdSoyad}\t{item.Kisi.Gsm}\t{item.Kisi.Email}\n");
                        }

                    }
                    break;
                case Departman.Finans:
                    {
                        foreach (var item in _finansBasvuru)
                        {
                            Console.WriteLine($"{item.Kisi.AdSoyad}\t{item.Kisi.Gsm}\t{item.Kisi.Email}\n");
                        }

                    }
                    break;
                case Departman.It:
                    {
                        foreach (var item in _itBasvuru)
                        {
                            Console.WriteLine($"{item.Kisi.AdSoyad}\t{item.Kisi.Gsm}\t{item.Kisi.Email}\n");
                        }

                    }
                    break;
                default:
                    break;
            }

        }

        public void GenelVasvuruListele()
        {

            foreach (var item in _genelBasvuru)
            {
                if (item is ITBasvuru)
                {
                    var temp = ((ITBasvuru)item);
                    if (temp.isEntityFrameWork == true)
                    {
                        Console.WriteLine(temp.Kisi.AdSoyad + "\t" + temp.Kisi.Gsm + "\n");
                    }
                }
                else if (item is FinansBasvuru)
                {
                    var temp = ((FinansBasvuru)item);
                    if (temp.isLogo == true)
                    {
                        Console.WriteLine(temp.Kisi.AdSoyad + "\t" + temp.Kisi.Gsm + "\n");
                    }
                }
                else if (item is SatisBasvuru)
                {
                    var temp = ((SatisBasvuru)item);
                    if (temp.SeyahateEngelDurum == false)
                    {
                        Console.WriteLine(temp.Kisi.AdSoyad + "\t" + temp.Kisi.Gsm + "\n");
                    }
                }
            }
        }
    }
}
