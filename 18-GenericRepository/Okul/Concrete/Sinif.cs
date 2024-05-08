using _18_GenericRepository.Okul.Abstract;

namespace _18_GenericRepository.Okul.Concrete;
public enum Alan
{
    Sayisal = 1,
    Sozel,
    EsitAgirlik,
    Dil
}
public class Sinif : ISinif,IEntity<int>
{
    public string SinifAdi { get; set; }
    public Alan Alan { get; set; }
    public int Kapasite { get; set; }
    public ICollection<Ogrenci> ogrenciler { get; set; }
    public int Id { get ; set ; }

    public Sinif()
    {
        ogrenciler = new HashSet<Ogrenci>();
    }

    public void DersGor()
    {
        throw new NotImplementedException();
    }
}
