using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Roger.DataProcess.EntityFrameworkCore
{
    public static class DataProcessDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DataProcessDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DataProcessDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
