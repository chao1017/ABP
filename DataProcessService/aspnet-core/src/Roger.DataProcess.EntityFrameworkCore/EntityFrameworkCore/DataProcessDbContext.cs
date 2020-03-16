using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Roger.DataProcess.Authorization.Roles;
using Roger.DataProcess.Authorization.Users;
using Roger.DataProcess.MultiTenancy;

namespace Roger.DataProcess.EntityFrameworkCore
{
    public class DataProcessDbContext : AbpZeroDbContext<Tenant, Role, User, DataProcessDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DataProcessDbContext(DbContextOptions<DataProcessDbContext> options)
            : base(options)
        {
        }
    }
}
