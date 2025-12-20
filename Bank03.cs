using System;

class Bank03
{
    class Account
    {
        private int bankAccount;
        private double balance;

        // Constructor
        public Account(int accountNumber, double initialBalance = 0)
        {
            BankAccount = accountNumber;
            Balance = initialBalance;
        }

        // Properties with validation
        public int BankAccount
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        // Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. Updated balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. Updated balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }

    class Wallet
    {
        private double money;

        // Constructor
        public Wallet(double initialMoney = 0)
        {
            Money = initialMoney;
        }

        // Property
        public double Money
        {
            get { return money; }
            private set
            {
                if (value >= 0)
                    money = value;
                else
                    Console.WriteLine("Wallet money cannot be negative.");
            }
        }

        // Methods
        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                Money += amount;
                Console.WriteLine($"Added {amount} to wallet. Wallet balance: {Money}");
            }
            else
            {
                Console.WriteLine("Add amount must be positive.");
            }
        }

        public void Spend(double amount)
        {
            if (amount > 0 && amount <= Money)
            {
                Money -= amount;
                Console.WriteLine($"Spent {amount} from wallet. Wallet balance: {Money}");
            }
            else
            {
                Console.WriteLine("Invalid spend amount or insufficient wallet funds.");
            }
        }

        public double GetBalance()
        {
            return Money;
        }
    }

    class Employee
    {
        private string name;
        private double salary;

        // Constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary cannot be negative.");
            }
        }

        // Method
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    public static void Main(string[] args)
    {
        // Create account and employee
        Account account01 = new Account(1, 10000);
        Employee employee01 = new Employee("Vedant", 50000);

        // Perform account operations
        account01.Deposit(5000);
        account01.Withdraw(2000);

        // Create wallet and transfer money
        Wallet wallet01 = new Wallet();
        wallet01.AddMoney(1000);  // Simulate adding money to wallet
        account01.Withdraw(500);  // Withdraw from account
        wallet01.AddMoney(500);   // Add to wallet

        // Display details
        employee01.DisplayEmployeeDetails();
        Console.WriteLine($"Account Balance: {account01.Balance}");
        Console.WriteLine($"Wallet Balance: {wallet01.GetBalance()}");
    }
}