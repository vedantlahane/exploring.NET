using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<EmployeeRecord> PayrollBoard { get; } = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        var result = new Dictionary<string, int>();

        foreach (var r in records)
        {
            if (r.WeeklyHours == null) continue;
            int count = r.WeeklyHours.Count(h => h >= hoursThreshold);
            if (count > 0) result[r.EmployeeName] = count;
        }

        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0) return 0;
        return PayrollBoard.Average(e => e.GetMonthlyPay());
    }

    public static void Main()
    {
        var app = new Program();
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice:");
            var choice = Console.ReadLine()?.Trim();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract):");
                var type = Console.ReadLine()?.Trim();

                Console.WriteLine();
                Console.WriteLine("Enter Employee Name:");
                var name = Console.ReadLine()?.Trim();

                Console.WriteLine();
                Console.WriteLine("Enter Hourly Rate:");
                if (!double.TryParse(Console.ReadLine(), out var hourlyRate)) hourlyRate = 0;

                double monthlyBonus = 0;
                if (type == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Monthly Bonus:");
                    if (!double.TryParse(Console.ReadLine(), out monthlyBonus)) monthlyBonus = 0;
                }

                Console.WriteLine();
                Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                var hours = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    if (!double.TryParse(Console.ReadLine(), out var h)) h = 0;
                    hours[i] = h;
                }

                EmployeeRecord record = null;
                if (type == "1")
                {
                    record = new FullTimeEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = hourlyRate,
                        MonthlyBonus = monthlyBonus,
                        WeeklyHours = hours
                    };
                }
                else // treat anything else as contract
                {
                    record = new ContractEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = hourlyRate,
                        WeeklyHours = hours
                    };
                }

                app.RegisterEmployee(record);
                Console.WriteLine();
                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Enter hours threshold:");
                if (!double.TryParse(Console.ReadLine(), out var threshold)) threshold = 0;
                var summary = app.GetOvertimeWeekCounts(PayrollBoard, threshold);
                Console.WriteLine();
                if (summary.Count == 0)
                {
                    Console.WriteLine("No overtime recorded this month");
                }
                else
                {
                    foreach (var kv in summary)
                    {
                        Console.WriteLine($"{kv.Key} - {kv.Value}");
                    }
                }
            }
            else if (choice == "3")
            {
                var avg = app.CalculateAverageMonthlyPay();
                Console.WriteLine();
                // print integer if whole number, otherwise print full value
                if (Math.Abs(avg - Math.Round(avg)) < 1e-9)
                    Console.WriteLine($"Overall average monthly pay: {Convert.ToInt64(Math.Round(avg))}");
                else
                    Console.WriteLine($"Overall average monthly pay: {avg}");
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Logging off — Payroll processed successfully!");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3 or 4.");
            }
        }
    }
}
