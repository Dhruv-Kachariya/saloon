using System.Threading.Tasks;
using saloon.Configuration.Dto;

namespace saloon.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
