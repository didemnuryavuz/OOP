using _11_TekrarInterfaceKalitim.Abstract;
using _11_TekrarInterfaceKalitim.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Dapper
{
    public class CustomerManager : DapperBaseManager, ICustomerService
    {
        public List<AylikMusteriRaporu> aylikMusteriRapor(int yil)
        {
            string sql = $@"SELECT c.CompanyName,Month(o.OrderDate) Ay ,count(*) Adet
                            from Customers c
                            inner join Orders  o on o.CustomerID=c.CustomerID
                            where year(OrderDate) = {yil}
                            group by c.CompanyName,Month(o.OrderDate)";
            var result = Connection.Query<AylikMusteriRaporu>(sql);
            return result.ToList();
        }

        public List<Customer> Getall()
        {
            string Sql = $"Select * from Customers ";
            var result = Connection.Query<Customer>(Sql);
            return result.ToList();
        }

        public Customer? Getcustomer(string id)
        {
            string Sql = $"Select * from Customers where CustomerID={id}";
            return Connection.QuerySingle<Customer>(Sql);
        }
    }
}
