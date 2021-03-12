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
        private EmployeeContext employeeContext { get; set; }

        public EmployeeController(EmployeeContext ctx)
        {
            employeeContext = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Employee());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var employee = employeeContext.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeID == 0)
                    employeeContext.Employees.Add(employee);
                else
                    employeeContext.Employees.Update(employee);
                employeeContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (employee.EmployeeID == 0) ? "Add" : "Edit";
                return View(employee);
            }
        }

        [HttpGet]
        public IActionResult Detail(int id, string browse)
        {
            var employee = employeeContext.Employees.Find(id);
            var maxId = employeeContext.Employees.Select(s => s.EmployeeID).Max();
            var minId = employeeContext.Employees.Select(s => s.EmployeeID).Min();

            if (string.Equals(browse, "next"))
            {
                if (id == maxId)
                {
                    employee = employeeContext.Employees.Find(minId);
                }
                else
                {
                    employee = employeeContext.Employees.Where(e => e.EmployeeID > id).OrderBy(o => o.EmployeeID).FirstOrDefault();
                }
            }
            else if (string.Equals(browse, "previous"))
            {
                if (id == minId)
                {
                    employee = employeeContext.Employees.Find(maxId);
                }
                else
                {
                    employee = employeeContext.Employees.Where(e => e.EmployeeID < id).OrderByDescending(o => o.EmployeeID).FirstOrDefault();
                }
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = employeeContext.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            employeeContext.Employees.Remove(employee);
            employeeContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
