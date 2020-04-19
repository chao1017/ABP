using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.SimpleTaskSystem.Configuration;
using Roger.SimpleTaskSystem.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Roger.SimpleTaskSystem.Web.Startup
{
    [DependsOn(
        typeof(SimpleTaskSystemApplicationModule), 
        typeof(SimpleTaskSystemEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class SimpleTaskSystemWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SimpleTaskSystemWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(SimpleTaskSystemConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<SimpleTaskSystemNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(SimpleTaskSystemApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskSystemWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SimpleTaskSystemWebModule).Assembly);
        }
    }
}