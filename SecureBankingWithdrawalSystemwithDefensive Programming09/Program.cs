// MODULE 3: APPLICATION EXECUTION & TESTING

// TASK 9 – Program Execution and Exception Handling
using BankingSystem;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Create a bank account with an initial balance
            BankAccount account = new BankAccount("12345", 1000.00m);

            // Attempt a withdrawal that exceeds the balance
            account.Withdraw(1500.00m);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Insufficient balance: {ex.Message}");
        }
        catch (BankOperationException ex)
        {
            Console.WriteLine($"Bank operation error: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Root cause: {ex.InnerException.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}