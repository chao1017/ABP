using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLibraryApi.books;
using MyLibraryApi.person;

namespace MyLibraryApi.EntityFrameworkCore
{
    public class MyLibraryApiDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> books { get; set; }

        public DbSet<Borrower> borrowers { get; set; }

        public MyLibraryApiDbContext(DbContextOptions<MyLibraryApiDbContext> options) 
            : base(options)
        {

        }
    }
}
