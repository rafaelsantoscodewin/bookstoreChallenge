using bookstoreChallenge.business.Models.File;

namespace bookstoreChallenge.business.Services.File
{
    public interface IFIleService
    {
        Task<ImageFile> GetFileById(Guid id);
    }
}
