using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebPageApp.Models
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
    public class EmployeeService:IEmployeeService
    {
        private List<Employee> employeeList;

        public EmployeeService()
        {
            employeeList = new List<Employee>();
            employeeList.Add(new Employee { Id = 1, Name = "krishnai", Email = "krishnai@test.com", Department = DeptOptions.HR });
            employeeList.Add(new Employee { Id = 2, Name = "John", Email = "John@test.com", Department = DeptOptions.IT });

        }
        public IEnumerable<Employee>GetAllEmployees()
        {
            return employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            // Employee employee = (from e in employeeList where e.Id == id select e).SingleOrDefault();
            Employee employee = employeeList.SingleOrDefault(e => e.Id == id);

            return employee;
        }
        public Employee Edit(int id)
        {
            var emp = employeeList.Where(e => e.Id == id).FirstOrDefault();
            return emp;
        }
                        
       
    }
}
