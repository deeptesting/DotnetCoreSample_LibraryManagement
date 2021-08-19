using System;

namespace LibraryBusinessEntities
{
    public class Book
    {
        public int id { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
    }

    public class LibraryAssets
    {
        public string BookId {get;set;}
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public Book BookDetails { get; set; }
    }
}
