using MyLibraryApi.Configuration;
using MyLibraryApi.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyLibraryApi.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyLibraryApiDbContextFactory : IDesignTimeDbContextFactory<MyLibraryApiDbContext>
    {
        public MyLibraryApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyLibraryApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyLibraryApiConsts.ConnectionStringName)
            );

            return new MyLibraryApiDbContext(builder.Options);
        }
    }
}