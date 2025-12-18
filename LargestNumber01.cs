using System;

public class LargestNumber
{
    public static void Main(String[] args)
    {
        int a = 10, b = 25 , c= 8;
        if(a > b && a > c)
            Console.WriteLine($"Largest: {a}");
        else if(b > c)
            Console.WriteLine($"Largest: {b}");
        else
            Console.WriteLine($"Largest: {c}");
    }
}