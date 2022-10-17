using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Abstract
{
    public interface ICategorySubsService
    {
        void InsertCategorySubs(CategorySubs subCategory);
        void DeleteCategorySubs(CategorySubs subCategory);
        void UpdateCategorySubs(CategorySubs subCategory);
        CategorySubs GetCategorySubsById(int id);
        List<CategorySubs> GetAllCategorySubs();
        List<CategorySubs> GetActiveCategorySubs();
    }
}
