using System;

class MultiplicationTable02
{
    public static void Main(String[] args)
    {
        for (int j = 20; j <= 30; j++)
        {
            Console.WriteLine($"Multiplication Table of {j}");
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{j} x {i} = {j * i}");
            Console.WriteLine("-------------------------------");
        }


    }
}