using DataStatsMVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(ApplicationDbContext context)
            :base(context)
        {
        }

        public override Employee Get(int id)
        {
            return _context.Employees
                        .Include(d => d.Department)
                        .FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}
