using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool CurrentlyEmployed { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Holiday Holiday { get; set; }
        public List<Call> Calls { get; set; }

    }
}
