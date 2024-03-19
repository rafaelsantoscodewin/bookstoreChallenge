using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstoreChallenge.mongo.Models.File
{
    public class ImageFile
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Data { get; set; }
    }
}
