using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public abstract class BaseService : IService
    {
        public SqlConnection SqlConnection { get;}  //ReadOnlyProp.
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader{ get; set; }
        public string Sql { get; set; }
        private string constr=
            @"server=LAPTOP-7J52A9UD\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;";
        public BaseService()
        {
            SqlConnection = new SqlConnection(constr);
                
        }
        public int Add(string sql)
        {
            int result = 0;
            try
            {
                if (SqlConnection.State==ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                Command= new SqlCommand(sql,SqlConnection);
                result=Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally 
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
                
            }
            return result;
        }

        public int Delete(string sql)
        {
            int result = 0;
            try
            {
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                Command = new SqlCommand(sql, SqlConnection);
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }

            }
            return result;
        }

        public int Update(string sql)
        {
            int result = 0;
            try
            {
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                Command = new SqlCommand(sql, SqlConnection);
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }

            }
            return result;
        }
    }
}
