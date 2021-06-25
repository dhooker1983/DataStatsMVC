using DataStatsMVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(ApplicationDbContext context)
            :base(context)
        {

        }
        public override IEnumerable<Department> GetCalls(int id)
        {
            return _context.Departments
                        .Include(c => c.Calls)
                        .Where(d => d.DepartmentId == id)
                        .ToList();
        }
    }
}
