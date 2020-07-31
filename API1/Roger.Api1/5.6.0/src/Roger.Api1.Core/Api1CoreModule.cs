using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Api1.Localization;

namespace Roger.Api1
{
    public class Api1CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            Api1LocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Api1CoreModule).GetAssembly());
        }
    }
}