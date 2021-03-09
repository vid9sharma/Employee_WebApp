using Employee_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private DB dbContext = new DB();

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Employee());
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //add new employee to list
                List<Employee> employees = dbContext.GetEmployees();
                employees.Add(employee);
                dbContext.SaveEmployees(employees);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = "Add";
                return View(employee);
            }
        }

        [HttpGet]
        public IActionResult Detail(int id, string browse)
        {
            List<Employee> listOfEmployee = dbContext.GetEmployees();
            Employee employee;
            
            if (string.Equals(browse, "next"))
            {
                //find next employee
                int index = listOfEmployee.FindIndex(e => e.EmployeeID == id);

                //check if it is last employee in the list
                if ((index + 1) >= listOfEmployee.Count)
                {
                    index = -1;
                }
                employee = listOfEmployee[index + 1];
            }
            else if (string.Equals(browse, "previous"))
            {
                //find previous employee
                int index = listOfEmployee.FindIndex(e => e.EmployeeID == id);

                //check if it is first employee in the list
                if ((index - 1) < 0)
                {
                    index = listOfEmployee.Count;
                }
                employee = listOfEmployee[index - 1];
            }
            else
            {
                employee = listOfEmployee.Where(e => e.EmployeeID == id).FirstOrDefault();
            }
            return View(employee);
        }
    }
}
