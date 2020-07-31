using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Roger.Api1.EntityFrameworkCore
{
    public class Api1DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public Api1DbContext(DbContextOptions<Api1DbContext> options) 
            : base(options)
        {

        }
    }
}
