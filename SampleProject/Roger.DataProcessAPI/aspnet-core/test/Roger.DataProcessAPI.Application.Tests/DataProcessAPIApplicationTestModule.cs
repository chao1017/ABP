using Volo.Abp.Modularity;

namespace Roger.DataProcessAPI
{
    [DependsOn(
        typeof(DataProcessAPIApplicationModule),
        typeof(DataProcessAPIDomainTestModule)
        )]
    public class DataProcessAPIApplicationTestModule : AbpModule
    {

    }
}