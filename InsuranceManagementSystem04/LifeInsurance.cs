using System;

public class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return base.CalculatePremium() + 100;
    }

    public new void DisplayPolicyInfo()
    {
        Console.WriteLine("Life Insurance Policy" + " for " + PolicyHolderName + "." + " with premium " + Premium + ".");
    }
}