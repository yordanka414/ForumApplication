namespace ForumApplication.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoryService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);
    }
}
