using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Roger.TestApi.Controllers
{
    public abstract class TestApiControllerBase: AbpController
    {
        protected TestApiControllerBase()
        {
            LocalizationSourceName = TestApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
