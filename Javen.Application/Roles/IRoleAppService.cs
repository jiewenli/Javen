using System.Threading.Tasks;
using Abp.Application.Services;
using Javen.Roles.Dto;

namespace Javen.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
