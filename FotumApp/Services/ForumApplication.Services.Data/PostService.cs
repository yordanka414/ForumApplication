namespace ForumApplication.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ForumApplication.Data.Common.Repositories;
    using ForumApplication.Data.Models;
    using ForumApplication.Services.Mapping;

    public class PostService : IPostService
    {
        private readonly IDeletableEntityRepository<Post> postRepositry;

        public PostService(IDeletableEntityRepository<Post> postRepositry)
        {
            this.postRepositry = postRepositry;
        }

        public async Task<int> CreateAsync(string title, string content, int categoryId, string userId)
        {
            var post = new Post
            {
                CategoryId = categoryId,
                Content = content,
                Title = title,
                UserId = userId,
            };

            await this.postRepositry.AddAsync(post);
            await this.postRepositry.SaveChangesAsync();

            return post.Id;
        }

        public T GetById<T>(int id)
        {
            var post = this.postRepositry.All().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return post;
        }
    }
}
