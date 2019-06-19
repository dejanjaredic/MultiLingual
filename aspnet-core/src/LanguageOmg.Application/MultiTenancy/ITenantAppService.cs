using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LanguageOmg.MultiTenancy.Dto;

namespace LanguageOmg.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

