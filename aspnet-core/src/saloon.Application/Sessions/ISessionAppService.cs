using System.Threading.Tasks;
using Abp.Application.Services;
using saloon.Sessions.Dto;

namespace saloon.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
