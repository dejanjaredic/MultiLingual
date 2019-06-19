using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LanguageOmg.Controllers
{
    public abstract class LanguageOmgControllerBase: AbpController
    {
        protected LanguageOmgControllerBase()
        {
            LocalizationSourceName = LanguageOmgConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
