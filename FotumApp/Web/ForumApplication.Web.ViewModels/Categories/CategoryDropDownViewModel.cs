namespace ForumApplication.Web.ViewModels.Categories
{
    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;

    public class CategoryDropDownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
