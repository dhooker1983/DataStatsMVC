using DataStatsMVC.Models;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IRepository<Department> _depRepositroy;

        public DepartmentController(IRepository<Department> depRepository)
        {
            _depRepositroy = depRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetDepartment(int id)
        {
            return View(_depRepositroy.Get(id));
        }
    }
}
