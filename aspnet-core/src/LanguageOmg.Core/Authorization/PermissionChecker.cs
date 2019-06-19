using Abp.Authorization;
using LanguageOmg.Authorization.Roles;
using LanguageOmg.Authorization.Users;

namespace LanguageOmg.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
