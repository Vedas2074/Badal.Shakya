using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
         public IActionResult Index()
        {
            Department department1 = new Department()
            {
                Id = 1,
                DepartmentName = "Sales",
                NumberOfEmployee = 8,
                Salary = 200000
            };
            Department department2 = new Department()
            {
                Id = 2,
                DepartmentName = "Marketing",
                NumberOfEmployee = 3,
                Salary = 500000
            };
            List<Department> departments =  new List<Department>() {department1, department2};

            return View(departments);
        }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
         public string Add(Department department)
        {
            
            return "Record Saved";

        }  
    }
}