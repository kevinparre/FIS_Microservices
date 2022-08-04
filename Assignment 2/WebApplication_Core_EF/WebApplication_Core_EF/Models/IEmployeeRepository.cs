using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_EF.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployees();
        Employees GetEmployeeByID(int Id);
        Employees AddEmployee(Employees employee);
        Employees UpdateEmployee(Employees employeechanges);
        Employees DeleteEmployee(int Id);
    }
}
