using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace EMS_New.Model
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
    public class vw_Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string DepName { get; set; }
    }
}
