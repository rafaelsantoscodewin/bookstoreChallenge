﻿using bookstoreChallenge.app.DTO.File;

namespace bookstoreChallenge.app.DTO.Book
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public ImageFileDTO Image { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }
    }
}
