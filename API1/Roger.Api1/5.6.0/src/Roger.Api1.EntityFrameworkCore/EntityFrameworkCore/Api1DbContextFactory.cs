using Roger.Api1.Configuration;
using Roger.Api1.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Roger.Api1.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class Api1DbContextFactory : IDesignTimeDbContextFactory<Api1DbContext>
    {
        public Api1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Api1DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(Api1Consts.ConnectionStringName)
            );

            return new Api1DbContext(builder.Options);
        }
    }
}