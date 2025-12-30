// MODULE 1: BANK ACCOUNT MANAGEMENT

// TASK 1 – Namespace and Class Design
namespace BankingSystem;

using System.IO;

// MODULE 2: CUSTOM EXCEPTION HANDLING

// TASK 7 – Insufficient Balance Exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

// TASK 8 – Bank Operation Exception with Inner Exception
class BankOperationException : Exception
{
    public BankOperationException(string message, Exception innerException) : base(message, innerException) { }
}

// TASK 1 – Namespace and Class Design (continued with class)
class BankAccount
{
    // TASK 2 – Data Members and Access Control
    public string? AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    // TASK 3 – Constructor with Validation
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account number cannot be null, empty, or whitespace.", nameof(accountNumber));
        }

        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
        }
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // TASK 4 – Withdrawal Operation
    // TASK 5 – Defensive Exception Handling inside Withdraw
    public void Withdraw(decimal amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException($"Insufficient balance. Current balance: {Balance}, Requested withdrawal: {amount}");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: {Balance}");
        }
        catch (InsufficientBalanceException ex)
        {
            LogException(ex);
            throw;
        }
        catch (Exception ex)
        {
            LogException(ex);
            throw new BankOperationException("Unexpected error during withdrawal", ex);
        }
    }

    // TASK 6 – Exception Logging Mechanism
    private void LogException(Exception ex)
    {
        string logMessage = $"{DateTime.Now}: Account {AccountNumber} - {ex.ToString()}";
        File.AppendAllText("banking_log.txt", logMessage + Environment.NewLine);
    }
}
