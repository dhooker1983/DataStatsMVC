using DataStatsMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.Repositories
{
    public abstract class GenericRepository<T>
        : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>()
                .AsQueryable()
                .Where(predicate)
                .ToList();
        }

        public T Get(int id)
        {
            return _context.Find<T>(id);
                
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public abstract IEnumerable<T> GetCalls();

        public abstract IEnumerable<T> GetCallsByDate(DateTime start, DateTime end);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
