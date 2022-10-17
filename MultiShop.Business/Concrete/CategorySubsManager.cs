using MultiShop.Business.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Concrete
{
    public class CategorySubsManager : ICategorySubsService
    {
        private readonly ICategorySubsService _categorySubsService;

        public CategorySubsManager(ICategorySubsService categorySubsService)
        {
            _categorySubsService = categorySubsService;
        }

        public void DeleteCategorySubs(CategorySubs subCategory)
        {
            _categorySubsService.DeleteCategorySubs(subCategory);
        }

        public List<CategorySubs> GetActiveCategorySubs()
        {
            throw new NotImplementedException();
        }

        public List<CategorySubs> GetAllCategorySubs()
        {
            return _categorySubsService.GetAllCategorySubs();
        }

        public CategorySubs GetCategorySubsById(int id)
        {
            return _categorySubsService.GetCategorySubsById(id);
        }

        public void InsertCategorySubs(CategorySubs subCategory)
        {
            _categorySubsService.InsertCategorySubs(subCategory);
        }

        public void UpdateCategorySubs(CategorySubs subCategory)
        {
            _categorySubsService.UpdateCategorySubs(subCategory);
        }
    }
}
