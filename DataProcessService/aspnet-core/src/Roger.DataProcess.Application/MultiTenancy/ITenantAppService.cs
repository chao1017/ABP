using Abp.Application.Services;
using Roger.DataProcess.MultiTenancy.Dto;

namespace Roger.DataProcess.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

