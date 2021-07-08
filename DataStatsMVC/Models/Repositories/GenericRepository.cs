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

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var objToDelete = _context.Find<T>(id);
            _context.Remove(objToDelete);

            _context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>()
                .AsQueryable()
                .Where(predicate)
                .ToList();
        }

        public virtual T Get(int id)
        {
            return _context.Find<T>(id);
                
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
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
