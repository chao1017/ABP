using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Roger.DataProcessAPI.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DataProcessAPIHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DataProcessAPIConsoleApiClientModule : AbpModule
    {
        
    }
}
