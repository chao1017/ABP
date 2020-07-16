using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.MyProject1.EntityFrameworkCore
{
    public class MyProject1DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyProject1DbContext(DbContextOptions<MyProject1DbContext> options) 
            : base(options)
        {

        }
    }
}
