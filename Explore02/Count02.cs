using System;

class Count02
{
    public static void Main(String[] args)
    {

        Console.WriteLine("While loop examples");
        Console.WriteLine("----------------------");
        int count = 0;
        Console.WriteLine("Counting up:");
        while (count < 5) Console.WriteLine(count++);

        Console.WriteLine("----------------------");
        Console.WriteLine("Counting down:");
        while (count >= 0) Console.WriteLine(count--);

        Console.WriteLine("----------------------");  
        Console.WriteLine("Do-while example");

        Console.WriteLine("----------------------");
        Console.WriteLine("Counting up:");
        do{Console.WriteLine(count++);} while (count < 5);

        Console.WriteLine("----------------------");
        Console.WriteLine("Counting down:");

        do { Console.WriteLine(count--); } while (count >= 0);

    }
}