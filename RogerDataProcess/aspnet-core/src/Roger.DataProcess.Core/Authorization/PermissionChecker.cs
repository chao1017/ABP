using Abp.Authorization;
using Roger.DataProcess.Authorization.Roles;
using Roger.DataProcess.Authorization.Users;

namespace Roger.DataProcess.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
