using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface IShipperService 
    {
        public Shipper? GetShipper (int id);
        public List<Shipper> GetShipperList();
        public List<ShipperOrders> GetShipperOrdersList(int shipperID, int? year = null);
    }
}
