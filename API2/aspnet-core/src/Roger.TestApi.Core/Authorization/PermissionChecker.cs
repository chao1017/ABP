using Abp.Authorization;
using Roger.TestApi.Authorization.Roles;
using Roger.TestApi.Authorization.Users;

namespace Roger.TestApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
