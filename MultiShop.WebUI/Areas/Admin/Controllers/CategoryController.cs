using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Business.Abstract;
using MultiShop.Entities.Concrete;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetActiveCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.InsertCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                if (id == null) return NotFound();
                var existCategory = _categoryService.GetCategoryById(id);
                return View(existCategory);
            }
            catch (Exception)
            {
                throw;
            }
  
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            try
            {
                _categoryService.UpdateCategory(category);
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
                var existCategory = _categoryService.GetCategoryById(id);
                return View(existCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            try
            {
                _categoryService.DeleteCategory(category);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
