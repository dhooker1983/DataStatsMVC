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

        [HttpPost]
        public IActionResult AddDepartment(Department dep)
        {
            return View(_depRepositroy.Add(dep));
        }

        [HttpGet]
        public IActionResult GetDepartment(int id)
        {
            return View(_depRepositroy.Get(id));
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            return View(_depRepositroy.GetAll());
        }

        [HttpPut]
        public IActionResult UpdateDepartment(Department dep)
        {
            var depToUpdate = _depRepositroy.Update(dep);

            return View();
        }

    }
}
