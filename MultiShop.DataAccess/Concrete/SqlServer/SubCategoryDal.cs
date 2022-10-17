using MultiShop.Core.DataAccess.EntityFramework;
using MultiShop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.DataAccess.Concrete.SqlServer
{
    public class SubCategoryDal : EfRepositoryBase<SubCategory, ApplicationDbContext>, ISubCategoryDal
    {
    }
}
