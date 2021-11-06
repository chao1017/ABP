using Abp.AspNetCore.Mvc.Controllers;

namespace Roger.Book.Web.Controllers
{
    public abstract class BookControllerBase: AbpController
    {
        protected BookControllerBase()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }
    }
}