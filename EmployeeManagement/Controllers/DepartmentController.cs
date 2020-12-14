using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{

    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            // List<Employee> employees = new List<Employee>();

            Worker worker1 = new Worker()
            {
                DepartmentId = 1, 
                Department = "Accounts",
                FirstName = "Badal", 
                LastName = "Shakya",
                EmployeeId = "E01" 
            };
            
            Worker worker2 = new Worker() 
            { 
                DepartmentId = 2, 
                Department = "Sales",
                FirstName = "Ram", 
                LastName = "Khatri",
                EmployeeId = "E11"
            };

            List<Worker> workers = new List<Worker>() { worker1, worker2 };
            return View(workers);
        }
    }
}