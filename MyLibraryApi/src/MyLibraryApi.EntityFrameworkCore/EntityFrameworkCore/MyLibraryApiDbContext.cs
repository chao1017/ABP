using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLibraryApi.books;

namespace MyLibraryApi.EntityFrameworkCore
{
    public class MyLibraryApiDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Books { get; set; }

        //public DbSet<Borrower> borrowers { get; set; }

        public MyLibraryApiDbContext(DbContextOptions<MyLibraryApiDbContext> options) 
            : base(options)
        {

        }
    }
}
