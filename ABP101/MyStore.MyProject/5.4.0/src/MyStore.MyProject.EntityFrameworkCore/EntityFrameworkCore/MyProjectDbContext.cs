using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyStore.MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options) 
            : base(options)
        {

        }
    }
}
