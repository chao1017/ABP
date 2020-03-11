using Roger.DataProcessAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Roger.DataProcessAPI.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DataProcessAPIController : AbpController
    {
        protected DataProcessAPIController()
        {
            LocalizationResource = typeof(DataProcessAPIResource);
        }
    }
}