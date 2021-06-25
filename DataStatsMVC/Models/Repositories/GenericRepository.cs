using DataStatsMVC.Data;
using Microsoft.EntityFrameworkCore;
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

        public abstract IEnumerable<T> GetCalls(int id);

        public IEnumerable<Call> GetCallsByDate(int id, DateTime start, DateTime finish)
        {
            return _context.Calls
                        .Include(d => d.Department)
                        .Include(e => e.Employee)
                        .Where(c => c.Start >= start && c.Finish <= finish)
                        .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return _context.Update(entity).Entity;
        }
    }
}
