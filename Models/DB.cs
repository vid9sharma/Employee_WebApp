using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_WebApp.Models
{
    public class DB
    {
        public static List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 101,
                    FirstName = "James",
                    LastName = "Smith",
                    JobTitle = "Director of Operations",
                    Salary = 94000
                },
                new Employee
                {
                    EmployeeID = 102,
                    FirstName = "John",
                    LastName = "Brown",
                    JobTitle = "General Manager",
                    Salary = 65000
                },
                new Employee
                {
                    EmployeeID = 103,
                    FirstName = "Patricia",
                    LastName = "Miller",
                    JobTitle = "Assistant Manager",
                    Salary = 50000
                },
                new Employee
                {
                    EmployeeID = 104,
                    FirstName = "Susan",
                    LastName = "Davis",
                    JobTitle = "Software Developer",
                    Salary = 57000
                },
                new Employee
                {
                    EmployeeID = 105,
                    FirstName = "William",
                    LastName = "Jones",
                    JobTitle = "Developer Team Lead",
                    Salary = 88000
                },
                new Employee
                {
                    EmployeeID = 106,
                    FirstName = "Sarah",
                    LastName = "Taylor",
                    JobTitle = "Assistant Manager",
                    Salary = 70000
                }
            };
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void SaveEmployees(List<Employee> listOfEmployees)
        {
            employees = listOfEmployees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.Where(e => e.EmployeeID == id).FirstOrDefault();
        }
    }
}
