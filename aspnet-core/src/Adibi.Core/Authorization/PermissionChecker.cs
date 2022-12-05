using Abp.Authorization;
using Adibi.Authorization.Roles;
using Adibi.Authorization.Users;

namespace Adibi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
