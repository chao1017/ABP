using Abp.AspNetCore.Mvc.Controllers;

namespace MyLibraryApi.Web.Controllers
{
    public abstract class MyLibraryApiControllerBase: AbpController
    {
        protected MyLibraryApiControllerBase()
        {
            LocalizationSourceName = MyLibraryApiConsts.LocalizationSourceName;
        }
    }
}