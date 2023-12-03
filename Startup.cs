using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Курсач.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;

namespace Курсач
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
            services.AddDbContext<HumContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
 .AddCookie(options =>
 {
     options.LoginPath = "/Users/Login"; // Шлях до дії логіну
    options.AccessDeniedPath = "/Home/AccessDenied"; // Шлях до дії при забороненні доступу
    options.SlidingExpiration = true; // Додайте це для активування зміни терміну дії кук
     options.ExpireTimeSpan = TimeSpan.FromDays(15);
 });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Container",
                    pattern: "all-container",
                    defaults: new { controller = "Containers", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "NonActiveContainersCreate",
                    pattern: "start-container",
                    defaults: new { controller = "NonActiveContainers", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "NonActiveContainersIndex",
                    pattern: "all-start-container",
                    defaults: new { controller = "NonActiveContainers", action = "Index" });


                 endpoints.MapControllerRoute(
                 name: "NewsIndex",
                 pattern: "news/newsN",  // Змінили шаблон
                 defaults: new { controller = "News", action = "NewsN" });

                endpoints.MapControllerRoute(
                    name: "NewsAdd",
                    pattern: "newsAdd",
                    defaults: new { controller = "News", action = "Create" });
                endpoints.MapControllerRoute(
                   name: "UserReg",
                   pattern: "register",
                   defaults: new { controller = "Users", action = "Create" });
                endpoints.MapControllerRoute(
                   name: "UserLogin",
                   pattern: "login",
                   defaults: new { controller = "Users", action = "Login" });
                endpoints.MapControllerRoute(
                   name: "UserLogout",
                   pattern: "logout",
                   defaults: new { controller = "Users", action = "Logout" });



            });
            //app.UseRequestLocalization(new RequestLocalizationOptions
            //{
            //    DefaultRequestCulture = new RequestCulture("en-US"),
            //    SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US"), new CultureInfo("uk-UA") },
            //    SupportedUICultures = new List<CultureInfo> { new CultureInfo("en-US"), new CultureInfo("uk-UA") }
            //});

        }
    }
}
