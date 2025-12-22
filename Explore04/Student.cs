using System; // Required for Console.WriteLine in setters

class Student
{
    // Private fields for encapsulation: Data is hidden and accessed only via properties.
    private string name;
    private int age;
    private int marks;

    // Property for Name: Getter returns the value, setter validates it's not empty before assigning.
    // This enforces business logic (name cannot be empty) and demonstrates encapsulation.
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name cannot be Empty");
            }
        }
    }

    // Property for Age: Getter returns the value, setter validates age > 0.
    // Ensures data integrity by rejecting invalid ages.
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age must be greater than 0");
            }
        }
    }

    // Property for Marks: Getter returns the value, setter validates 0 <= marks <= 100.
    // Applies business rules to keep marks within valid range.
    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100) { marks = value; }
            else { Console.WriteLine("Marks must be between 0 and 100"); }
        }
    }

    // Auto-implemented property for StudentId: No backing field needed, direct get/set.
    // Used for data that doesn't require validation (e.g., unique ID).
    public int StudentId
    {
        get;
        set;
    }

    // Read-only property for ResultStatus: Only getter, computes pass/fail based on marks.
    // Demonstrates computed properties; value depends on other fields (marks >= 35 for pass).
    public string ResultStatus
    {
        get { return marks >= 35 ? "Pass" : "Fail"; }
    }

    // Private field for password: Not exposed directly for security.
    private string password;
    // Write-only property for Password: Only setter, no getter to prevent reading.
    // Protects sensitive data; useful for one-way assignment.
    public string Password
    {
        set { password = value; }
    }


    private int registrationNumber;
    public int RegistrationNumber
    {
        get{return registrationNumber;}
        private set{registrationNumber = value;}
    }

    public int AdmissionYear{get; init;}

    public double Percentage => (Marks / 100.0) * 100.0;
    // Constructor: Initializes the object with provided values using properties.
    // Ensures validation is applied during creation (e.g., via setters).
    public Student(string s, int a, int m, int id, int redNo)
    {
        Name = s;
        Age = a;
        Marks = m;
        StudentId = id;
        RegistrationNumber = redNo;
    }
}