using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Api1.Web.Startup;
namespace Roger.Api1.Web.Tests
{
    [DependsOn(
        typeof(Api1WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class Api1WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Api1WebTestModule).GetAssembly());
        }
    }
}