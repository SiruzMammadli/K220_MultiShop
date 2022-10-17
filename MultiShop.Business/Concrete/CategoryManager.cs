using MultiShop.Business.Abstract;
using MultiShop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void InsertCategory(Category category)
        {
            _categoryDal.Insert(category);
        }
        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }
        public Category GetCategoryById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }
        public List<Category> GetActiveCategories()
        {
            return _categoryDal.GetAll(x => !x.IsDeleted);
        }
        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }
    }
}
