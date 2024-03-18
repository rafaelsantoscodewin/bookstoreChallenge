using Microsoft.EntityFrameworkCore;
using DataModel = bookstoreChallenge.sql.Models.Book;

namespace bookstoreChallenge.sql.Data.Configuration
{
    public static class ModelBuilderExtensions
    {
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataModel.Book>().HasData(
                new DataModel.Book
                {
                    Id = Guid.Parse("a6bae431-0b44-4c4f-bdc6-e571045b5e05"),
                    Title = "Title Teste 1",
                    Author = "Name Surname",
                    Publisher = "Publisher Test",
                    ISBN = "123456-789101112-13141516-1718192021",
                    Price = 24.55d,
                    Status = true,
                    Genre = "Fantasy"
                },

                new DataModel.Book
                {
                    Id = Guid.Parse("6789bb44-7367-4c69-9972-61f906aabb5d"),
                    Title = "Title Teste 2",
                    Author = "Name Surname",
                    Publisher = "Publisher Test",
                    ISBN = "123456-789101112-13141516-1718192021",
                    Price = 19.12d,
                    Status = true,
                    Genre = "Drama"

                },

                new DataModel.Book
                {
                    Id = Guid.Parse("18059d06-36e7-4d05-9640-acb210583c08"),
                    Title = "Title Teste 3",
                    Author = "Name Surname",
                    Publisher = "Publisher Test",
                    ISBN = "123456-789101112-13141516-1718192021",
                    Price = 32.88d,
                    Status = false,
                    Genre = "Adventure"
                });
        }
    }
}
