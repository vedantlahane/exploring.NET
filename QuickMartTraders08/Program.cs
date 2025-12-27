class Program
{
    public static SaleTransaction? LastTransaction;
    public static bool HasLastTransaction = false;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("================== QuickMart Traders ==================\n1. Create New Transaction (Enter Purchase & Selling Details)\n2. View Last Transaction\n3. Calculate Profit/Loss (Recompute & Print)\n4. Exit\nEnter your option:");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    LastTransaction = new SaleTransaction();
                    Console.Write("Enter Invoice No: ");
                    LastTransaction.InvoiceNo = Console.ReadLine();
                    Console.Write("Enter Customer Name: ");
                    LastTransaction.CustomerName = Console.ReadLine();
                    Console.Write("Enter Item Name: ");
                    LastTransaction.ItemName = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int quantity;
                    int.TryParse(Console.ReadLine(), out quantity);
                    LastTransaction.Quantity = quantity;
                    Console.Write("Enter Purchase Amount (total): ");
                    decimal purchaseAmount;
                    decimal.TryParse(Console.ReadLine(), out purchaseAmount);
                    LastTransaction.PurchaseAmount = purchaseAmount;
                    Console.Write("Enter Selling Amount (total): ");
                    decimal sellingAmount;
                    decimal.TryParse(Console.ReadLine(), out sellingAmount);
                    LastTransaction.SellingAmount = sellingAmount;
                    HasLastTransaction = true;
                    Console.WriteLine("Transaction saved successfully.");
                    Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus()}");
                    Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount(LastTransaction.ProfitOrLossStatus()):F2}");
                    Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent(LastTransaction.ProfitOrLossAmount(LastTransaction.ProfitOrLossStatus())):F2}");
                    break;
                case 2:
                    Console.WriteLine("-------------- Last Transaction --------------");
                    Console.WriteLine($"InvoiceNo: {LastTransaction?.InvoiceNo}");
                    Console.WriteLine($"Customer: {LastTransaction?.CustomerName}");
                    Console.WriteLine($"Item: {LastTransaction?.ItemName}");
                    Console.WriteLine($"Quantity: {LastTransaction?.Quantity}");
                    Console.WriteLine($"Purchase Amount: {LastTransaction?.PurchaseAmount:F2}");
                    Console.WriteLine($"Selling Amount: {LastTransaction?.SellingAmount:F2}");
                    Console.WriteLine($"Status: {LastTransaction?.ProfitOrLossStatus()}");
                    Console.WriteLine($"Profit/Loss Amount: {LastTransaction?.ProfitOrLossAmount(LastTransaction?.ProfitOrLossStatus() ?? ""):F2}");
                    Console.WriteLine($"Profit Margin (%): {LastTransaction?.ProfitMarginPercent(LastTransaction?.ProfitOrLossAmount(LastTransaction?.ProfitOrLossStatus() ?? "") ?? 0):F2}");
                    Console.WriteLine("--------------------------------------------");
                    break;
                case 3:
                    HasLastTransaction = false;
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }
    }
}