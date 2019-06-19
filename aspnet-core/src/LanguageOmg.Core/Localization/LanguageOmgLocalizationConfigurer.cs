using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LanguageOmg.Localization
{
    public static class LanguageOmgLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LanguageOmgConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LanguageOmgLocalizationConfigurer).GetAssembly(),
                        "LanguageOmg.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
