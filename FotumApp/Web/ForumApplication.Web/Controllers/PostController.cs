namespace ForumApplication.Web.Controllers
{
    using System.Threading.Tasks;

    using ForumApplication.Data.Models;
    using ForumApplication.Services.Data;
    using ForumApplication.Web.ViewModels.Categories;
    using ForumApplication.Web.ViewModels.Post;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class PostController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IPostService postService;
        private readonly UserManager<ApplicationUser> userManager;

        public PostController(ICategoryService categoryService, IPostService postService, UserManager<ApplicationUser> userManager)
        {
            this.categoryService = categoryService;
            this.postService = postService;
            this.userManager = userManager;
        }

        public IActionResult Create()
        {
            var categories = this.categoryService.GetAll<CategoryDropDownViewModel>();
            var viewModel = new PostCreateInputViewModel { Categories = categories, };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var postViewModel = this.postService.GetById<PostViewModel>(id);
            if (postViewModel == null)
            {
                return this.NotFound();
            }
            return this.View(postViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PostCreateInputViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            var postId = await this.postService.CreateAsync(input.Title, input.Content, input.CategoryId, user.Id);

            return this.RedirectToAction(nameof(this.ById), new
            { id = postId, });
        }
    }
}
