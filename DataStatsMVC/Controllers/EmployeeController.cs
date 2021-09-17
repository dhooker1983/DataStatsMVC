using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using DataStatsMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    //[Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            var model = new EmployeeViewModel(_departmentRepository);
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            _employeeRepository.Add(emp);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetEmployee(int id)
        {
            var emp = _employeeRepository.Get(id);
            return View(emp);
        }

        public IActionResult GetEmployees(int id)
        {
            return View(_employeeRepository.GetAll());
        }

        public IActionResult UpdateEmployee(Employee emp)
        {
            var empToUpdate = _employeeRepository.Update(emp);

            return View();
        }
    }
}
