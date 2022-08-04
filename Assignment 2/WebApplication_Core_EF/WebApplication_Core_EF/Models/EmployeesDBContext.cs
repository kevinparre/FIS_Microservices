using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_Core_EF.Models
{
    public class EmployeesDBContext : DbContext

    {
        public EmployeesDBContext(DbContextOptions<EmployeesDBContext> options) : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
