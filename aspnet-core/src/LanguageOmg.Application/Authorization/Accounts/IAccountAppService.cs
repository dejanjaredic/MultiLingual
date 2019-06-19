using System.Threading.Tasks;
using Abp.Application.Services;
using LanguageOmg.Authorization.Accounts.Dto;

namespace LanguageOmg.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
