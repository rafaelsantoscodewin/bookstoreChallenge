using AutoMapper;
using bookstoreChallenge.business.Services.Book;
using bookstoreChallenge.sql.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using BusinessModel = bookstoreChallenge.business.Models.Book;
using DataModel = bookstoreChallenge.sql.Models.Book;

namespace bookstoreChallenge.sql
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly BookContext _bookContext;

        public BookService(IMapper mapper, BookContext bookContext)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _bookContext = bookContext ?? throw new ArgumentNullException(nameof(bookContext));
        }

        public async Task<IEnumerable<BusinessModel.Book>> GetAll()
        {
            var books = await _bookContext.Books.ToListAsync();

            if (!books.Any())
                return null;

            return _mapper.Map<List<DataModel.Book>, List<BusinessModel.Book>>(books);
        }

        public async Task<BusinessModel.Book> GetById(Guid id)
        {
            var book = await _bookContext.Books.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if (book == null)
                return null;

            return _mapper.Map<DataModel.Book, BusinessModel.Book>(book);
        }
    }
}
