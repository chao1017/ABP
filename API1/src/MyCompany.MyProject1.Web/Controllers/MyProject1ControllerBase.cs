using Abp.AspNetCore.Mvc.Controllers;

namespace MyCompany.MyProject1.Web.Controllers
{
    public abstract class MyProject1ControllerBase: AbpController
    {
        protected MyProject1ControllerBase()
        {
            LocalizationSourceName = MyProject1Consts.LocalizationSourceName;
        }
    }
}