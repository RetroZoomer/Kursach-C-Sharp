using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using KursachTP.Models; // ������������ ���� ��������� ������ UserContext
using Microsoft.AspNetCore.Authentication.Cookies;

namespace KursachTP
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<UserContext>(options => options.UseSqlServer(connection));

            // ��������� ������������ �����������
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                { //                                                                
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Home/UnLogin");
                });
            services.AddAuthorization(opts =>
            {
                opts.AddPolicy("OnlyForAdmin", policy =>
                {
                    policy.RequireClaim(ClaimTypes.Locality, "AdminIS");
                });
            });
            services.AddControllersWithViews();
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
                    pattern: "{controller=Home}/{action=StarterPage}/{id?}");
            });
        }
    }
}
