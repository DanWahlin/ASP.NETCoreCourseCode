using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsingIdentity.Areas.Identity.Data;
using UsingIdentity.Data;

[assembly: HostingStartup(typeof(UsingIdentity.Areas.Identity.IdentityHostingStartup))]
namespace UsingIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UsingIdentityContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("UsingIdentityContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UsingIdentityContext>();
            });
        }
    }
}