using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using DataStatsMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly string _connection = "Server=(localdb)\\mssqllocaldb;Database=DataStatsMVC;Trusted_Connection=True;MultipleActiveResultSets=true";

        public HomeController(ILogger<HomeController> logger, IDepartmentRepository depRepository, 
            IEmployeeRepository empRepository)
        {
            _logger = logger;
            _depRepository = depRepository;
            _empRepository = empRepository;
        }

        //[Authorize(Roles="Admin")]
        
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

        public JsonResult GetJson()
        {
            //var dataSet = new DataSet();
            //var list = new List<object>();
            var graph = new GraphObj();

            //using(SqlConnection connect = new SqlConnection(_connection))
            //using (SqlCommand command = new SqlCommand("ArrayTest", connect)
            //{
            //    CommandType = CommandType.StoredProcedure
            //})
            //{
            //    connect.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    adapter.Fill(dataSet);
            //}

            //for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            //{
            //    graph.GraphData.Add((double)dataSet.Tables[0].Rows[i]["Average"]);

            //};

            var myList = new List<double>()
            {
                3,
                2,
                2,
                4
            };

            graph.GraphData = myList;

            return Json(graph);
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
            var model = _depRepository.GetAll().ToList();
            var emp = _empRepository.GetAll().ToList();

            var viewModel = new EmployeeViewModel
            {
                Employees = emp,
                Departments = model
            };

            return View(viewModel);
        }

        public IActionResult FormEmployeeCalls()
        {
            var model = new EmployeeViewModel()
            {
                Employees = _empRepository.GetAll().ToList()
            };
            return View(model);
        }

        public IActionResult FormDepartmentCalls()
        {
            var model = new DepartmentViewModel();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
