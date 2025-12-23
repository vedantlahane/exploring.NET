using System;
public class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return base.CalculatePremium() * 1.1;
    }
}