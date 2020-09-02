using Abp.Application.Services;

namespace MyLibraryApi
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyLibraryApiAppServiceBase : ApplicationService
    {
        protected MyLibraryApiAppServiceBase()
        {
            LocalizationSourceName = MyLibraryApiConsts.LocalizationSourceName;
        }
    }
}