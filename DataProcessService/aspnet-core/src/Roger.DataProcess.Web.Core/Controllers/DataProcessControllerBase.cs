using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Roger.DataProcess.Controllers
{
    public abstract class DataProcessControllerBase: AbpController
    {
        protected DataProcessControllerBase()
        {
            LocalizationSourceName = DataProcessConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
