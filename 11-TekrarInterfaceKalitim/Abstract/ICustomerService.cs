using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface ICustomerService
    {
        public Customer Getcustomer(string id);

        public List<Customer> Getall();

        public List<AylikMusteriRaporu> aylikMusteriRapor(int yil);
    }
}
