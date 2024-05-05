using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Models
{
    public class ShipperOrders
    {
        /*  Modelleme Sql Sorgusuna Gore Yapıldı.
           
         
         Sql = $@" SELECT OrderId,CustomerID,EmployeeID,OrderDate,ShipCountry,ShipCity
                FROM   [Northwind].[dbo].[Orders] 
                inner join Shippers on Shippers.ShipperID = Orders.ShipVia    
                where ShipperID={shipperID} ";
         */
        public int OrderId { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
    }
}
