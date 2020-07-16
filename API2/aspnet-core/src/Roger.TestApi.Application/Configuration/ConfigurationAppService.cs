using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Roger.TestApi.Configuration.Dto;

namespace Roger.TestApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
