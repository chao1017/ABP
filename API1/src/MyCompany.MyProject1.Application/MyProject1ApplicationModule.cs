using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyCompany.MyProject1
{
    [DependsOn(
        typeof(MyProject1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProject1ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject1ApplicationModule).GetAssembly());
        }
    }
}