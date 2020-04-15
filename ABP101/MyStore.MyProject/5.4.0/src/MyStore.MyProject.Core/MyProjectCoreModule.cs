using Abp.Modules;
using Abp.Reflection.Extensions;
using MyStore.MyProject.Localization;

namespace MyStore.MyProject
{
    public class MyProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyProjectLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectCoreModule).GetAssembly());
        }
    }
}