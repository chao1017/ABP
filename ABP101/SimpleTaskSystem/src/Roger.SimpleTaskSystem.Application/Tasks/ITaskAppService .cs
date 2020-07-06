using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Roger.SimpleTaskSystem.Tasks.Dtos;

namespace Roger.SimpleTaskSystem.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);

        System.Threading.Tasks.Task Create(CreateTaskInput input);
    }
}
