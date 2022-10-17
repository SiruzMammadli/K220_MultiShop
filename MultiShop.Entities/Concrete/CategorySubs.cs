using MultiShop.Core.Entities;
using MultiShop.Entities.Concrete.Common;

namespace MultiShop.Entities.Concrete
{
    public class CategorySubs : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
