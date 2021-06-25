using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public interface IRepository<T> 
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetCalls();
        IEnumerable<T> GetCallsByDate(DateTime start, DateTime end);
        void SaveChanges();
        T Update(T entity);
    }
}
