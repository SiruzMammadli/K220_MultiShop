using MultiShop.Core.DataAccess.EntityFramework;
using MultiShop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccess.Concrete.SqlServer
{
    public class CategorySubsDal : EfRepositoryBase<CategorySubs, ApplicationDbContext>, ICategorySubsDal
    {
    }
}
