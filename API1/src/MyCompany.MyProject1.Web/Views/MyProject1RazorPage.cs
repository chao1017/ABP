using Abp.AspNetCore.Mvc.Views;

namespace MyCompany.MyProject1.Web.Views
{
    public abstract class MyProject1RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyProject1RazorPage()
        {
            LocalizationSourceName = MyProject1Consts.LocalizationSourceName;
        }
    }
}
