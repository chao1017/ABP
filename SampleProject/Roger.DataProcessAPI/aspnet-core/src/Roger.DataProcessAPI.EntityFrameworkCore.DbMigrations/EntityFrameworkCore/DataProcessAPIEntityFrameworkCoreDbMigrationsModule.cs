using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Roger.DataProcessAPI.EntityFrameworkCore
{
    [DependsOn(
        typeof(DataProcessAPIEntityFrameworkCoreModule)
        )]
    public class DataProcessAPIEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DataProcessAPIMigrationsDbContext>();
        }
    }
}
