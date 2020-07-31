using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Roger.Api1.EntityFrameworkCore
{
    [DependsOn(
        typeof(Api1CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class Api1EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Api1EntityFrameworkCoreModule).GetAssembly());
        }
    }
}