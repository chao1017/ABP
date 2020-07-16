using System.Threading.Tasks;
using Abp.Application.Services;
using Roger.TestApi.Sessions.Dto;

namespace Roger.TestApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
