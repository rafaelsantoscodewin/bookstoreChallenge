namespace bookstoreChallenge.app.Hubs
{
    public interface IBookHub
    {
        Task GetBookById(Guid id);
        Task GetAllBooks();
    }
}
