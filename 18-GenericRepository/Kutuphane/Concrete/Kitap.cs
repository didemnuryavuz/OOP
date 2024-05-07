using _18_GenericRepository.Kutuphane.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Kutuphane.Concrete
{
    public class Kitap :BaseEntity<Guid>
    {
        public Kitap()
        {
            Id = new Guid();
        }
        public string KitapAdi { get; set; }
        public string Aciklama { get; set; }
        public Int16 SayfaSayisi { get; set; }

        public Yazar Yazar { get; set; }
    }
}
