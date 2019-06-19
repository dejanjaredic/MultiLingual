using Abp.Application.Services.Dto;

namespace LanguageOmg.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

