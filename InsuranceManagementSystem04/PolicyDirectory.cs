using System;


public class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();

    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }

    public InsurancePolicy this[int index]
    {
        get => policies[index];
    }

    public InsurancePolicy this[string name]
    {
        get
        {
            foreach(var policy in policies)
            {
                if(policy.PolicyHolderName == name)
                {
                    return policy;
                }
            }
            throw new KeyNotFoundException("Policy not found for the given name.");
        }
    }
}