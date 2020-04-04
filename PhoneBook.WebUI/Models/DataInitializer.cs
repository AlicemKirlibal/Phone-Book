using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.WebUI.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {

       
        protected override void Seed(DataContext context)
        {
            List<Department> departments = new List<Department>()
        {
            new Department(){ DepartmentName="Yazılım",Description="Yazılım departmanı"},
            new Department(){DepartmentName="İnsan Kaynakları",Description="ik departmanı"},
            new Department(){ DepartmentName="Muhasebe",Description="muhasebe deaprtmanı"},
            new Department(){DepartmentName="Pazarlama",Description="pazarlama departmanı"}
        };
            foreach (var item in departments)
            {
                context.Departments.Add(item);
            }
            context.SaveChanges();


            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ FullName="Ali Cem Kirlibal", PhoneNumber="05654256532", City="istanbul", Salary=3500, DepartmentId=1},
               new Employee(){ FullName="Seda Önal", PhoneNumber="05654256532", City="izmir", Salary=2400, DepartmentId=2},
                new Employee(){ FullName="Cem Gül", PhoneNumber="05654256532", City="adana", Salary=3600, DepartmentId=3},
                new Employee(){ FullName="Ali Cicel", PhoneNumber="05654256532", City="bursa", Salary=3800, DepartmentId=4},
                new Employee(){ FullName="Cansu Kirlibal", PhoneNumber="05654256532", City="kocaeli", Salary=6400, DepartmentId=1},
                new Employee(){ FullName="Caner Ince", PhoneNumber="05654256532", City="rize", Salary=5400, DepartmentId=2},
                new Employee(){ FullName="Ozan Er", PhoneNumber="05654256532", City="istanbul", Salary=7400, DepartmentId=3},
                new Employee(){ FullName="Esra Uzun", PhoneNumber="05654256533", City="bursa", Salary=3800, DepartmentId=4},
            };
            foreach (var item in employees)
            {
                context.Employees.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}