using System;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Abp.EntityFrameworkCore;
using Roger.Book.EntityFrameworkCore;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Abp.AspNetCore.Mvc.Antiforgery;
using Microsoft.OpenApi.Models;

namespace Roger.Book.Web.Startup
{
    public class Startup
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public Startup(IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //Configure DbContext
            services.AddAbpDbContext<BookDbContext>(options =>
            {
                DbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
            });

            services.AddControllersWithViews(options =>
            {
                //options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());

                //換這一行才能使用put 及 post API接口
                options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
            }).AddNewtonsoftJson();

            //swagger
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "AbpZeroTemplate API", Version = "v1.0" });
                options.DocInclusionPredicate((docName, description) => true);
            });

            //Configure Abp and Dependency Injection
            return services.AddAbp<BookWebModule>(options =>
            {
                //Configure Log4Net logging
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig(
                        _hostingEnvironment.IsDevelopment()
                            ? "log4net.config"
                            : "log4net.Production.config"
                        )
                );
            });            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); //Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            //Enable middleware to serve swagger - ui assets(HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "AbpZeroTemplate API V1");
            }); //URL: /swagger 
        }
    }
}