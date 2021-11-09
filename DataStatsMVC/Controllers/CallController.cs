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
    //[Authorize(Roles = "Admin,User")]
    public class CallController : Controller
    {
        private readonly ICallRepository _callRepository;
        private readonly IDepartmentRepository _depRepository;

        public CallController(ICallRepository callRepository, IDepartmentRepository depRepository)
        {
            _callRepository = callRepository;
            _depRepository = depRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetByDepartment(int id)
        {
            var callList = _callRepository.GetByDepartment(id);

            return View(callList);
        }

        public IActionResult GetByEmployee(int id)
        {
            var callList = _callRepository.GetByEmployee(id);

            return View(callList);
        }

        [HttpPost]
        public IActionResult PostRangeByDepartment(DepartmentViewModel model)
        {
            return RedirectToAction("GetRangeByDepartment", model);
        }

        [HttpGet]
        public IActionResult GetRangeByDepartment(DepartmentViewModel model)
        {
            var name = model.Name.ToString();
            var start = model.RangeStart.ToString("yyyy-MM-dd h:mm tt");
            var finish = model.RangeEnd.ToString("yyyy-MM-dd h:mm tt");

            var callList = _callRepository.GetRangeByDepartment(name, start, finish);

            return View(callList);
        }

        public IActionResult PostRangeByEmployee(DepartmentViewModel model)
        {
            return RedirectToAction("GetRangeByEmployee", model);
        }

        [HttpGet]
        public IActionResult GetRangeByEmployee(DepartmentViewModel model)
        {
            var id = model.DepId;
            var start = model.RangeStart.ToString("yyyy-MM-dd h:mm tt");
            var finish = model.RangeEnd.ToString("yyyy-MM-dd h:mm tt");

            var callList = _callRepository.GetRangeByEmployee(id, start, finish);

            return View(callList);
        }

        public IActionResult CallsBy()
        {
            var deps = _depRepository.GetAll().ToList();

            return View(deps);
        }
    }
}
