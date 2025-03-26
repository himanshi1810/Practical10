using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
         private static readonly List<Employee> employees = new List<Employee>()
         {
            new Employee() { Id = 1, Name = "Himanshi" },
            new Employee() { Id = 2, Name = "Panthee" },
            new Employee() { Id = 3, Name = "Shivam" },
            new Employee() { Id = 4, Name = "Tejas" },
            new Employee() { Id = 5, Name = "Dharvi" }
         };

        // GET: Employee
        public ActionResult Index()
        {
            return View(employees);
        }

        //Custome Route
        [Route("Employee/{name}")]
        public ActionResult Details(string name)
        {
            var employee = employees.FirstOrDefault(e => e.Name == name);

            if (employee == null)
            {
                return HttpNotFound($"Employee '{name}' not found.");
            }

            return View(employee);
        }
    }
}