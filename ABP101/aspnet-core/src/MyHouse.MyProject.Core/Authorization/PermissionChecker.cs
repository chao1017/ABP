using Abp.Authorization;
using MyHouse.MyProject.Authorization.Roles;
using MyHouse.MyProject.Authorization.Users;

namespace MyHouse.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
