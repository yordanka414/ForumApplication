namespace ForumApplication.Web.ViewModels.Home
{
    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;

    public class IndexCategoriesViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int PostsCount { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-')}";
    }
}
