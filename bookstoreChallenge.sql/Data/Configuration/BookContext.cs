using bookstoreChallenge.sql.Data.Configuration.Book;
using Microsoft.EntityFrameworkCore;
using DataModel = bookstoreChallenge.sql.Models.Book;

namespace bookstoreChallenge.sql.Data.Configuration
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {
                
        }

        public DbSet<DataModel.Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookEntityTypeConfiguration());
            modelBuilder.SeedBooks();
        }
    }
}
