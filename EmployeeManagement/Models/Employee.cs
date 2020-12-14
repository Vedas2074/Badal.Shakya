using System.Collections.Generic;
namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
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