using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.TestApi.EntityFrameworkCore;
using Roger.TestApi.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Roger.TestApi.Web.Tests
{
    [DependsOn(
        typeof(TestApiWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TestApiWebTestModule : AbpModule
    {
        public TestApiWebTestModule(TestApiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestApiWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TestApiWebMvcModule).Assembly);
        }
    }
}