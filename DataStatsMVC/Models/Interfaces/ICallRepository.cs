using DataStatsMVC.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Interfaces
{
    public interface ICallRepository : IRepository<Call>
    {
        IEnumerable<Call> GetByDepartment(int id);
        IEnumerable<Call> GetByEmployee(int id);
        IEnumerable<Call> GetRangeByDepartment(string start, string finish, int id);
        IEnumerable<Call> GetRangeByEmployee(string start, string finish, int id);
    }
}
