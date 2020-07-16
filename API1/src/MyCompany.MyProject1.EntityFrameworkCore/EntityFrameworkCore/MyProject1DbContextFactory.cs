using MyCompany.MyProject1.Configuration;
using MyCompany.MyProject1.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyCompany.MyProject1.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyProject1DbContextFactory : IDesignTimeDbContextFactory<MyProject1DbContext>
    {
        public MyProject1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProject1DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyProject1Consts.ConnectionStringName)
            );

            return new MyProject1DbContext(builder.Options);
        }
    }
}