using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public double Salary { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string City { get; set; }


        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}