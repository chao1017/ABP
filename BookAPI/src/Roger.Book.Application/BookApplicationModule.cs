using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Roger.Book
{
    [DependsOn(
        typeof(BookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookApplicationModule).GetAssembly());
        }
    }
}