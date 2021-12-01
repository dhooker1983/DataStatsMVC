using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using DataStatsMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDepartmentRepository _depRepository;
        private readonly IEmployeeRepository _empRepository;

        public HomeController(ILogger<HomeController> logger, IDepartmentRepository depRepository, 
            IEmployeeRepository empRepository)
        {
            _logger = logger;
            _depRepository = depRepository;
            _empRepository = empRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ReportForm()
        {
            var deps = _depRepository.GetAll().ToList();
            var viewModel = new DepartmentViewModel
            {
                Departments = deps,
                Employees = new List<Employee>(),
                Calls = new List<Call>()
            };

            return View(viewModel);
        }

        public IActionResult ReportMenu()
        {
            return View();
        }

        public IActionResult FormDepartmentRange()
        {
            var deps = _depRepository.GetAll().ToList();
            var viewModel = new DepartmentViewModel
            {
                Departments = deps,
                Employees = new List<Employee>(),
                Calls = new List<Call>()
            };

            return View(viewModel);
        }

        public IActionResult FormEmployeeRange()
        {
            //think i need to create a new view model for this view
            throw new NotImplementedException();
        }

        public IActionResult FormEmployeeCalls()
        {
            var list = _empRepository.GetAll().ToList();
            //think i need to pass a model with the Id to return all calls for an employee.
            //var listTwo = _empRepository.Find(e => e.FirstName == "Model").ToList();

            return View(list);
        }

        public IActionResult FormDepartmentCalls()
        {
            var list = _depRepository.GetAll().ToList();
            //think i need to pass a model with the Id to return all calls for a department. 
            //var listTwo = _depRepository.Find(d => d.DepartmentId == 1).ToList();

            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
