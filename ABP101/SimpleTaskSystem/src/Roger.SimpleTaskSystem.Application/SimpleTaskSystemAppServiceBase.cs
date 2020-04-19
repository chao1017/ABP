using Abp.Application.Services;

namespace Roger.SimpleTaskSystem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SimpleTaskSystemAppServiceBase : ApplicationService
    {
        protected SimpleTaskSystemAppServiceBase()
        {
            LocalizationSourceName = SimpleTaskSystemConsts.LocalizationSourceName;
        }
    }
}