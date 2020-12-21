using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using EmployeeManagement.Data;

namespace EmployeeManagement.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly EMContext db;

        public EmployeeController(EMContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            // List<Employee> employees = new List<Employee>();
            // var employees = Employee.GetEmployees();
            // return View(employees);
            var employees = db.Employees.ToList();
            return View(employees);
            
        }

        public ActionResult Detail(int id)
        {
            var emp = db.Employees.Find(id);
            return View(emp);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // List<Employee> employees = new List<Employee>();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
    }
}