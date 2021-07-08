using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models
{
    public class Call
    {
        public int CallId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public DateTime Offered { get; set; }

        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
        public Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
    }
}
