namespace ForumApplication.Web.ViewModels.Post
{
    using System;

    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;
    using Ganss.XSS;

    public class PostViewModel : IMapFrom<Post>
    {
        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }
    }

}
