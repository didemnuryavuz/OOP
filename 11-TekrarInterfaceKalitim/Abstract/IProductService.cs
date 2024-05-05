using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface IProductService : IService
    {
        public Product GetProduct(int id);

        public List<Product> Getall();

       

    }
}
