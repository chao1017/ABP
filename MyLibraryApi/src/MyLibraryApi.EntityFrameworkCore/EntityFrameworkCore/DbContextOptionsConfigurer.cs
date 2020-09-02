﻿using Microsoft.EntityFrameworkCore;

namespace MyLibraryApi.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyLibraryApiDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyLibraryApiDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
