using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string DepartmentName { get; set; }
    }
}