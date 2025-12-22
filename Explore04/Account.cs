class Account
{
    //Property with private set: AccountNo can be read publicly but set only inside the class.
    //This protects value from external modification, ensuring it's set only via a constructor.
    //Useful for sensitive or immutable data like account numbers.
    public int AccountNo{get; private set;}
    //Constructor: Sets AccountNo internally, demonstrating private set usage.
    public Account(int accNo)
    {
        AccountNo = accNo;//Allowed because set is private (accessible within the class)
    }
}