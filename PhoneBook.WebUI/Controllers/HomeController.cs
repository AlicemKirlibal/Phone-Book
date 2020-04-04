using PhoneBook.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.WebUI.Controllers
{
   
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        public ActionResult Details(int id)
        {
            var employess = _context.Employees.Select(i => new EmployeeModel()
            {         
                Id = i.Id,
                FullName = i.FullName,
                PhoneNumber = i.PhoneNumber,
                Salary = i.Salary,
                City = i.City,
                DepartmentName = i.Department.DepartmentName
            });

            return View(employess.Where(i=>i.Id==id).FirstOrDefault());
        }

       
    }
}