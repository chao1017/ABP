using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Roger.DataProcess.Localization
{
    public static class DataProcessLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DataProcessConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DataProcessLocalizationConfigurer).GetAssembly(),
                        "Roger.DataProcess.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
