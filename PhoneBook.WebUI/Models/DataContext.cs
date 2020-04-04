using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class DataContext:DbContext
    {

        public DataContext():base("phonebookDb")
        {
           
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}