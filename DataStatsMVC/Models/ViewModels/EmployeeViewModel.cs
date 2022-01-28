using DataStatsMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.ViewModels
{
    public class EmployeeViewModel : Employee
    {
        [Display(Name = "Range Start")]
        [DataType(DataType.Date)]
        public DateTime RangeStart { get; set; } = DateTime.Today;

        [Display(Name = "Range End")]
        [DataType(DataType.Date)]
        public DateTime RangeEnd { get; set; } = DateTime.Today;

        public int EmpId { get; set; }

        public string NameTwo { get; set; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }


    }
}
