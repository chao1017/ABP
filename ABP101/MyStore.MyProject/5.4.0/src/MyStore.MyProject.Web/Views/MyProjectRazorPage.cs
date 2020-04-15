using Abp.AspNetCore.Mvc.Views;

namespace MyStore.MyProject.Web.Views
{
    public abstract class MyProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyProjectRazorPage()
        {
            LocalizationSourceName = MyProjectConsts.LocalizationSourceName;
        }
    }
}
