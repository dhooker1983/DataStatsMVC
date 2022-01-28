using DataStatsMVC.Data;
using DataStatsMVC.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public class CallRepository : GenericRepository<Call>, ICallRepository
    {
        public CallRepository(ApplicationDbContext context)
            :base(context)
        {

        }

        public IEnumerable<Call> GetByDepartment(string name)
        {
            return _context.Calls
                     .Where(c => c.Department.Name == name)
                     .Include(d => d.Department)
                     .ToList();
        }

        public IEnumerable<Call> GetByEmployee(int id)
        {
            return _context.Calls
                    .Where(c => c.EmployeeId == id)
                    .Include(d => d.Department)
                    .Include(e => e.Employee)
                    .ToList();
        }

        public IEnumerable<Call> GetRangeByDepartment(string name, string start, string finish)
        {
            var sp = string.Format("EXEC RangeByDepartment @start = '{0}', @finish = '{1}', @name = '{2}'", start, finish, name);

            return _context.Calls
                            .FromSqlRaw<Call>(sp)
                            .ToList();
        }

        public IEnumerable<Call> GetRangeByEmployee(string name, string start, string finish)
        {
            var sp = string.Format("EXEC RangeByEmployee @start = '{0}', @finish = '{1}', @name = '{2}'", start, finish, name);

            return _context.Calls
                        .FromSqlRaw<Call>(sp)
                        .ToList();
        }

    }
}
