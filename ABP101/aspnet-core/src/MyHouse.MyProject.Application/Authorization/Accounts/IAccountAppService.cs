using System.Threading.Tasks;
using Abp.Application.Services;
using MyHouse.MyProject.Authorization.Accounts.Dto;

namespace MyHouse.MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
