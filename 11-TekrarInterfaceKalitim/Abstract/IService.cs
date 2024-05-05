using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface IService
    {
        public int Add(string sql);
        public int Delete(string sql);
        public int Update(string sql);
        
    }
}
