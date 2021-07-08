using DataStatsMVC.Models;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployee(int id)
        {
            return View(_employeeRepository.Get(id));
        }

        public IActionResult GetEmployees(int id)
        {
            return View(_employeeRepository.GetAll());
        }
    }
}
