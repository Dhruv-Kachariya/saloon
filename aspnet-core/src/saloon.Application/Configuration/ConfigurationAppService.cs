using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using saloon.Configuration.Dto;

namespace saloon.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : saloonAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
