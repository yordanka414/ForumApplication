namespace ForumApplication.Web.Controllers
{
    using ForumApplication.Services.Data;
    using ForumApplication.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.categoryService.GetByName<CategoryViewModel>(name);
            return this.View(viewModel);
        }
    }
}
