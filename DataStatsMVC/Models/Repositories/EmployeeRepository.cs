using DataStatsMVC.Data;
using DataStatsMVC.Models.Interfaces;
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
    }
}
