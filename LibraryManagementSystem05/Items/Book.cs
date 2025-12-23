using System;
namespace LibrarySystem.Items
{
    public class Book : LibraryItem
    {
        public override void DisplayItemDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ItemID: {ItemID}");
        }

        public override double CalculateLateFee(int days)
        {
            return days * 1;
        }
    }
}