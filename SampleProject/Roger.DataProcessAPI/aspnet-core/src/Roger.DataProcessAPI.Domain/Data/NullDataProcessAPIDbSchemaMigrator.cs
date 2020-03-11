using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Roger.DataProcessAPI.Data
{
    /* This is used if database provider does't define
     * IDataProcessAPIDbSchemaMigrator implementation.
     */
    public class NullDataProcessAPIDbSchemaMigrator : IDataProcessAPIDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}