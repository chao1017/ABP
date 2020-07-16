using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyCompany.MyProject1.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyProject1CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyProject1EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject1EntityFrameworkCoreModule).GetAssembly());
        }
    }
}