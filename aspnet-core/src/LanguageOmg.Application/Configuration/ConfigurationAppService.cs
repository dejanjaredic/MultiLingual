using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LanguageOmg.Configuration.Dto;

namespace LanguageOmg.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LanguageOmgAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
