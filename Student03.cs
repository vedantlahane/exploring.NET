using System;
class Student03
{
    public static void GetResult(int marks, out string grade)
    {
        if (marks >= 60)
            grade = "Pass";
        else
            grade = "Fail";
    }

    class Display
    {
        public static void Show(in int number)
        {
            Console.WriteLine(number);
            
            // number = number + 10;   // Not allowed
        }
    }

    static void Main()
    {
        string result;
        Student03.GetResult(75, out result);
        Console.WriteLine(result);

        int num = 50;
        Display.Show(in num);
    }
}