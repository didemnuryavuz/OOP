using _11_TekrarInterfaceKalitim.Abstract;
using _11_TekrarInterfaceKalitim.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Dapper
{
    public class CategoryManagerd : DapperBaseManager, ICategoryService
    {
        public Category? GetCategory(int id)
        {
            string sql = $"Select CategoryId,CategoryName,description from Categories Where CategoryId={id}";
            return Connection.QuerySingle<Category>(sql);
        }

        public List<Category> GetCategoryList()
        {
            string sql = $"Select CategoryId,CategoryName,description from Categories ";
            var result = Connection.Query<Category>(sql);
            return result.ToList();
        }

        public List<CategoryProducts> GetProducts(int id)
        {
            string sql = $@" Select p.ProductID,p.ProductName,c.CategoryName ,p.UnitPrice ,p.UnitsInStock 
            from Categories c
            inner join Products p on c.CategoryID = p.CategoryID
            where c.CategoryID = {id}";
            var result = Connection.Query<CategoryProducts>(sql);
            return result.ToList();
        }
    }
}
