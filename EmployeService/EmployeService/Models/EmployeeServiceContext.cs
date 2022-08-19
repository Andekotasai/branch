using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EmployeService.Models
{
    public class EmployeeServiceContext:DbContext
    {
        public EmployeeServiceContext()
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}