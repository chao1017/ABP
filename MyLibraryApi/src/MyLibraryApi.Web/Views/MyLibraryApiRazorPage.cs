using Abp.AspNetCore.Mvc.Views;

namespace MyLibraryApi.Web.Views
{
    public abstract class MyLibraryApiRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyLibraryApiRazorPage()
        {
            LocalizationSourceName = MyLibraryApiConsts.LocalizationSourceName;
        }
    }
}
