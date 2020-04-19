using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Roger.SimpleTaskSystem
{
    [DependsOn(
        typeof(SimpleTaskSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SimpleTaskSystemApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskSystemApplicationModule).GetAssembly());
        }
    }
}