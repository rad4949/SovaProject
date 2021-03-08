using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SovaProject.Data;
using SovaProject.Data.Entities;
using SovaProject.Data.interfeces;
using SovaProject.Data.mocks;
using SovaProject.Data.Models;
using SovaProject.Data.Repository;

namespace SovaProject
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<DbUser, DbRole>(options => {
                options.Stores.MaxLengthForKeys = 128;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
               .AddEntityFrameworkStores<AppDBContent>()
               .AddDefaultTokenProviders();

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllTarufs, TarufRepository>();
            services.AddTransient<ITarufsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => UserCart.GetCart(sp));

            services.AddControllersWithViews();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            // app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(Name: "default", template: "{controller=Home}/{action=Index}/{Id?}");
            //    routes.MapRoute(Name: "CategoryFilter", template: "Taruf{action}/{category?}", defaults: new { Controller = "Tarufs", action = "List" });
            //});

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "CategoryFilter",
                    pattern: "Taruf{action}/{category?}",
                    defaults: new
                    {
                        Controller = "Tarufs",
                        action = "List"
                    });

                endpoints.MapControllerRoute(
                    name: "news",
                    pattern: "{controller=News}/{action=Index}/{slug}"
                    );
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{Id?}"
                    );
                

            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetService<AppDBContent>();
                DBObjects.Initial(content);
            }

            SeederDB.SeedData(app.ApplicationServices, env, this._confString);
        }
    }
}
