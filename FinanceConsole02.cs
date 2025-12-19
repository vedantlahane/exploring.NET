using System;

class FinanceConsole
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Finance Console");
        int balance = 0;

        Console.Write("Enter Your Monthly Income: ");
        if (!int.TryParse(Console.ReadLine(), out int income))
        {
            Console.WriteLine("Invalid income.");
            return;
        }
        balance += income;

        Console.Write("Enter Your age: ");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid age.");
            return;
        }



        while (true)
        {
            Console.WriteLine("----------------------------------\nEnter 1 to Check Loan Eligibility, 2 to Calculate Income Tax, 3 for Banking Operations, 4 for Exit");
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }
            if(input == 4)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            switch (input)
            {
                case 1:
                    if (income >= 30000 && age >= 21) Console.WriteLine("You are eligible to take loan");
                    else Console.WriteLine("You are not eligible to take loan");
                    break;

                case 2:
                    int annual = income * 12;
                    if (annual <= 250000) Console.WriteLine("You are in 0% bracket of Income Tax.");
                    else if (annual < 500000) Console.WriteLine($"You are in 5% bracket of Income Tax.\nTax on you is {annual / 20}");
                    else if (annual < 1000000) Console.WriteLine($"You are in 20% bracket of Income Tax.\nTax on you is {annual / 5}");
                    else Console.WriteLine($"You are in 30% bracket of Income Tax.\nTax on you is {annual * 3 / 10}");
                    break;

                case 3:
                    int count = 0;
                    Console.WriteLine("Enter 1 to Deposit, 2 to Withdraw and 3 to Check Balance");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid choice.");
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            while (true)
                            {
                                Console.WriteLine("Enter amount to deposit or 0 to cancel:");
                                if (!int.TryParse(Console.ReadLine(), out int deposit))
                                {
                                    Console.WriteLine("Invalid amount.");
                                    continue;
                                }
                                if (deposit < 0)
                                {
                                    Console.WriteLine("Amount must be greater than zero.\nPlease try again.");
                                }
                                else
                                {
                                    if (deposit == 0 || count == 5) break;
                                    balance += deposit;
                                    count++;
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the amount to withdraw or 0 to cancel:");
                            if (!int.TryParse(Console.ReadLine(), out int withdraw))
                            {
                                Console.WriteLine("Invalid amount.");
                                break;
                            }
                            if (withdraw < 0)
                            {
                                Console.WriteLine("Amount must be greater than zero.\nPlease try again.");
                            }
                            else
                            {
                                if (withdraw == 0 || count == 5) break;
                                balance -= withdraw;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Your current balance is: " + balance);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
}