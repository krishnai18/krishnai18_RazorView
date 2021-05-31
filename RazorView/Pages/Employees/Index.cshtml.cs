using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebPageApp.Models;

namespace RazorWebPageApp.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService employeeService;

        public IndexModel(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }
       
        //display  template (html) has access to this model property
        public IEnumerable<Employee> Employees { get; set; }

        public void OnGet()
        {
            Employees = employeeService.GetAllEmployees();
        }
    }
}
