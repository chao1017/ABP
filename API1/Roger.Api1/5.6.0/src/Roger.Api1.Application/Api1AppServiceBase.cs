using Abp.Application.Services;

namespace Roger.Api1
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Api1AppServiceBase : ApplicationService
    {
        protected Api1AppServiceBase()
        {
            LocalizationSourceName = Api1Consts.LocalizationSourceName;
        }
    }
}