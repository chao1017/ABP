using Microsoft.EntityFrameworkCore;

namespace Roger.Api1.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<Api1DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for Api1DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
