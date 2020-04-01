namespace ForumApplication.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using ForumApplication.Services.Data;
    using ForumApplication.Services.Mapping;
    using ForumApplication.Web.ViewModels;
    using ForumApplication.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoryService categoryService;

        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories = this.categoryService.GetAll<IndexCategoriesViewModel>(null),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
