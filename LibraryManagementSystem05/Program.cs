using System;

using ItemsAlias = LibrarySystem.Items;
namespace LibraryManagementSystem05
{
    class Program
    {
        static void Main()
        {
            var book = new ItemsAlias.Book
            {
                Title = "MEAN Stack Development",
                Author = "John Doe",
                ItemID = 101
            };

            var magazine = new ItemsAlias.Magazine
            {
                Title = "Tech Today",
                Author = "Jane Smith",
                ItemID = 202
            };
            
            book.DisplayItemDetails();
            magazine.DisplayItemDetails();

            Console.WriteLine($"Book Late Fee for 5 days: {book.CalculateLateFee(5)}");
            Console.WriteLine($"Magazine Late Fee for 5 days: {magazine.CalculateLateFee(5)}");
        }
    }
}