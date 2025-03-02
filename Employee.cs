// Employee.cs
// This file contains the Employee class definition with operator overloading

/// <summary>
/// Represents an employee with basic identification information
/// </summary>
public class Employee
{
    // Properties for employee identification
    /// <summary>
    /// Unique identifier for the employee
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// First name of the employee
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Last name of the employee
    /// </summary>
    public string LastName { get; set; }
    
    // Constructor with parameters
    /// <summary>
    /// Creates a new Employee with specified ID, first name, and last name
    /// </summary>
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;                  // Set the employee ID
        FirstName = firstName;    // Set the employee's first name
        LastName = lastName;      // Set the employee's last name
    }
    
    // Default constructor
    /// <summary>
    /// Creates a new Employee with default values
    /// </summary>
    public Employee()
    {
        Id = 0;                   // Default ID is 0
        FirstName = string.Empty; // Default first name is empty string
        LastName = string.Empty;  // Default last name is empty string
    }
    
    // Overload the equality operator (==)
    /// <summary>
    /// Compares two Employee objects for equality based on their Id property
    /// </summary>
    /// <param name="employee1">First employee to compare</param>
    /// <param name="employee2">Second employee to compare</param>
    /// <returns>True if both employees have the same Id, otherwise false</returns>
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null
        if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            return true;
            
        // Check if either object is null
        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            return false;
            
        // Compare the Id properties of both employees
        return employee1.Id == employee2.Id;
    }
    
    // Overload the inequality operator (!=)
    /// <summary>
    /// Compares two Employee objects for inequality based on their Id property
    /// </summary>
    /// <param name="employee1">First employee to compare</param>
    /// <param name="employee2">Second employee to compare</param>
    /// <returns>True if employees have different Ids, otherwise false</returns>
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Use the negation of the equality operator
        return !(employee1 == employee2);
    }
    
    // Override Equals method to maintain consistency with == operator
    /// <summary>
    /// Determines whether the specified object is equal to the current Employee
    /// </summary>
    /// <param name="obj">The object to compare with the current Employee</param>
    /// <returns>True if the specified object is equal to the current Employee, otherwise false</returns>
    public override bool Equals(object obj)
    {
        // Check if obj is an Employee
        if (obj is Employee employee)
        {
            // Compare the Id properties
            return Id == employee.Id;
        }
        return false;
    }
    
    // Override GetHashCode to maintain consistency with Equals
    /// <summary>
    /// Returns a hash code for this Employee
    /// </summary>
    /// <returns>A hash code based on the Id property</returns>
    public override int GetHashCode()
    {
        // Use the Id property for the hash code
        return Id.GetHashCode();
    }
    
    // Override ToString for better display
    /// <summary>
    /// Returns a string representation of the Employee
    /// </summary>
    /// <returns>A string containing the employee's details</returns>
    public override string ToString()
    {
        // Return a formatted string with employee details
        return $"Employee [Id: {Id}, Name: {FirstName} {LastName}]";
    }
} 