using System;

namespace BookStoreApplication
{
    public class Book
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int BookPrice { get; set; }

        public int Stock { get; set; }
        // TODO: Create public properties
        // Id -> string
        // Title -> string
        // Author -> string (Optional)
        // Price -> int
        // Stock -> int

        // Example:
        // public string Id { get; set; }
    }
}
