// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"); // Commented out original template code
using System; // Required for Console and classes

/// <summary>
/// Main program class demonstrating various OOP concepts including properties, inheritance, interfaces, etc.
/// </summary>
class Program
{
    /// <summary>
    /// Entry point of the console application.
    /// Demonstrates creating objects, setting properties, displaying results, and various inheritance concepts.
    /// </summary>
    /// <param name="args">Command line arguments (not used).</param>
    static void Main(string[] args)
    {
        // Section 1: Demonstrating Student class properties
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

        // Section 2: Demonstrating Circle class
        // Create a Circle object and display its read-only Area property.
        Circle c = new Circle(2.2);
        Console.WriteLine($"Circle Area: {c.Area}");

        // Section 3: Demonstrating EmployeeDirectory indexer
        EmployeeDirectory ed = new EmployeeDirectory();

        
        ed[101] = "Ravi";

        Console.WriteLine(ed[101]);
        Console.WriteLine(ed["Ravi"]);

        // Section 4: Inheritance examples
        // 4.1 Basic Inheritance: Car inherits from Vehicle
        Console.WriteLine("\n--- Basic Inheritance ---");
        Car car = new Car();
        car.Start();   // inherited method
        car.Drive();   // own method

        // 4.2 Inheritance with Constructor: StudentInheritance inherits from Person
        Console.WriteLine("\n--- Inheritance with Constructor ---");
        StudentInheritance si = new StudentInheritance("John", 101);
        Console.WriteLine($"Name: {si.Name}, RollNo: {si.RollNo}");

        // 4.3 Single Inheritance: Dog inherits from Animal
        Console.WriteLine("\n--- Single Inheritance ---");
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        // 4.4 Multilevel Inheritance: EmployeeInheritance inherits from Human, which inherits from LivingBeing
        Console.WriteLine("\n--- Multilevel Inheritance ---");
        EmployeeInheritance ei = new EmployeeInheritance();
        ei.Breathe();
        ei.Think();
        ei.Work();

        // 4.5 Interfaces: Machine implements IPrintable and IScannable
        Console.WriteLine("\n--- Interfaces ---");
        Machine m = new Machine();
        m.Print();
        m.Scan();

        // 4.6 Method Overriding: DogOverride overrides Sound from AnimalOverride
        Console.WriteLine("\n--- Method Overriding ---");
        DogOverride do_ = new DogOverride();
        do_.Sound();

        // 4.7 Composition: CarComposition contains an Engine object
        Console.WriteLine("\n--- Composition ---");
        CarComposition cc = new CarComposition();
        cc.Drive();

        // 4.8 Method Hiding: ChildHiding hides Show method from ParentHiding using 'new'
        Console.WriteLine("\n--- Method Hiding ---");
        ParentHiding ph = new ParentHiding();
        ph.Show();
        ChildHiding ch = new ChildHiding();
        ch.Show();
        ((ParentHiding)ch).Show(); // Calls parent method
    }
}