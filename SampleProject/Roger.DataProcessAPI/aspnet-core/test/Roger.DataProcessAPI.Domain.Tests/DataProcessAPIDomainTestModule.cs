using Roger.DataProcessAPI.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Roger.DataProcessAPI
{
    [DependsOn(
        typeof(DataProcessAPIEntityFrameworkCoreTestModule)
        )]
    public class DataProcessAPIDomainTestModule : AbpModule
    {

    }
}