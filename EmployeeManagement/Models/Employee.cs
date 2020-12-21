using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Employee
    {
        // [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="We need your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="We need your last name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }

        public static List<Employee> GetEmployees()
        {
        Employee employee1 = new Employee()
            {
                Id = 1, 
                FirstName = "Badal", 
                LastName = "Shakya", 
                Address = "Lalitpur", 
                Salary = 20000
            };
            
            Employee employee2 = new Employee() 
            { 
                Id = 2, 
                FirstName = "Hari", 
                LastName = "Khatri", 
                Address = "Ktm", 
                Salary = 23000
            };

            List<Employee> employees = new List<Employee>() { employee1, employee2 };

            return employees;
        }

    }
}