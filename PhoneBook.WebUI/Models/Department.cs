using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Description { get; set; }

        public List<Employee> Employees { get; set; }

    }
}