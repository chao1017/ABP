using Abp.Application.Services;

namespace MyCompany.MyProject1
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyProject1AppServiceBase : ApplicationService
    {
        protected MyProject1AppServiceBase()
        {
            LocalizationSourceName = MyProject1Consts.LocalizationSourceName;
        }
    }
}