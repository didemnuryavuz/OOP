using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Abstract
{
    public abstract class BaseManager<T,Tid> : IManager<T>
        where T : IEntity<Tid>
    {
        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
