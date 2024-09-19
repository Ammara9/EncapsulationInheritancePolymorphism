// Defines a class named 'Person' which holds information about a person: age, first name, last name, height, and weight.
public class Person
{
    // Private fields for storing the person's age, first name, last name, height, and weight.
    private int age;
    private string firstName = "";
    private string lastName = "";
    private double height;
    private double weight;

    // Property for 'Age' with basic validation:
    // Ensures the age is greater than 0, otherwise throws an exception.
    public int Age
    {
        get { return age; } // Returns the current value of 'age'.
        set
        {
            // Validates that the age is positive; if not, throws an ArgumentException.
            if (value > 0)
                age = value;
            else
                throw new ArgumentException("Age must be greater than 0.");
        }
    }

    // Property for 'FirstName' with validation:
    // Ensures the name is not empty, has at least 2 characters, and at most 10 characters.
    public string FirstName
    {
        get { return firstName; } // Returns the current value of 'firstName'.
        set
        {
            // Validates that the name is not null/whitespace and within the required length range.
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2 && value.Length <= 10)
                firstName = value;
            else
                throw new ArgumentException("First name must be between 2 and 10 characters.");
        }
    }

    // Property for 'LastName' with validation:
    // Ensures the last name is not empty or whitespace.
    public string LastName
    {
        get { return lastName; } // Returns the current value of 'lastName'.
        set
        {
            // Validates that the last name is not null or empty.
            if (!string.IsNullOrWhiteSpace(value))
                lastName = value;
            else
                throw new ArgumentException("Last name cannot be empty.");
        }
    }

    // Property for 'Height' with validation:
    // Ensures the height is greater than 0.
    public double Height
    {
        get { return height; } // Returns the current value of 'height'.
        set
        {
            // Validates that the height is positive; if not, throws an ArgumentException.
            if (value > 0)
                height = value;
            else
                throw new ArgumentException("Height must be greater than 0.");
        }
    }

    // Property for 'Weight' with validation:
    // Ensures the weight is greater than 0.
    public double Weight
    {
        get { return weight; } // Returns the current value of 'weight'.
        set
        {
            // Validates that the weight is positive; if not, throws an ArgumentException.
            if (value > 0)
                weight = value;
            else
                throw new ArgumentException("Weight must be greater than 0.");
        }
    }
}
