using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Roger.TestApi.Localization
{
    public static class TestApiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TestApiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TestApiLocalizationConfigurer).GetAssembly(),
                        "Roger.TestApi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
