using MultiShop.Core.DataAccess.EntityFramework;
using MultiShop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.DataAccess.Concrete.SqlServer
{
    public class CategoryDal : EfRepositoryBase<Category, ApplicationDbContext>, ICategoryDal
    {
    }
}
