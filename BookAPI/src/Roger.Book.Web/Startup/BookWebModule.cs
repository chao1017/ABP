using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Book.Configuration;
using Roger.Book.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Roger.Book.Web.Startup
{
    [DependsOn(
        typeof(BookApplicationModule), 
        typeof(BookEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BookWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BookWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BookConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BookNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BookApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BookWebModule).Assembly);
        }
    }
}
