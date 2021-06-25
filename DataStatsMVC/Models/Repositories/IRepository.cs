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
        IEnumerable<T> GetCalls(int id);
        IEnumerable<Call> GetCallsByDate(int id, DateTime start, DateTime finish);
        void SaveChanges();
        T Update(T entity);
    }
}
