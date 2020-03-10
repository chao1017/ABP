using System.Threading.Tasks;
using Abp.Application.Services;
using Roger.DataProcess.Authorization.Accounts.Dto;

namespace Roger.DataProcess.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
