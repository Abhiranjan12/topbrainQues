using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book _book;

        public BookUtility(Book book)
        {
            _book=book;
            // TODO: Assign book object
        }

        public void GetBookDetails()
        {
            Console.WriteLine($"<{_book.Id}> <{_book.Title}> <{_book.BookPrice}> <{_book.Stock}");
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
        }

        public void UpdateBookPrice(int newPrice)
        {
            if (newPrice > 0)
            {
                _book.BookPrice=newPrice;

                Console.WriteLine($"Updated Price: <{_book.BookPrice}>");
            }
            // TODO:
            // Validate new price
            // Update price
            // Print: Updated Price: <newPrice>
        }

        public void UpdateBookStock(int newStock)
        {
            if (newStock > 0)
            {
                _book.Stock=newStock;

                Console.WriteLine($"Updated Price: <{_book.Stock}>");
            }
            // TODO:
            // Validate new stock
            // Update stock
            // Print: Updated Stock: <newStock>
        }
    }
}
