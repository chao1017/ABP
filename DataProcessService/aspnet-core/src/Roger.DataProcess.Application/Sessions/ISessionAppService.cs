using System.Threading.Tasks;
using Abp.Application.Services;
using Roger.DataProcess.Sessions.Dto;

namespace Roger.DataProcess.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
