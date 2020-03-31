namespace ForumApplication.Data.Models
{
    using ForumApplication.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
