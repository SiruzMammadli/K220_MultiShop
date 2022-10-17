using MultiShop.Core.Entities;
using System.Linq.Expressions;

namespace MultiShop.Core.DataAccess
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
