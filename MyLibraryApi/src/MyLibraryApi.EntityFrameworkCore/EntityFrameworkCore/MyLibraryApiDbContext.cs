using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryApi.EntityFrameworkCore
{
    public class MyLibraryApiDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyLibraryApiDbContext(DbContextOptions<MyLibraryApiDbContext> options) 
            : base(options)
        {

        }
    }
}
