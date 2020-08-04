using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Roger.Api1.Students;

namespace Roger.Api1.EntityFrameworkCore
{
    public class Api1DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Student> Students { get; set; }

        public Api1DbContext(DbContextOptions<Api1DbContext> options) 
            : base(options)
        {
            
        }
    }
}
