using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id {get; set;}

        [Required(ErrorMessage="We need your department name")]
        public string DepartmentName {get;  set;}
        public int NumberOfEmployee {get; set;}
        public float Salary { get; set;}

    public static List<Department> GetDepartments()
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

            return departments;
            }

    }
}