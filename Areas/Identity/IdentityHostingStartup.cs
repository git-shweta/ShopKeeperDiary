using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ASPIndentityBlazor.Areas.Identity.IdentityHostingStartup))]
namespace ASPIndentityBlazor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
