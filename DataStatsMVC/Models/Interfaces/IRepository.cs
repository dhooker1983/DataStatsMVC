using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public interface IRepository<T> 
    {
        void Add(T entity);
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
        T Update(T entity);
    }
}
