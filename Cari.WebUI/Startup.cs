using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cari.Business.Abstract;
using Cari.Business.Concrete;
using Cari.DataAccess.Abstract;
using Cari.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cari.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonDal, EfPersonDal>();
            services.AddScoped<IPhoneService, PhoneService>();
            services.AddScoped<IPhoneDal, EfPhoneDal>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressDal, EfAddressDal>();

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10000);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
               
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
