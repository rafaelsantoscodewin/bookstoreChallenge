using bookstoreChallenge.app.DTO.Book;

namespace bookstoreChallenge.app.Hubs
{
    public interface IBookHub
    {
        Task GetBookById(BookDTO book);
        Task GetAllBooks(IEnumerable<BookDTO> books);
    }
}
 