using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookModel.Book>
    {
        public Guid Id { get; set; }
    }
}
