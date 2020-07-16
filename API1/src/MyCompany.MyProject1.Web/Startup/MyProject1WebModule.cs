using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProject1.Configuration;
using MyCompany.MyProject1.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MyCompany.MyProject1.Web.Startup
{
    [DependsOn(
        typeof(MyProject1ApplicationModule), 
        typeof(MyProject1EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyProject1WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyProject1WebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyProject1Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyProject1NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyProject1ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject1WebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyProject1WebModule).Assembly);
        }
    }
}