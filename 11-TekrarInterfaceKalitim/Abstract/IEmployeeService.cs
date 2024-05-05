using _11_TekrarInterfaceKalitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TekrarInterfaceKalitim.Abstract
{
    public interface IEmployeeService : IService
    {
        public string AyinElemani();
        public string YillikCiro();
        public List<Employee> getCountryLists(int employeeID,int year);


    }
}
