using Abp.Modules;
using Abp.Reflection.Extensions;
using MyLibraryApi.Localization;

namespace MyLibraryApi
{
    public class MyLibraryApiCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyLibraryApiLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyLibraryApiCoreModule).GetAssembly());
        }
    }
}