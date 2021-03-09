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
        private DB dbContext = new DB();
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.GetEmployees();
            return View(employees);
        }
    }
}
