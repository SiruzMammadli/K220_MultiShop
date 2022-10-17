using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Abstract
{
    public interface ICategoryService
    {
        void InsertCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory (Category category);
        Category GetCategoryById(int id);
        List<Category> GetAllCategories();
        List<Category> GetActiveCategories();
    }
}
