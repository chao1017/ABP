using Abp.Application.Services;

namespace Roger.Book
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BookAppServiceBase : ApplicationService
    {
        protected BookAppServiceBase()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }
    }
}