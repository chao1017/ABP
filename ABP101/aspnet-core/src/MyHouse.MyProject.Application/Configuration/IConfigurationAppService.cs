using System.Threading.Tasks;
using MyHouse.MyProject.Configuration.Dto;

namespace MyHouse.MyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
