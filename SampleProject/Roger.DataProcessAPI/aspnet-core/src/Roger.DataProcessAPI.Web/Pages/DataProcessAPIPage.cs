using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Roger.DataProcessAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Roger.DataProcessAPI.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Roger.DataProcessAPI.Web.Pages.DataProcessAPIPage
     */
    public abstract class DataProcessAPIPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DataProcessAPIResource> L { get; set; }
    }
}
