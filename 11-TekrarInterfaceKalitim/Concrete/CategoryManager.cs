using _11_TekrarInterfaceKalitim.Abstract;
using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Concrete
{
    public class CategoryManager : BaseService, ICategoryService
    {
        public Category? GetCategory(int id)
        {
            Category category = new Category();
            Sql = $"Select * from Categories where CategoryID={id}";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    category.CategoryID = Reader.GetInt32(0);
                    category.CategoryName = Reader.GetString(1);
                    category.Description = Reader.GetString(2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return category;
        }

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();
            Sql = $"Select * from Categories  ";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Category category = new Category();
                    category.CategoryID = Reader.GetInt32(0);
                    category.CategoryName = Reader.GetString(1);
                    category.Description = Reader.GetString(2);
                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return categories;
        }

        public List<CategoryProducts> GetProducts(int id)
        {
            /*
             * 
            Select p.ProductID,p.ProductName,c.CategoryName ,p.UnitPrice ,p.UnitsInStock 
            from Categories c
            inner join Products p on c.CategoryID = p.CategoryID
            where c.CategoryID = 2
             * 
             * 
             */
            List<CategoryProducts> categories = new List<CategoryProducts>();
            Sql = $@"Select p.ProductID,p.ProductName,c.CategoryName ,p.UnitPrice ,p.UnitsInStock 
            from Categories c
            inner join Products p on c.CategoryID = p.CategoryID
            where c.CategoryID = {id}";
            try
            {
                Command = new System.Data.SqlClient.SqlCommand(Sql, SqlConnection);
                if (SqlConnection.State != System.Data.ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    CategoryProducts category = new CategoryProducts();
                    category.ProductId = Reader.GetInt32(0);
                    category.ProductName = Reader.GetString(1);
                    category.CategoryName = Reader.GetString(2);
                    category.UnitPrice = Reader.GetDecimal(3);
                    category.UnitInStock = Reader.GetInt16(4);


                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }
            finally
            {
                if (SqlConnection.State != System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Close();
                }
            }
            return categories;
        }
    }
}
