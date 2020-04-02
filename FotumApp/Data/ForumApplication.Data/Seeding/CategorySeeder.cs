namespace ForumApplication.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ForumApplication.Data.Models;

    public class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<(string Name, string ImageUrl)>
            {
               ("Sport", "https://comm.uky.edu/sites/default/files/styles/large/public/2019-09/sports-768x432.jpg?itok=S9wme8ST"),
               ("Coronavirus", "https://img2.rtve.es/v/5530085?w=1600&preview=1583356362400.jpg"),
               ("Music", "https://trucoslondres.com/wp-content/uploads/2017/04/music-1024x682.jpg"),
               ("Cats", "https://i.ytimg.com/vi/jHWKtQHXVJg/maxresdefault.jpg"),
               ("Programming", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTVgxjs4BKDNqw2kxqm_d6l_WnHajO60FsdCq-WnXxjk8rw0Ksh&usqp=CAU"),
               ("News", "https://thenextweb.com/files/2010/06/    News.jpg"),
               ("Dogs", "https://ibazar.focus.bg/photosbazar/8c/pics/8c6379fb5ffaf10c4f443ba6c7398f3d.jpg"),
            };

            foreach (var category in categories)
            {
                await dbContext.AddAsync(new Category
                {
                    Name = category.Name,
                    Description = category.Name,
                    Title = category.Name,
                    ImageUrl = category.ImageUrl,
                });
            }
        }
    }
}
