using Abp.Application.Services;
using Roger.TestApi.MultiTenancy.Dto;

namespace Roger.TestApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

