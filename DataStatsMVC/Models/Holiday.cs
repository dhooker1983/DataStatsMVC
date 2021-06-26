using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models
{
    public class Holiday
    {
        public int HolidayId { get; set; }
        public double Entitlement { get; set; }
        public double Balance { get; set; }
        public double Debits { get; set; }

        public int EmployeeId { get; set; }
    }
}
