using AutoMapper;
using bookstoreChallenge.app.DTO.Book;
using bookstoreChallenge.business.UseCases.Book.GetAllBooks;
using bookstoreChallenge.business.UseCases.Book.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace bookstoreChallenge.app.Hubs
{
    public class BookHub : Hub<IBookHub>
    {
        private readonly IMediator _mediator;
        //private readonly IMapper _mapper;

        public BookHub(IMediator mediator/*, IMapper mapper*/)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task GetBookById(Guid id)
        {
            var result = _mediator.Send(new GetBookByIdQuery { Id = id });

            var response = new DTO.Book.BookDTO
            {
                Id = id,
                Title = "Title Teste",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new DTO.File.ImageFileDTO(),
                Price = 24.55d,
                Status = "1",
                Genre = "1"

            };
            await Clients.Caller.GetBookById(response);
        }

        public async Task GetAllBooks()
        {
            var result = _mediator.Send(new GetAllBooksQuery());
            var book1 = new DTO.Book.BookDTO
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 1",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new DTO.File.ImageFileDTO(),
                Price = 24.55d,
                Status = "1",
                Genre = "1"

            };

            var book2 = new DTO.Book.BookDTO
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 2",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new DTO.File.ImageFileDTO(),
                Price = 24.55d,
                Status = "1",
                Genre = "2"

            };

            var book3 = new DTO.Book.BookDTO
            {
                Id = Guid.NewGuid(),
                Title = "Title Teste 3",
                Author = "Name Surname",
                Publisher = "Publisher Test",
                ISBN = "123456-789101112-13141516-1718192021",
                Image = new DTO.File.ImageFileDTO(),
                Price = 24.55d,
                Status = "0",
                Genre = "3"

            };

            var response = new List<BookDTO> { book1, book2, book3 };

            await Clients.Caller.GetAllBooks(response);
        }
    }
}
