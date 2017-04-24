using Abp.Authorization;
using Javen.Authorization.Roles;
using Javen.MultiTenancy;
using Javen.Users;

namespace Javen.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
