using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompany.MyProject1.Localization;

namespace MyCompany.MyProject1
{
    public class MyProject1CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyProject1LocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject1CoreModule).GetAssembly());
        }
    }
}