using AutoMapper;
using bookstoreChallenge.app.DTO.Book;
using bookstoreChallenge.app.DTO.File;
using bookstoreChallenge.business.Models.File;
using System.Globalization;
using BookModel = bookstoreChallenge.business.Models.Book;

namespace bookstoreChallenge.app.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<BookModel.Book, BookDTO>()
                .ForMember(x => x.Price, opt => opt.MapFrom(src => src.Price.ToString("F2", CultureInfo.InvariantCulture)));

            CreateMap<ImageFile, ImageFileDTO>();

        }
    }
}
