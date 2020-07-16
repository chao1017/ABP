using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProject1.Web.Startup;
namespace MyCompany.MyProject1.Web.Tests
{
    [DependsOn(
        typeof(MyProject1WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyProject1WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject1WebTestModule).GetAssembly());
        }
    }
}