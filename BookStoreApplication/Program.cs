using System;
using System.Diagnostics.CodeAnalysis;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
              Book book = new Book();

            Console.WriteLine("Enter the book id ,title price stock");
            string str=Console.ReadLine();

            string[] arr=str.Split(" ");

            book.Id=arr[0];
            book.Title=arr[1];
            book.BookPrice=int.Parse(arr[2]);

            book.Stock=int.Parse(arr[3]);
            
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock

          

            BookUtility utility = new BookUtility(book);

            while (true)
            {
                Console.WriteLine(@"1 -> Display book details
                 2 -> Update book price
                 3 -> Update book stock
                 4 -> Exit");
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit

                int choice = 0; // TODO: Read user 
                // choice

                Console.WriteLine("ENter the choice");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                    Console.WriteLine("ENter the new Price");
                    int newPrice=int.Parse(Console.ReadLine());
                    utility.UpdateBookPrice(newPrice);
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        break;

                    case 3:
                    Console.WriteLine("Enter the new Stock");
                    int newStock=int.Parse(Console.ReadLine());

                    utility.UpdateBookStock(newStock);
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        break;
                }
            }
        }
    }
}
