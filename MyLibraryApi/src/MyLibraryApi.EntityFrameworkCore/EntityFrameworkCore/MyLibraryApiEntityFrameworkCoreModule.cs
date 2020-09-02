using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyLibraryApi.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyLibraryApiCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyLibraryApiEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyLibraryApiEntityFrameworkCoreModule).GetAssembly());
        }
    }
}