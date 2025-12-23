using System;
class Program
{
    static void Main(string[] args)
    {
        Security.Authenticate();
        var lifePolicy = new LifeInsurance
        {
            PolicyNumber = 101,
            Premium = 5000,
            PolicyHolderName = "Vedant",
        };

        var healthPolicy = new HealthInsurance
        {
            PolicyNumber  = 102,
            Premium = 3000,
            PolicyHolderName = "Aarav",     
        };

        var directory = new PolicyDirectory();
        directory.AddPolicy(lifePolicy);
        directory.AddPolicy(healthPolicy);

        Console.WriteLine(directory["Vedant"].PolicyNumber);
        Console.WriteLine(directory[0].PolicyNumber);

        Console.WriteLine("Life Premium: " + directory["Vedant"].Premium);
        Console.WriteLine("Health Premium: " + directory["Aarav"].Premium);

        lifePolicy.DisplayPolicyInfo();
        ((InsurancePolicy)lifePolicy).DisplayPolicyInfo();
    }
}