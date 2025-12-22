// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"); // Commented out original template code
using System; // Required for Console and classes

class Program
{
    // Main method: Entry point of the console application.
    // Demonstrates creating objects, setting properties, and displaying results.
    static void Main(string[] args)
    {
        // Create a Student object using the constructor (validates via setters).
        // Note: Default constructor not available due to parameterized one; using provided constructor.
        Student s = new Student("Vedant", 22, 86, 125, 89859) { AdmissionYear = 2022 }; // Initializes with valid values
        // Access and display properties (getters).
        Console.Write($"Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}");

        // Set and display auto-implemented property (StudentId).
        s.StudentId = 125;
        Console.WriteLine($"StudentId: {s.StudentId}");

        // Display read-only property (ResultStatus), computed from marks.
        Console.WriteLine($"Results: {s.ResultStatus}");

        // Set write-only property (Password); cannot read it back.
        s.Password = "Abc123";
        // Console.WriteLine($"Password: {s.Password}");//Cannot be read back as no get method;

        // Create a Circle object and display its read-only Area property.
        Circle c = new Circle(2.2);
        Console.WriteLine($"Circle Area: {c.Area}");

        EmployeeDirectory ed = new EmployeeDirectory();

        
        ed[101] = "Ravi";

        Console.WriteLine(ed[101]);
        Console.WriteLine(ed["Ravi"]);
    }
}