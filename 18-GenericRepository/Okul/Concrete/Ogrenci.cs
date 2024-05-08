using _18_GenericRepository.Okul.Abstract;

namespace _18_GenericRepository.Okul.Concrete;

public class Ogrenci : Kisi,IOgrenci,IEntity<int>
{
    
    public int Id { get ; set ; }
    public int SinifId { get; set; }
    public Sinif Sinif { get; set; }
    public Ogrenci(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
    {
    }
    public bool BorcuVarMi { get; set; }

    public void DersDinle()
    {
        throw new NotImplementedException();
    }

    public void SinavOl()
    {
        throw new NotImplementedException();
    }

    public void Insert(Ogrenci entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Ogrenci entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Ogrenci entity)
    {
        throw new NotImplementedException();
    }

    public ICollection<Ogrenci> GetAll()
    {
        throw new NotImplementedException();
    }
}
