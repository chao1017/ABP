using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Roger.TestApi.Authorization.Roles;
using Roger.TestApi.Authorization.Users;
using Roger.TestApi.MultiTenancy;

namespace Roger.TestApi.EntityFrameworkCore
{
    public class TestApiDbContext : AbpZeroDbContext<Tenant, Role, User, TestApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestApiDbContext(DbContextOptions<TestApiDbContext> options)
            : base(options)
        {
        }
    }
}
