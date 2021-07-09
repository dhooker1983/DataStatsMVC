using DataStatsMVC.Models;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Controllers
{
    public class CallController : Controller
    {
        private readonly IRepository<Call> _callRepository;

        public CallController(IRepository<Call> callRepository)
        {
            _callRepository = callRepository;
        }

        public IActionResult GetRangeByDepartment(string start, string finish, int id)
        {
            var callList = new List<Call>();

            return View(callList);
        }
    }
}
