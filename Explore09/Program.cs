using System;
using System.IO;


class InsuffiecientBalException : Exception
{
    public InsuffiecientBalException(string message) : base(message) { }
}


class BankAccount
{
    public decimal Balance { get; private set; } = 5000;

    public void Withdraw(decimal amt)
    {
        if (amt <= 0)
            throw new ArgumentException("Withdraw amount must be greater than 0");

        if (amt > Balance)
            throw new InsuffiecientBalException("Insufficient balance");

        Balance -= amt;
        Console.WriteLine("Withdrawal successful. Remaining balance: " + Balance);
    }
}


static class ExceptionLogger
{
    static void LogException(Exception ex)
    {
        File.AppendAllText(
            "error.log",
            DateTime.Now + " | " +
            ex.GetType().Name + " | " +
            ex.Message + Environment.NewLine
        );
    }


    public static void Log(Exception ex)
    {
        LogException(ex);
    }
}

class TryCatchCaller
{
    public static void TryCatchCallerM()
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter withdraw amount: ");
            decimal amt;
            decimal.TryParse(Console.ReadLine(),out amt);

            account.Withdraw(amt);

            // Arithmetic exception (intentional)
            int serviceCharge = 100;
            int divisionCheck = serviceCharge / int.Parse("0");

            // File access
            string data = System.IO.File.ReadAllText("acount.txt");
            Console.WriteLine(data);
        }
        catch (FormatException ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine("Arithmetic error occurred.");
        }
        catch (FileNotFoundException ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine("Required file not found.");
        }
        catch (InsuffiecientBalException ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            ExceptionLogger.Log(ex);
            Console.WriteLine("Unexpected error occurred.");
        }
    }
}


