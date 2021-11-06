using Abp.AspNetCore.Mvc.Views;

namespace Roger.Book.Web.Views
{
    public abstract class BookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BookRazorPage()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }
    }
}
