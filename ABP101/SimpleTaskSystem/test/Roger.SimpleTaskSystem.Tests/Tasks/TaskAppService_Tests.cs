using Roger.SimpleTaskSystem.Tasks;
using Roger.SimpleTaskSystem.Tasks.Dtos;
using Shouldly;
using Xunit;
using System.Linq;
using Abp.Runtime.Validation;

namespace Roger.SimpleTaskSystem.Tests.Tasks
{
    public class TaskAppService_Tests : SimpleTaskSystemTestBase
    {
        private readonly ITaskAppService _taskAppService;
    }
}
