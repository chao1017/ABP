using Abp.AspNetCore.Mvc.Controllers;

namespace MyStore.MyProject.Web.Controllers
{
    public abstract class MyProjectControllerBase: AbpController
    {
        protected MyProjectControllerBase()
        {
            LocalizationSourceName = MyProjectConsts.LocalizationSourceName;
        }
    }
}