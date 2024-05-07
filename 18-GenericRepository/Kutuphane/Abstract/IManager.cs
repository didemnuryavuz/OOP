using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Kutuphane.Abstract
{
    public interface IManager<T>
    {
        public int Insert(T entity);

        public int Update(T entity);

        public int Delete(T entity);


        public List<T> GetAll();
    }
}
