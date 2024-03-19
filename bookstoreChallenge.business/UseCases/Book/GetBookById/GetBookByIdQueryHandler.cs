using bookstoreChallenge.business.Services.Book;
using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookModel.Book>
    {
        private readonly IBookService _bookService;

        public GetBookByIdQueryHandler(IBookService bookService)
        {
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        public async Task<BookModel.Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _bookService.GetById(request.Id);

            return response;
        }
    }
}
