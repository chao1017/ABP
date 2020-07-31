using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Api1.Configuration;
using Roger.Api1.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Roger.Api1.Web.Startup
{
    [DependsOn(
        typeof(Api1ApplicationModule), 
        typeof(Api1EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class Api1WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Api1WebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(Api1Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<Api1NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(Api1ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Api1WebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Api1WebModule).Assembly);
        }
    }
}