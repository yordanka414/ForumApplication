namespace ForumApplication.Web.Controllers
{
    using System.Threading.Tasks;
    using ForumApplication.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class TestController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public TestController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Test()
        {
            var result = await this.userManager.CreateAsync(
                new ApplicationUser
                {
                    Email = "softuni@gmail.com",
                    UserName = "Softuni",
                    EmailConfirmed = true,
                    PhoneNumber = "1234568",
                }, "Account1");

            return this.Json(result);
        }
    }
}
