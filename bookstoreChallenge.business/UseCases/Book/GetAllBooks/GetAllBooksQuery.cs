using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookModel.Book>>
    {
    }
}
