using Abp.EntityFrameworkCore;
using MyStore.MyProject.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyStore.MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options) 
            : base(options)
        {

        }
    }
}
