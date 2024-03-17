using bookstoreChallenge.business.Core.Common;
using bookstoreChallenge.business.Models.File;

namespace bookstoreChallenge.business.Models.Book
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public ImageFile Image { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public string Genre { get; set; }
    }
}
