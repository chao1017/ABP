using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyLibraryApi
{
    [DependsOn(
        typeof(MyLibraryApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyLibraryApiApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyLibraryApiApplicationModule).GetAssembly());
        }
    }
}