using System;
using System.Collections.Generic;
using LibrarySystem.Interfaces;
using LibrarySystem.Users;
using ItemsAlias = LibrarySystem.Items;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management System Assignment");
            Console.WriteLine("------------------------------------");

            // TASK 1: Abstract Class & Abstract Methods
            Console.WriteLine("\nTASK 1: Abstract Class & Abstract Methods");
            ItemsAlias.Book book = new ItemsAlias.Book
            {
                Title = "C# Fundamentals",
                Author = "John Doe",
                ItemID = 101
            };

            ItemsAlias.Magazine magazine = new ItemsAlias.Magazine
            {
                Title = "Tech Today",
                Author = "Jane Doe",
                ItemID = 201
            };

            book.DisplayItemDetails();
            Console.WriteLine($"Late Fee for 3 days: {book.CalculateLateFee(3)}");

            magazine.DisplayItemDetails();
            Console.WriteLine($"Late Fee for 3 days: {magazine.CalculateLateFee(3)}");

            // TASK 2 & 4: Interfaces & Explicit Implementation
            Console.WriteLine("\nTASK 2 & 4: Interfaces & Explicit Implementation");
            IReservable reservableBook = book;
            reservableBook.Reserve();

            INotifiable notifiableBook = book;
            notifiableBook.Notify("Please return the book on time.");
            
            Console.WriteLine("Explicit implementation prevents direct access and exposes functionality only through interfaces.");

            // TASK 3: Dynamic Polymorphism
            Console.WriteLine("\nTASK 3: Dynamic Polymorphism");
            List<ItemsAlias.LibraryItem> items = new List<ItemsAlias.LibraryItem>();
            items.Add(book);
            items.Add(magazine);

            foreach (var item in items)
            {
                item.DisplayItemDetails();
            }
            Console.WriteLine("The method executed depends on the object type at runtime, not the reference type.");

            // TASK 5: Namespaces & Nested Namespaces
            Console.WriteLine("\nTASK 5: Namespaces & Nested Namespaces");
            Console.WriteLine("Book and Magazine objects created using namespace alias.");
            Console.WriteLine("1. Nested namespaces organize large projects logically.");
            Console.WriteLine("2. Aliases reduce long namespace references and improve readability.");

            // TASK 6: Partial & Static Classes
            Console.WriteLine("\nTASK 6: Partial & Static Classes");
            LibraryAnalytics.TotalBorrowedItems = 5; // Simulate borrowing
            LibraryAnalytics.DisplayAnalytics();
            Console.WriteLine("Static members store system-wide data shared across all objects.");

            // TASK 7: Enumerations (Enums)
            Console.WriteLine("\nTASK 7: Enumerations (Enums)");
            Member member = new Member
            {
                Name = "Alice",
                Role = UserRole.Member
            };
            book.Status = ItemStatus.Borrowed;

            Console.WriteLine($"User Role: {member.Role}");
            Console.WriteLine($"Item Status: {book.Status}");
            Console.WriteLine("Enums prevent invalid values and improve code readability.");

            // BONUS TASK
            Console.WriteLine("\nBONUS TASK: Advanced Design");
            
            // Notification based on role
            Member admin = new Member { Name = "Bob", Role = UserRole.Admin };
            
            NotifyUser(admin, "System maintenance scheduled.");
            NotifyUser(member, "Your borrowed item is due tomorrow.");

            // eBook behavior
            ItemsAlias.eBook ebook = new ItemsAlias.eBook
            {
                Title = "Digital Fortress",
                Author = "Dan Brown",
                ItemID = 301
            };
            ebook.Download();
        }

        static void NotifyUser(Member user, string message)
        {
            if (user.Role == UserRole.Admin)
            {
                Console.WriteLine($"Admin Alert: {message}");
            }
            else if (user.Role == UserRole.Member)
            {
                Console.WriteLine($"Member Notification: {message}");
            }
        }
    }
}