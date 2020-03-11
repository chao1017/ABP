using Roger.DataProcessAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Roger.DataProcessAPI.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DataProcessAPIPageModel : AbpPageModel
    {
        protected DataProcessAPIPageModel()
        {
            LocalizationResourceType = typeof(DataProcessAPIResource);
        }
    }
}