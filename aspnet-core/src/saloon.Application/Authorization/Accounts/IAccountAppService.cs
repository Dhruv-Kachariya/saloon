using System.Threading.Tasks;
using Abp.Application.Services;
using saloon.Authorization.Accounts.Dto;

namespace saloon.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
