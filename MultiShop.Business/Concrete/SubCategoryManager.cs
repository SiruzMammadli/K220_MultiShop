using MultiShop.Business.Abstract;
using MultiShop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void DeleteSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Delete(subCategory);
        }

        public List<SubCategory> GetActiveSubCategories()
        {
            return _subCategoryDal.GetAll(x => !x.IsDeleted);
        }

        public List<SubCategory> GetAllSubCategories()
        {
            return _subCategoryDal.GetAll();
        }

        public SubCategory GetSubCategoryById(int id)
        {
            return _subCategoryDal.Get(x => x.Id == id);
        }

        public void InsertSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Insert(subCategory);
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            _subCategoryDal.Update(subCategory);
        }
    }
}
