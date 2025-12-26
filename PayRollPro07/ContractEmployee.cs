using System.Linq;

public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }

    public override double GetMonthlyPay()
    {
        return (WeeklyHours?.Sum() ?? 0) * HourlyRate;
    }
}