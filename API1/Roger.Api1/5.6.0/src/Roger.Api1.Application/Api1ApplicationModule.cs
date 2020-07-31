using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Roger.Api1
{
    [DependsOn(
        typeof(Api1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Api1ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Api1ApplicationModule).GetAssembly());
        }
    }
}