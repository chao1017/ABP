using System.Threading.Tasks;
using Roger.TestApi.Configuration.Dto;

namespace Roger.TestApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
