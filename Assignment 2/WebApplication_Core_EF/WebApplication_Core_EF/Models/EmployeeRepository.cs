using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_EF.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeesDBContext db;

        public EmployeeRepository(EmployeesDBContext context)
        {
            db = context;
        }

        //implementation codes here..

        public IEnumerable<Employees> GetAllEmployees()
        {
            return db.Employees;
        }

        public Employees GetEmployeeByID(int Id)
        {
            return db.Employees.Find(Id);
        }

        public Employees AddEmployee(Employees Emp)
        {
            db.Employees.Add(Emp);
            db.SaveChanges();
            return Emp;
        }

        public Employees UpdateEmployee(Employees eupd)
        {
            var employee = db.Employees.Attach(eupd);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return eupd;

            //alternatively we can check individual property state

            //db.Employees.Attach(eupd);
            //var entry = db.Entry(eupd);
            //entry.Property(e => e.Name).IsModified = true;
            ////same way for all properties
            //entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.SaveChanges();
        }

        public Employees DeleteEmployee(int Id)
        {
            Employees e = db.Employees.Find(Id);
            if (e != null)
            {
                db.Employees.Remove(e);
                db.SaveChanges();
            }
            return e;
        }
    }
}
