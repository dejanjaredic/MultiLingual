using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LanguageOmg.Authorization;

namespace LanguageOmg
{
    [DependsOn(
        typeof(LanguageOmgCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LanguageOmgApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LanguageOmgAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LanguageOmgApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
