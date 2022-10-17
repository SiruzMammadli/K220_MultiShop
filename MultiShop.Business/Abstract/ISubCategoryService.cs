using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Abstract
{
    public interface ISubCategoryService
    {
        void InsertSubCategory(SubCategory subCategory);
        void DeleteSubCategory(SubCategory subCategory);
        void UpdateSubCategory(SubCategory subCategory);
        SubCategory GetSubCategoryById(int id);
        List<SubCategory> GetAllSubCategories();
        List<SubCategory> GetActiveSubCategories();
    }
}
