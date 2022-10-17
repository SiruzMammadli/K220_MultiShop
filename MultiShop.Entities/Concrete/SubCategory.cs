using MultiShop.Core.Entities;
using MultiShop.Entities.Concrete.Common;

namespace MultiShop.Entities.Concrete
{
    public class SubCategory : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
