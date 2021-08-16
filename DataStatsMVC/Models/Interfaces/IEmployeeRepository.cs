using DataStatsMVC.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
