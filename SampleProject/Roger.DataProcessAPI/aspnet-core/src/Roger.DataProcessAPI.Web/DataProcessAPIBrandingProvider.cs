using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Roger.DataProcessAPI.Web
{
    [Dependency(ReplaceServices = true)]
    public class DataProcessAPIBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DataProcessAPI";
    }
}
