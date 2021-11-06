using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Book.Web.Startup;
namespace Roger.Book.Web.Tests
{
    [DependsOn(
        typeof(BookWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BookWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookWebTestModule).GetAssembly());
        }
    }
}