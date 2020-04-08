namespace ForumApplication.Web.ViewModels.Post
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;
    using ForumApplication.Web.ViewModels.Categories;

    public class PostCreateInputViewModel : IMapFrom<Post>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
