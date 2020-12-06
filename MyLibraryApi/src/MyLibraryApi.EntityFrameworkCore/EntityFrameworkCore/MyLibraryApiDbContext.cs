using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLibraryApi.books;
using MyLibraryApi.Person;

namespace MyLibraryApi.EntityFrameworkCore
{
    public class MyLibraryApiDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Books { get; set; }

        public DbSet<Borrower> borrowers { get; set; }

        public MyLibraryApiDbContext(DbContextOptions<MyLibraryApiDbContext> options) 
            : base(options)
        {

        }
    }
}
