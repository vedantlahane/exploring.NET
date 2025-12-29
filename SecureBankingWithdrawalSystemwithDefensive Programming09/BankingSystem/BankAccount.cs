namespace BankingSystem;
class InsufficientBalanceException: Exception
{
    public InsufficientBalanceException(string message): base(message){}
}
class BankAccount
{
    public string? AccountNumber {get; private set;}
    public decimal Balance { get; private set; }

    BankAccount(string accountNumber, decimal initialBalance)
    {
        if(string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account number cannot be null, empty, or whitespace.",nameof(accountNumber));
        }

        if(initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
        }
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    public void Withdraw(decimal amount)
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
}
