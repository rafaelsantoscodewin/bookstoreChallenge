using bookstoreChallenge.business.Services.Book;
using MediatR;
using Microsoft.Extensions.Logging;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookModel.Book>
    {
        private readonly ILogger<GetBookByIdQueryHandler> _logger;
        private readonly IBookService _bookService;

        public GetBookByIdQueryHandler(ILogger<GetBookByIdQueryHandler> logger, IBookService bookService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        public async Task<BookModel.Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _bookService.GetById(request.Id);
                if (response == null)
                {
                    _logger.LogInformation($"BookstoreChallenge - The Book with Id {request.Id} doesn't exist.");
                }

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError($"BookstoreChallenge - An error ocurred: {ex.Message}");
                return null;
            }
        }
    }
}
