using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Roger.TestApi.Configuration;
using Roger.TestApi.Web;

namespace Roger.TestApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestApiDbContextFactory : IDesignTimeDbContextFactory<TestApiDbContext>
    {
        public TestApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestApiConsts.ConnectionStringName));

            return new TestApiDbContext(builder.Options);
        }
    }
}
