using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataModel = bookstoreChallenge.sql.Models.Book;

namespace bookstoreChallenge.sql.Data.Configuration.Book
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<DataModel.Book>
    {
        public void Configure(EntityTypeBuilder<DataModel.Book> builder)
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}
