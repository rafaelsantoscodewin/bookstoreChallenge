using bookstoreChallenge.business.Core.Common;

namespace bookstoreChallenge.business.Models.File
{
    public class ImageFile : Entity
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
    }
}
