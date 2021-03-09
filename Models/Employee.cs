using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_WebApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter job title.")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "Please enter salary")]
        public decimal Salary { get; set; }
    }
}
