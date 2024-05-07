using _18_GenericRepository.Kutuphane.Abstract;

namespace _18_GenericRepository.Kutuphane.Concrete
{
    public class Yazar : BaseEntity<Guid>
    {

        public Yazar()
        {
            Id = new Guid();
        }
        public string FullName { get; set; }
        public bool Cinsiyet { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}
