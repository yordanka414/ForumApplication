using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ForumApplication.Web.Areas.Identity.IdentityHostingStartup))]

namespace ForumApplication.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}
