using DataStatsMVC.Data;
using DataStatsMVC.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public override void Add(Employee entity)
        {
            entity.StartDate = DateTime.Now;
            base.Add(entity);
        }

        public override IEnumerable<Employee> GetAll()
        {
            var employees = _context.Employees
                                .Where(x => x.EmployeeId > 0)
                                .Include(x => x.Department)
                                .ToList();

            return employees;
        }
    }
}
