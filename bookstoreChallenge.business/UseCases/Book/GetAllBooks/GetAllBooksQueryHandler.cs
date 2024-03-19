using bookstoreChallenge.business.Services.Book;
using MediatR;
using Microsoft.Extensions.Logging;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookModel.Book>>
    {
        private readonly ILogger<GetAllBooksQueryHandler> _logger;
        private readonly IBookService _bookService;

        public GetAllBooksQueryHandler(ILogger<GetAllBooksQueryHandler> logger, IBookService bookService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        public async Task<List<BookModel.Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {

            try
            {
                var response = await _bookService.GetAll();
                return response.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"BookstoreChallenge - An error ocurred: {ex.Message}");
                return null;
            }
        }
    }
}
