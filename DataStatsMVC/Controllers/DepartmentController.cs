using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _depRepositroy;

        public DepartmentController(IDepartmentRepository depRepository)
        {
            _depRepositroy = depRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDepartment(int id)
        {
            return View(_depRepositroy.Get(id));
        }

        public IActionResult GetDepartments()
        {
            return View(_depRepositroy.GetAll().ToList());
        }
    }
}
