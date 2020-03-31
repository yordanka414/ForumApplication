namespace ForumApplication.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using ForumApplication.Data.Common.Repositories;
    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;
    using ForumApplication.Web.ViewModels;
    using ForumApplication.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public HomeController(IDeletableEntityRepository<Category> categories)
        {
            this.categoriesRepository = categories;
        }

        public IActionResult Index()
        {
            var viewMode = new IndexViewModel();
            var categories = this.categoriesRepository.All()
                .To<IndexCategoriesViewModel>()
                .ToList();
            viewMode.Categories = categories;
            return this.View(viewMode);
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
