using _18_GenericRepository.Okul.Abstract;

namespace _18_GenericRepository.Okul.Concrete;
public enum Brans
{
    Matematik=1,
    Biyoloji,
    Kimya,
    Fizik,
    Edebiyat,
    Ingilizce,
    Tarih
}
public class Ogretmen : Kisi,IOgretmen,IEntity<int>
{
    public Brans Brans { get; set; }
    public decimal Maas { get; set; }

    public List<Sinif> Siniflar { get; set; } = new List<Sinif>();
    public int Id { get ; set ; }

    public Ogretmen(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
    {

    }

    public void SinavHazirla()
    {
        throw new NotImplementedException();
    }

    public void YoklamaAl()
    {
        throw new NotImplementedException();
    }
}


