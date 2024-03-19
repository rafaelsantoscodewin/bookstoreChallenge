using bookstoreChallenge.business.Services.Book;
using bookstoreChallenge.business.Services.File;
using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookModel.Book>
    {
        private readonly IBookService _bookService;
        private readonly IFIleService _fileService;

        public GetBookByIdQueryHandler(IBookService bookService, IFIleService fileService)
        {
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
        }

        public async Task<BookModel.Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _bookService.GetById(request.Id);

            var imageFile = await _fileService.GetFileById(request.Id);
            if (imageFile != null)
            {
                response.Image = imageFile;
            }

            return response;
        }
    }
}
