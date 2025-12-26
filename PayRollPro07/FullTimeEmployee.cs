using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }

    public override double GetMonthlyPay()
    {
        return (WeeklyHours?.Sum() ?? 0) * HourlyRate + MonthlyBonus;
    }
}