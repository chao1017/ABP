using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyHouse.MyProject.Authorization.Roles;
using MyHouse.MyProject.Authorization.Users;
using MyHouse.MyProject.MultiTenancy;

namespace MyHouse.MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }
    }
}
