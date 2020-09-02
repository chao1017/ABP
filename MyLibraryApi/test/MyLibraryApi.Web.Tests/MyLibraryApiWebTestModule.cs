using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLibraryApi.Web.Startup;
namespace MyLibraryApi.Web.Tests
{
    [DependsOn(
        typeof(MyLibraryApiWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyLibraryApiWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyLibraryApiWebTestModule).GetAssembly());
        }
    }
}