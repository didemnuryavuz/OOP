using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Abstract
{
    //Burayi BaseEntity<T> classi olarak tutmak istersem Kisi : BaseEntity<T> miras aldirabiliriz
    public interface  IEntity<T>
    {
        public T Id { get; set; }
    }
}
