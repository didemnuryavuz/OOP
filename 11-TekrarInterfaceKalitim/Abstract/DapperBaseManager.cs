using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public abstract class DapperBaseManager 
    {
        public SqlConnection Connection { get; }
        private string constr =
           @"server=LAPTOP-7J52A9UD\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;";
        public DapperBaseManager()
        {
            Connection = new SqlConnection(constr);
        }
        public int ExecuteNonQuery(string sql)
        {
            return Connection.Execute(sql);
        }
    }
}
