using AutoMapper;
using BusinessModel = bookstoreChallenge.business.Models.Book;
using DataModel = bookstoreChallenge.sql.Models.Book;

namespace bookstoreChallenge.sql.Configuration
{
    public class SQLAutoMapperProfile : Profile
    {
        public SQLAutoMapperProfile() 
        {
            CreateMap<DataModel.Book, BusinessModel.Book>();
        }
    }
}
