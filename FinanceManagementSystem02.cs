using System;

class FinanceManagementSystem02
{
    class Debit
    {
        public void ATMWithdrawalLimitValidation()
        {
            const int dailyLimit = 40000;
            Console.Write("Enter withdrawal amount: ");
            int amount = int.Parse(Console.ReadLine());

            if (amount <= dailyLimit)
                Console.WriteLine("Withdrawal permitted within daily limit.");
            else
                Console.WriteLine("Daily ATM withdrawal limit exceeded.");
        }

        public void EMIValidation()
        {
            Console.Write("Enter monthly income: ");
            double income = double.Parse(Console.ReadLine());
            Console.Write("Enter EMI amount: ");
            double emi = double.Parse(Console.ReadLine());

            if (emi <= (income * 0.40))
                Console.WriteLine("EMI is financially manageable.");
            else
                Console.WriteLine("EMI exceeds safe income limit.");
        }

        public void SpendingCalculator()
        {
            Console.Write("Enter number of transactions: ");
            int count = int.Parse(Console.ReadLine());
            double totalSpending = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter amount for transaction {i}: ");
                totalSpending += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total debit amount for the day: ₹{totalSpending}");
        }

        public void MinimumBalanceCheck()
        {
            const int minBalance = 2000;
            Console.Write("Enter current balance: ");
            int balance = int.Parse(Console.ReadLine());

            if (balance < minBalance)
                Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
            else
                Console.WriteLine("Minimum balance requirement satisfied.");
        }
    }

    class Credit
    {
        public void SalaryCreditCalculation()
        {
            Console.Write("Enter gross salary: ");
            double gross = double.Parse(Console.ReadLine());
            double netSalary = gross - (gross * 0.10);
            Console.WriteLine($"Net salary credited: ₹{netSalary}");
        }

        public void MaturityCalculation()
        {
            Console.Write("Enter principal amount: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Enter time period (years): ");
            double t = double.Parse(Console.ReadLine());

            double interest = (p * r * t) / 100;
            double maturityAmount = p + interest;
            Console.WriteLine($"Fixed Deposit maturity amount: ₹{maturityAmount}");
        }

        public void RewardPointsEvaluation()
        {
            Console.Write("Enter total credit card spending: ");
            double spending = double.Parse(Console.ReadLine());
            int points = (int)(spending / 100);
            Console.WriteLine($"Reward points earned: {points}");
        }

        public void BonusEligibilityCheck()
        {
            Console.Write("Enter annual salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter years of service: ");
            int years = int.Parse(Console.ReadLine());

            if (salary >= 500000 && years >= 3)
                Console.WriteLine("Employee is eligible for bonus.");
            else
                Console.WriteLine("Employee is not eligible for bonus.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Debit debitObj = new Debit();
            Credit creditObj = new Credit();

            while (true)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("FINANCE MANAGEMENT SYSTEM");
                Console.WriteLine("1. Debit Operations");
                Console.WriteLine("2. Credit Operations");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string mainChoice = Console.ReadLine();

                if (mainChoice == "3") break;

                switch (mainChoice)
                {
                    case "1":
                        Console.WriteLine("\n--- DEBIT OPERATIONS ---");
                        Console.WriteLine("1. ATM Limit Check\n2. EMI Evaluation\n3. Spending Calculator\n4. Min Balance Check");
                        Console.Write("Select: ");
                        string dChoice = Console.ReadLine();
                        if (dChoice == "1") debitObj.ATMWithdrawalLimitValidation();
                        else if (dChoice == "2") debitObj.EMIValidation();
                        else if (dChoice == "3") debitObj.SpendingCalculator();
                        else if (dChoice == "4") debitObj.MinimumBalanceCheck();
                        break;

                    case "2":
                        Console.WriteLine("\n--- CREDIT OPERATIONS ---");
                        Console.WriteLine("1. Net Salary\n2. FD Maturity\n3. Reward Points\n4. Bonus Check");
                        Console.Write("Select: ");
                        string cChoice = Console.ReadLine();
                        if (cChoice == "1") creditObj.SalaryCreditCalculation();
                        else if (cChoice == "2") creditObj.MaturityCalculation();
                        else if (cChoice == "3") creditObj.RewardPointsEvaluation();
                        else if (cChoice == "4") creditObj.BonusEligibilityCheck();
                        break;

                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }
        }
    }
}
