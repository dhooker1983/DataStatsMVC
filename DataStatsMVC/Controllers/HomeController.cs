using DataStatsMVC.Models;
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
        private readonly IRepository<Department> _depRepo;

        public HomeController(ILogger<HomeController> logger, IRepository<Department> depRepo)
        {
            _logger = logger;
            _depRepo = depRepo;
        }

        public IActionResult Index()
        {
            var depsView = new DepartmentViewModel();
            depsView.Departments = _depRepo.GetAll().ToList();

            return View(depsView);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
