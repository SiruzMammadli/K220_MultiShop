using MultiShop.Core.Entities;
using MultiShop.Entities.Concrete.Common;

namespace MultiShop.Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
