using Microsoft.AspNetCore.Mvc;
using MultiShop.Business.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public IActionResult Index()
        {
            var subCategories = _subCategoryService.GetActiveSubCategories();
            return View(subCategories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SubCategory subCategory)
        {
            _subCategoryService.InsertSubCategory(subCategory);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                if (id == null) return NotFound();
                var existSubCategory = _subCategoryService.GetSubCategoryById(id);
                return View(existSubCategory);
            }
            catch (Exception)
            {
                throw;
            }
  
        }
        [HttpPost]
        public IActionResult Edit(SubCategory subCategory)
        {
            try
            {
                _subCategoryService.UpdateSubCategory(subCategory);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == null) return NotFound();
                var existSubCategory = _subCategoryService.GetSubCategoryById(id);
                return View(existSubCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Delete(SubCategory subCategory)
        {
            try
            {
                _subCategoryService.DeleteSubCategory(subCategory);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
