using _17_NorthwindModels.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_NorthwindModels.Services.Abstract
     //Generic Repos. Pattern
{
    public abstract class BaseManager<T, Tid> : IManager<T> 
        where T : BaseEntity<Tid>
    {
        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
