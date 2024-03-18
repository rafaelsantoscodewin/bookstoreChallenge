namespace bookstoreChallenge.sql.Models.Book
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public string Genre { get; set; }
    }
}
