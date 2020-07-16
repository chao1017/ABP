using System.Threading.Tasks;
using Abp.Application.Services;
using Roger.TestApi.Authorization.Accounts.Dto;

namespace Roger.TestApi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
