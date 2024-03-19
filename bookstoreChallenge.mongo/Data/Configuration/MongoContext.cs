using bookstoreChallenge.mongo.Models.File;
using MongoDB.Driver;

namespace bookstoreChallenge.mongo.Data.Configuration
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);

            //EnsureCollectionExists<ImageFile>("ImageFiles");
            IsDatabaseSeeded();
        }

        public IMongoCollection<ImageFile> ImageFiles => _database.GetCollection<ImageFile>("ImageFiles");

        private bool IsDatabaseSeeded()
        {
            return _database.GetCollection<ImageFile>("ImageFiles").AsQueryable().Any();
        }

        private void SeedDatabase()
        {
            if (!IsDatabaseSeeded())
            {
                Seed();
            }
        }

        private void Seed()
        {
            var imageFiles = new List<ImageFile>()
            {
                new ImageFile { Id = Guid.Parse("a6bae431-0b44-4c4f-bdc6-e571045b5e05"), Name = "Image Teste 1", Extension = "jpeg", Data = "" },
                new ImageFile { Id = Guid.Parse("6789bb44-7367-4c69-9972-61f906aabb5d"), Name = "Image Teste 2", Extension = "jpeg", Data = "" }
            };

            _database.GetCollection<ImageFile>("ImageFiles").InsertMany(imageFiles);
        }

        private void EnsureCollectionExists<T>(string collectionName)
        {
            try
            {
                if (!_database.ListCollectionNames().ToList().Contains(collectionName))
                {
                    _database.CreateCollection(collectionName);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}