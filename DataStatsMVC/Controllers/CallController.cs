using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class CallController : Controller
    {
        private readonly ICallRepository _callRepository;

        public CallController(ICallRepository callRepository)
        {
            _callRepository = callRepository;
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

        public IActionResult GetRangeByDepartment(string start, string finish, int id)
        {
            var callList = _callRepository.GetRangeByDepartment(start, finish, id);

            return View(callList);
        }

        public IActionResult GetRangeByEmployee(string start, string finish, int id)
        {
            var callList = _callRepository.GetRangeByEmployee(start, finish, id);

            return View(callList);
        }
    }
}
