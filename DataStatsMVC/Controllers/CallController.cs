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
        private readonly IEmployeeRepository _empRepository;

        public CallController(ICallRepository callRepository, IDepartmentRepository depRepository, IEmployeeRepository empRepository)
        {
            _callRepository = callRepository;
            _depRepository = depRepository;
            _empRepository = empRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetByDepartment(DepartmentViewModel model)
        {
            var name = model.Name.ToString();
            var callList = _callRepository.GetByDepartment(name);

            return View(callList);
        }

        public IActionResult GetByEmployee(EmployeeViewModel model)
        {
            var employee = _empRepository.Find(x => x.Name == model.Name).FirstOrDefault();
            var callList = _callRepository.GetByEmployee(employee.EmployeeId);

            return View(callList);
        }

        public IActionResult GetByEmployeeGraph(EmployeeViewModel model)
        {

            return View();
        }

        public JsonResult GetByEmployeeData(int id)
        {
            var graphData = _callRepository.GetByEmployee(id);
            
            return Json(graphData);
        }



        [HttpPost]
        public IActionResult PostRangeByDepartment(DepartmentViewModel model)
        {
            return RedirectToAction("GetRangeByDepartment", model);
        }

        [HttpGet]
        public IActionResult GetRangeByDepartment(DepartmentViewModel model)
        {
            ViewBag.Name = model.Name;
            ViewBag.StartDate = model.RangeStart.ToShortDateString();
            ViewBag.EndDate = model.RangeEnd.ToShortDateString();   

            var name = model.Name.ToString();
            var start = model.RangeStart.ToString("yyyy-MM-dd h:mm tt");
            var finish = model.RangeEnd.ToString("yyyy-MM-dd h:mm tt");

            var callList = _callRepository.GetRangeByDepartment(name, start, finish);

            return View(callList);
        }

        public IActionResult PostRangeByEmployee(EmployeeViewModel model)
        {
            return RedirectToAction("GetRangeByEmployee", model);
        }

        [HttpGet]
        public IActionResult GetRangeByEmployee(EmployeeViewModel model)
        {
            ViewBag.Name = model.Name;
            ViewBag.StartDate = model.RangeStart.ToShortDateString();
            ViewBag.EndDate = model.RangeEnd.ToShortDateString();

            var name = model.Name;
            var start = model.RangeStart.ToString("yyyy-MM-dd h:mm tt");
            var finish = model.RangeEnd.ToString("yyyy-MM-dd h:mm tt");

            var callList = _callRepository.GetRangeByEmployee(name, start, finish);

            return View(callList);
        }

        public IActionResult CallsBy()
        {
            var deps = _depRepository.GetAll().ToList();

            return View(deps);
        }
    }
}
