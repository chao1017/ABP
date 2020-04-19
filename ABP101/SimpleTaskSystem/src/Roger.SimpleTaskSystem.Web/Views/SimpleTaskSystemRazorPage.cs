using Abp.AspNetCore.Mvc.Views;

namespace Roger.SimpleTaskSystem.Web.Views
{
    public abstract class SimpleTaskSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected SimpleTaskSystemRazorPage()
        {
            LocalizationSourceName = SimpleTaskSystemConsts.LocalizationSourceName;
        }
    }
}
