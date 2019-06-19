using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LanguageOmg.Configuration;

namespace LanguageOmg.Web.Host.Startup
{
    [DependsOn(
       typeof(LanguageOmgWebCoreModule))]
    public class LanguageOmgWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LanguageOmgWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LanguageOmgWebHostModule).GetAssembly());
        }
    }
}
