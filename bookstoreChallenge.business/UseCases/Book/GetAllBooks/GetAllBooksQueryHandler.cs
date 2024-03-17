using bookstoreChallenge.business.Models.File;
using MediatR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.business.UseCases.Book.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookModel.Book>>
    {
        //private readonly IBookService _bookService;

        //public GetAllBooksQueryHandler(IBookService bookService)
        //{
        //    _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        //}

        public Task<List<BookModel.Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var book1 = new BookModel.Book
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 1",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new ImageFile(),
                Price = 24.55d,
                Status = true,
                Genre = "Fantasy"

            };

            var book2 = new BookModel.Book
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 2",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new ImageFile(),
                Price = 24.55d,
                Status = true,
                Genre = "Drama"

            };

            var book3 = new BookModel.Book
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 3",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new ImageFile(),
                Price = 24.55d,
                Status = false,
                Genre = "Adventure"

            };

            var response = new List<BookModel.Book> { book1, book2, book3 };

            return Task.FromResult(response);
        }
    }
}
