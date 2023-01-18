
using AssignmenttMVC.Helper;
using AutoMapper;
using BL;
using DAL;
using DAL.Data.DbContexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace AssignmenttMVC
{
    public class Startup
    {

        private MapperConfiguration _mapperConfiguration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(new EventToEventModelHelper());
                
            });
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AssignmenttMVCContext>((provider, options) => {
                IConfiguration config = provider.GetRequiredService<IConfiguration>();
                string connectionString = config.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<AllEventsBL>();
            services.AddScoped<AllEventsDAL>();
            services.AddScoped<MyEventsTitlesBL>();
            services.AddScoped<MyEventsDAL>();
            services.AddScoped<UserEmailBL>();
            services.AddScoped<UserEmailDAL>();
            services.AddScoped<EventBL>();
            services.AddScoped<EventDAL>();
            services.AddScoped<CreateEventBL>();
            services.AddScoped<CreateEventDAL>();



            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });
            // Add framework services.
            services.AddSingleton<IMapper>(sp => _mapperConfiguration.CreateMapper());
            services.AddMvc();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
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
