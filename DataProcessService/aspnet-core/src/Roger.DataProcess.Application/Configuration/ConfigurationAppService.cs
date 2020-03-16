using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Roger.DataProcess.Configuration.Dto;

namespace Roger.DataProcess.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DataProcessAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
