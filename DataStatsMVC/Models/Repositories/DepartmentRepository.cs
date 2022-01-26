using DataStatsMVC.Data;
using DataStatsMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext context)
            :base(context)
        {

        }
    }
}
