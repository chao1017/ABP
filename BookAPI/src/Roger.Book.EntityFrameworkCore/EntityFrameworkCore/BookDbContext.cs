using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Roger.Book.Books;

namespace Roger.Book.EntityFrameworkCore
{
    public class BookDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<BookInfo> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }
    }
}