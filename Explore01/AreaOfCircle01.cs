using System;

class AreaOfCircle01
{
    public static void Main(string[] args)
    {
        Console.Write("enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.Write("The area of the circle is: " + area);
    }
}