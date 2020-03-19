using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyHouse.MyProject.EntityFrameworkCore
{
    public static class MyProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}