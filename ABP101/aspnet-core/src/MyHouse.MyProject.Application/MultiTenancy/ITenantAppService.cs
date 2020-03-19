using Abp.Application.Services;
using MyHouse.MyProject.MultiTenancy.Dto;

namespace MyHouse.MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

