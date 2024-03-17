using bookstoreChallenge.business.Models.File;
using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookModel.Book>
    {
        //private readonly IBookService _bookService;
        //private readonly IFIleService _fileService;

        //public GetBookByIdQueryHandler(IBookService bookService, IFIleService fileService)
        //{
        //    _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        //    _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
        //}

        public Task<BookModel.Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = new BookModel.Book
            {
                Id = request.Id,
                Title = "Title Teste",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new ImageFile { Id = request.Id, Name = "Image", Extension = "jpeg", Data = new byte[] { 1, 2, 3, 4, 5 } },
                Price = 24.55d,
                Status = true,
                Genre = "Fiction"
            };

            return Task.FromResult(book);
        }
    }
}
