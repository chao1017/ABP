using Abp.EntityFrameworkCore;
using Roger.SimpleTaskSystem.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Roger.SimpleTaskSystem.EntityFrameworkCore
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }
        public SimpleTaskSystemDbContext(DbContextOptions<SimpleTaskSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
