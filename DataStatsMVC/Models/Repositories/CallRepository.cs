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

        public IEnumerable<Call> GetByDepartment(int id)
        {
            return _context.Calls
                     .Where(c => c.DepartmentId == id)
                     .ToList();
        }

        public IEnumerable<Call> GetByEmployee(int id)
        {
            return _context.Calls
                    .Where(c => c.EmployeeId == id)
                    .ToList();
        }

        public IEnumerable<Call> GetRangeByDepartment(string start, string finish, int id)
        {
            var sp = string.Format("EXEC CallsByRange @start = '{0}', @finish = '{1}', @id = {2}", start, finish, id);

            var callList = _context.Calls
                            .FromSqlRaw<Call>(sp)
                            .ToList();

            return callList;
        }

        public IEnumerable<Call> GetRangeByEmployee(string start, string finish, int id)
        {
            var sp = string.Format("EXEC CallsByRange @start = '{0}', @finish = '{1}', @id = {2}", start, finish, id);

            return _context.Calls
                        .FromSqlRaw<Call>(sp)
                        .Include(e => e.Employee) // not sure if this is needed
                        .ToList();
        }
    }
}
