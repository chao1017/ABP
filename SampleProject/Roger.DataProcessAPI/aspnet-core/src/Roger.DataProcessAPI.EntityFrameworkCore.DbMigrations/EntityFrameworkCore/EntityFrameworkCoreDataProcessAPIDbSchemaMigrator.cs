using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Roger.DataProcessAPI.Data;
using Volo.Abp.DependencyInjection;

namespace Roger.DataProcessAPI.EntityFrameworkCore
{
    public class EntityFrameworkCoreDataProcessAPIDbSchemaMigrator
        : IDataProcessAPIDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDataProcessAPIDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DataProcessAPIMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DataProcessAPIMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}