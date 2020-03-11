using Roger.DataProcessAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Roger.DataProcessAPI.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DataProcessAPIEntityFrameworkCoreDbMigrationsModule),
        typeof(DataProcessAPIApplicationContractsModule)
        )]
    public class DataProcessAPIDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
