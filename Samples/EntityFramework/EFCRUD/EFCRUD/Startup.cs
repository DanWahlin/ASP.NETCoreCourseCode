using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCRUD.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCRUD
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //Add SQL Server support
            //services.AddDbContext<MoviesDbContext>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("MoviesSqlServerConnectionString"));
            //});

            services.AddDbContextPool<MoviesDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("MoviesSqliteConnectionString"));
            });


            services.AddControllersWithViews();

            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddTransient<MoviesDbSeeder>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MoviesDbSeeder moviesDbSeeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            
            app.UseRouting();

            Console.WriteLine("Visit http://localhost:5000/movies");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            moviesDbSeeder.SeedAsync(app.ApplicationServices).Wait();
        }
    }
}
