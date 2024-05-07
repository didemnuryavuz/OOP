using _18_GenericRepository.Kutuphane.Abstract;

namespace _18_GenericRepository.Kutuphane.Concrete
{
    public class YayinEvi : BaseEntity<int>
    {
        public string YayinEviAdi { get; set; }
    }
}
