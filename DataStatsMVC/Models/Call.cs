using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models
{
    public class Call
    {
        public int CallId { get; set; }
        public DateTime Offered { get; set; }
        public bool  InService { get; set; }
        public int AHT { get; set; }
        public int TalkTime { get; set; }
        public int WrapTime { get; set; }

        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
        public Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
    }
}
