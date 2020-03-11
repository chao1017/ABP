using System.Data.Common;
using Abp.Zero.EntityFrameworkCore;
using Roger.DataProcess.Authorization.Roles;
using Roger.DataProcess.Authorization.Users;
using Roger.DataProcess.MultiTenancy;
using Roger.DataProcess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Roger.DataProcess.EntityFrameworkCore
{
    public class DataProcessDbContext : AbpZeroDbContext<Tenant, Role, User, DataProcessDbContext>
    {
        /* Define a DbSet for each entity of the application */

        //public DataProcessDbContext(DbContextOptions<DataProcessDbContext> options)
        //    : base(options)
        //{
        //}

        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Player> Players { set; get; }
        public virtual IDbSet<Map> Maps { set; get; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DataProcessDbContext() : base("Default")
        { 
        
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyProjectDbContext since ABP automatically handles it.
         */
        public DataProcessDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        { }

        //This constructor is used in tests
        public DataProcessDbContext(DbConnection connection) : base(connection, true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasRequired(p => p.Map);
        }
    }
}
