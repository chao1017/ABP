using Microsoft.EntityFrameworkCore;

namespace MyStore.MyProject.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyProjectDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyProjectDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
