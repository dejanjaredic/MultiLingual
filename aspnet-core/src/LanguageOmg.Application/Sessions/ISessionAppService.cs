using System.Threading.Tasks;
using Abp.Application.Services;
using LanguageOmg.Sessions.Dto;

namespace LanguageOmg.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
