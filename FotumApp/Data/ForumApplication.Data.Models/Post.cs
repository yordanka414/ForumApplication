namespace ForumApplication.Data.Models
{
    using ForumApplication.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
