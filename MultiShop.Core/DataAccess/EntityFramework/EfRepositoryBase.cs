using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiShop.Core.Entities;
using MultiShop.Core.Entities.Concrete;
using System.Linq.Expressions;

namespace MultiShop.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<T, TContext> : IRepositoryBase<T> where T : class, IEntity where TContext : IdentityDbContext<User>, new()
    {
        public void Insert(T entity)
        {
            using var _context = new TContext();
            var insertEntity = _context.Entry(entity);
            insertEntity.State = EntityState.Added;
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            using var _context = new TContext();
            var deleteEntity = _context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            using var _context = new TContext();
            var updateEntity = _context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            using var _context = new TContext();
            return _context.Set<T>().FirstOrDefault(filter);
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using var _context = new TContext();
            return filter == null
                ? _context.Set<T>().ToList() 
                : _context.Set<T>().Where(filter).ToList();
        }
    }
}
