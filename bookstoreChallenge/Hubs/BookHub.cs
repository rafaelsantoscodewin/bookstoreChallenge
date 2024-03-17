using AutoMapper;
using bookstoreChallenge.app.DTO.Book;
using bookstoreChallenge.business.UseCases.Book.GetAllBooks;
using bookstoreChallenge.business.UseCases.Book.GetBookById;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.app.Hubs
{
    public class BookHub : Hub<IBookHub>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BookHub(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task GetBookById(Guid id)
        {
            var result = _mediator.Send(new GetBookByIdQuery { Id = id });
            var response = _mapper.Map<BookModel.Book, BookDTO>(result.Result);
            await Clients.Caller.GetBookById(response);
        }

        public async Task GetAllBooks()
        {
            var result = _mediator.Send(new GetAllBooksQuery());
            var response = _mapper.Map<List<BookModel.Book>, List<BookDTO>>(result.Result);
            await Clients.Caller.GetAllBooks(response);
        }
    }
}
