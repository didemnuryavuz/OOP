using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Abstract
{
    public interface IManager<T>
    {
        public void Insert(T entity);

        public void Update(T entity);

        public void Delete(T entity);

        
        public ICollection<T> GetAll();
    }
}
