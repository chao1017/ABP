using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.Book.Localization;

namespace Roger.Book
{
    public class BookCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BookLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookCoreModule).GetAssembly());
        }
    }
}