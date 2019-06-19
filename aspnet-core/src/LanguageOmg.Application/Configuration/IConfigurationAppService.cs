using System.Threading.Tasks;
using LanguageOmg.Configuration.Dto;

namespace LanguageOmg.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
