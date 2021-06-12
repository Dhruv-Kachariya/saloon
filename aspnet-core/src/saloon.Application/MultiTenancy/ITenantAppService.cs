using Abp.Application.Services;
using saloon.MultiTenancy.Dto;

namespace saloon.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

