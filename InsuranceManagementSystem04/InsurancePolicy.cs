using System;
public class InsurancePolicy
{
    public int PolicyNumber{get; init;}
    private double premium;
    public double Premium
    {
        get { return premium; }
        set
        {
            if(value <= 0) throw new ArgumentException("Premium must be greater than zero.");
            premium = value;
        }
    }
    
    public string PolicyHolderName{get;set;}

    public virtual double CalculatePremium() { return Premium;}

    public void DisplayPolicyInfo(){ Console.WriteLine("Insurance Policy");}
}