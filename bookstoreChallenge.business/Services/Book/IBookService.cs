using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.Services.Book
{
    public interface IBookService
    {
        Task<BookModel.Book> GetById(Guid id);
        Task<IEnumerable<BookModel.Book>> GetAll();
    }
}
