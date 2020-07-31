using Abp.AspNetCore.Mvc.Views;

namespace Roger.Api1.Web.Views
{
    public abstract class Api1RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected Api1RazorPage()
        {
            LocalizationSourceName = Api1Consts.LocalizationSourceName;
        }
    }
}
