using System.Threading.Tasks;
using Abp.Application.Services;
using MyHouse.MyProject.Sessions.Dto;

namespace MyHouse.MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
