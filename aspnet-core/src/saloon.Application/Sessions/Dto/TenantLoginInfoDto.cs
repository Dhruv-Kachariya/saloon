using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using saloon.MultiTenancy;

namespace saloon.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
