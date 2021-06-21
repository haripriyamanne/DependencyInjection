using EmployeeDI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDI.Repository;
using EmployeeDI.Models;

namespace EmployeeDI.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private IEmployeeRepository _employeeRepository;

        // Inject IEmployeeRepository using Constructor Injection
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            //_employeeRepository = new EmployeeRepository();
            _employeeRepository = employeeRepository;
        }
       
        
        // Retrieve employee name and return
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
