using Abp.AspNetCore.Mvc.Controllers;

namespace Roger.Api1.Web.Controllers
{
    public abstract class Api1ControllerBase: AbpController
    {
        protected Api1ControllerBase()
        {
            LocalizationSourceName = Api1Consts.LocalizationSourceName;
        }
    }
}