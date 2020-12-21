using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using EmployeeManagement.Data;

namespace EmployeeManagement.Controllers
{

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            // List<Employee> employees = new List<Employee>();
            // var employees = Employee.GetEmployees();
            // return View(employees);
            var db = new EMContext();
            var employees = db.Employees.ToList();
            return View(employees);
            
        }

        public ActionResult Detail(int id)
        {
            var employees = Employee.GetEmployees();
            var emp = employees.FirstOrDefault(x => x.Id == id);
            return View(emp);
        }

        public IActionResult Add()
        {
            // List<Employee> employees = new List<Employee>();
            return View();
        }

        [HttpPost]

        public string Add(Employee employee)
        {
            return "Record Saved";
        }
    }
}