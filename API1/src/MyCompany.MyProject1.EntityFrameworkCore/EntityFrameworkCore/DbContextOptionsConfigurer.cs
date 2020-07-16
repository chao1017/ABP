using Microsoft.EntityFrameworkCore;

namespace MyCompany.MyProject1.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyProject1DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyProject1DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
