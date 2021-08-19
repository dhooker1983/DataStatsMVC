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

        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department dep)
        {
            _depRepositroy.Add(dep);
            return RedirectToAction("Index", "Home");
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
