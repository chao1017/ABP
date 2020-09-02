using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLibraryApi.Configuration;
using MyLibraryApi.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MyLibraryApi.Web.Startup
{
    [DependsOn(
        typeof(MyLibraryApiApplicationModule), 
        typeof(MyLibraryApiEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyLibraryApiWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyLibraryApiWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyLibraryApiConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyLibraryApiNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyLibraryApiApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyLibraryApiWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyLibraryApiWebModule).Assembly);
        }
    }
}