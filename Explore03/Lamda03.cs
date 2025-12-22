using System;

class Lamda03
{
    static void Main()
    {
        var instance = new Lamda03();
        instance.Example();
    }

    void Example()
    {
        int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;

        Console.WriteLine(Square(4));
        Console.WriteLine(squareLambda(4));
    }
}