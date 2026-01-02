using System.Linq;

class Program
{
    static void Main()
    {

        // Console.WriteLine("Creating objects ... ");
        // for (int i = 0; i < 5; i++)
        // {
        //     MyClass obj = new MyClass();
        // }

        // Console.WriteLine("Forcing garbage collection ... ");
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine("Garbage collection completed.");


        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        evenNumbers.GetType();

        Console.WriteLine("Even numbers are:");
        foreach (var n in evenNumbers) Console.WriteLine(n);

        numbers.Where(n => n >3).Select(n => n *2);
        var result = numbers.Where()
    }



}

class MyClass
{

    ~MyClass()
    {

        Console.WriteLine("Finalizer called, object collected.");
    }
}


