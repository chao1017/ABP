using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.DataProcess.Authorization;

namespace Roger.DataProcess
{
    [DependsOn(
        typeof(DataProcessCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DataProcessApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DataProcessAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DataProcessApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
