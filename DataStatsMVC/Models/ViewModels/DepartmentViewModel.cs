using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.ViewModels
{
    public class DepartmentViewModel
    {
        [Display(Name = "Range Start")]
        [DataType(DataType.Date)]
        public DateTime RangeStart { get; set; } = DateTime.Today;

        [Display(Name = "Range End")]
        [DataType(DataType.Date)]
        public DateTime RangeEnd { get; set; } = DateTime.Today;

        public int DepId { get; set; }
        public DepName Name { get; set; }

        public List<Department> Departments { get; set; }
        public List<Call> Calls { get; set; }
        public List<Employee> Employees { get; set; }
    }

    public enum DepName
    {
        LBG = 1,
        ND = 2,
        BOI = 3,
        Fraud = 4
    }
}
