using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ConfiguringServices.Filters;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Hosting;

namespace ConfiguringServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.WriteLine("Visit: http://localhost:8000/api/dataservice/customers/1");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            // If you want to use the NewtonsoftJson package you can do the following
            // services.AddControllers().AddNewtonsoftJson(options =>
            // {
            //     options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
