using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public int Age { get; set; } = CalculateAge();
        public static DateTime DoB { get; set; }
        public DateTime StartDate { get; set; }
        public static DateTime EndDate { get; set; }
        public bool CurrentlyEmployed { get; set; } = Employed();

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Holiday Holiday { get; set; }
        public List<Call> Calls { get; set; }

        private static int CalculateAge()
        {
            var now = DateTime.Now.Year;
            var dob = DoB.Year;

            return now - dob; 
        }

        private static bool Employed()
        {
            if (DateTime.Now < EndDate || EndDate == null)
                return true;
            else
                return false;
        }
    }
}
