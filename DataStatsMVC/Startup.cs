using DataStatsMVC.Areas.Identity;
using DataStatsMVC.Data;
using DataStatsMVC.Models;
using DataStatsMVC.Models.Interfaces;
using DataStatsMVC.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC
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
            //Define the context, DB Type and connection for the Entity Framework DB connection 
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));


            //Using ApplicationUser for the User and the default class provided for the Role (IdentityRole).
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                       {
                           options.SignIn.RequireConfirmedAccount = false;
                           options.Password.RequiredLength = 6;
                           options.Lockout.DefaultLockoutTimeSpan = new TimeSpan(00, 01, 00);
                       })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            //Below is the default Identity setup, above is the preferred option if you want to use roles.
            //services.AddDefaultIdentity<IdentityUser>(options =>
            //            {
            //                options.Lockout.MaxFailedAccessAttempts = 5;
            //                options.Password.RequiredLength = 10;
            //            })
            //   .AddEntityFrameworkStores<ApplicationDbContext>();

            //same as the above but as the above add of defaultidentity is required that is the perferred
            //option for configuring user policy settings.
            
            services.Configure<IdentityOptions>(ops =>
            {
                ops.Lockout.DefaultLockoutTimeSpan = new TimeSpan(00, 01, 00);
                ops.User.RequireUniqueEmail = false;
            });

            services.AddAuthentication()
                .AddGoogle(ops =>
                {
                    //TODO - register app with google services.
                    ops.ClientId = " ";
                    ops.ClientSecret = " ";
                });

            services.AddAuthentication()
                .AddTwitter(ops =>
                {
                    //TODO - register app with twitter services.
                    ops.ConsumerKey = " ";
                    ops.ConsumerSecret = " ";
                });

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<ICallRepository, CallRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
            services.AddTransient<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
                endpoints.MapRazorPages();
            });
        }
    }
}
