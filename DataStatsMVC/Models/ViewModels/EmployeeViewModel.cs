using DataStatsMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.ViewModels
{
    public class EmployeeViewModel : Employee
    {

        public string NameTwo { get; set; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
