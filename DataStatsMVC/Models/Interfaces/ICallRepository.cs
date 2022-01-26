using DataStatsMVC.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Interfaces
{
    public interface ICallRepository : IRepository<Call>
    {
        IEnumerable<Call> GetByDepartment(string name);
        IEnumerable<Call> GetByEmployee(int id);
        IEnumerable<Call> GetRangeByDepartment(string name, string start, string finish);
        IEnumerable<Call> GetRangeByEmployee(int id, string start, string finish);
    }
}
