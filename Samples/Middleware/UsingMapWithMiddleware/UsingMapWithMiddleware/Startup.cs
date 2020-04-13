using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace UsingMapWithMiddleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.WriteLine("Mapping custom route: http://locahost:8000/customers");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Standard Middleware Called");
                await next();
            });

            Console.WriteLine("Visit http://localhost:8000/customers");
            app.Map("/customers", HandleCustomersRoute);

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }

        private static void HandleCustomersRoute(IApplicationBuilder app)
        {
            app.Run(async context  =>
            {
                await context.Response.WriteAsync("Hit /customers map middleware");
                Console.WriteLine("/Customers Map to Middleware Successful");
            });
        }
    }
}
