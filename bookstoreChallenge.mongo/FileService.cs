using AutoMapper;
using bookstoreChallenge.business.Models.File;
using bookstoreChallenge.business.Services.File;
using bookstoreChallenge.mongo.Data.Configuration;
using MongoDB.Driver;
using BusinessModel = bookstoreChallenge.business.Models.File;
using DataModel = bookstoreChallenge.mongo.Models.File;

namespace bookstoreChallenge.mongo
{
    public class FileService : IFIleService
    {
        private readonly IMapper _mapper;
        private readonly MongoContext _context;

        public FileService(IMapper mapper, MongoContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ImageFile> GetFileById(Guid id)
        {
            try
            {
                var imageFile = await _context.ImageFiles.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();

                if (imageFile == null)
                {
                    return null;
                }

                return _mapper.Map<DataModel.ImageFile, BusinessModel.ImageFile>(imageFile);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
