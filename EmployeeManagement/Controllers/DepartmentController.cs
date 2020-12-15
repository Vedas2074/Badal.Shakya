using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
         public IActionResult Index()
        {
            var departments = Department.GetDepartments();

            return View(departments);
        }

        public ActionResult Detail(int id)
        {
            var departments = Department.GetDepartments();
            var dept = departments.FirstOrDefault(x => x.Id == id);
            return View(dept);

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