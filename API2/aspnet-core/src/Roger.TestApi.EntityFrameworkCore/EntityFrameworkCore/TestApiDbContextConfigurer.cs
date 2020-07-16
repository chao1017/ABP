using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Roger.TestApi.EntityFrameworkCore
{
    public static class TestApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestApiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestApiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
