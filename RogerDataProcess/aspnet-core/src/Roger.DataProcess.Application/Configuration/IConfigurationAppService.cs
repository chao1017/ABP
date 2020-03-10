using System.Threading.Tasks;
using Roger.DataProcess.Configuration.Dto;

namespace Roger.DataProcess.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
