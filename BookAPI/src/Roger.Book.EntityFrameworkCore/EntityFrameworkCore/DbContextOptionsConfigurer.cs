using Microsoft.EntityFrameworkCore;

namespace Roger.Book.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BookDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BookDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
