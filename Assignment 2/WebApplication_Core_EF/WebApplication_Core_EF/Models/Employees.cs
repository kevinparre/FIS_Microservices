using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_EF.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("tblEmployee")]
    public class Employees 
    {
        [Key]
        public int eid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }


    }
}
