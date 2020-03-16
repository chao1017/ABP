using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Roger.DataProcess.Configuration;
using Roger.DataProcess.Web;

namespace Roger.DataProcess.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DataProcessDbContextFactory : IDesignTimeDbContextFactory<DataProcessDbContext>
    {
        public DataProcessDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataProcessDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DataProcessDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DataProcessConsts.ConnectionStringName));

            return new DataProcessDbContext(builder.Options);
        }
    }
}
