using Employee_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext employeeContext { get; set; }

        public HomeController(EmployeeContext ctx)
        {
            employeeContext = ctx;
        }
        public IActionResult Index()
        {
            var employees = employeeContext.Employees.OrderBy(e => e.FirstName).ToList();
            return View(employees);
        }
    }
}
