using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface ICategoryService 
    {
        public Category? GetCategory(int id);
        public List<Category> GetCategoryList();
        public List<CategoryProducts> GetProducts(int id);
       

    }
}
