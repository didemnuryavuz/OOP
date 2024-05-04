namespace _9_Abstract
{
    public class Muzisyen
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public List<MuzikAleti> muzikAletleri { get; set; } // = new List<MuzikAleti>(); // 1. yöntem muzik aleti eklemek icin

        public Muzisyen()
        {
            muzikAletleri=new List<MuzikAleti>();
        }

    }
}
