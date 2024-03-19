using AutoMapper;
using BusinessModel = bookstoreChallenge.business.Models.File;
using DataModel = bookstoreChallenge.mongo.Models.File;

namespace bookstoreChallenge.mongo.Configuration
{
    public class MongoAutoMapperProfile : Profile
    {
        public MongoAutoMapperProfile()
        {
            CreateMap<DataModel.ImageFile, BusinessModel.ImageFile>();
        }
    }
}
