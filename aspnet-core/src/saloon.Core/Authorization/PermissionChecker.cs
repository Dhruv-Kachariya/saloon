using Abp.Authorization;
using saloon.Authorization.Roles;
using saloon.Authorization.Users;

namespace saloon.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
