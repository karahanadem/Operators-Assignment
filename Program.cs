// Program.cs
// This file contains the main program that demonstrates the Employee class and operator overloading

using System; // Add the System namespace for Console class

/// <summary>
/// Main program class
/// </summary>
class Program
{
    /// <summary>
    /// Entry point of the application
    /// </summary>
    static void Main(string[] args)
    {
        // Display a welcome message
        Console.WriteLine("Employee Comparison Demonstration");
        Console.WriteLine("================================");
        Console.WriteLine();
        
        // Create the first employee with ID 101
        // Instantiate a new Employee object with ID 101 and name "John Smith"
        Employee employee1 = new Employee(101, "John", "Smith");
        
        // Create the second employee with ID 102
        // Instantiate a new Employee object with ID 102 and name "Jane Doe"
        Employee employee2 = new Employee(102, "Jane", "Doe");
        
        // Create a third employee with the same ID as the first one
        // Instantiate a new Employee object with ID 101 (same as employee1) but different name
        Employee employee3 = new Employee(101, "Robert", "Johnson");
        
        // Display information about the created employees
        Console.WriteLine("Created Employees:");
        Console.WriteLine($"Employee 1: {employee1}");  // Uses the overridden ToString method
        Console.WriteLine($"Employee 2: {employee2}");  // Uses the overridden ToString method
        Console.WriteLine($"Employee 3: {employee3}");  // Uses the overridden ToString method
        Console.WriteLine();
        
        // Compare employee1 and employee2 using the overloaded == operator
        // This will compare their Id properties
        Console.WriteLine("Comparison Results:");
        Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");  // Should be false (different IDs)
        Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");  // Should be true (different IDs)
        
        // Compare employee1 and employee3 using the overloaded == operator
        // They have the same ID but different names
        Console.WriteLine($"employee1 == employee3: {employee1 == employee3}");  // Should be true (same IDs)
        Console.WriteLine($"employee1 != employee3: {employee1 != employee3}");  // Should be false (same IDs)
        
        // Wait for user input before closing the console window
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
} 