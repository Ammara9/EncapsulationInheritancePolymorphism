// Defines a namespace 'Polymorphism' to demonstrate the concept of polymorphism through error handling.

namespace Polymorphism
{
    // Abstract base class 'UserError' that defines the structure for different types of user errors.
    public abstract class UserError
    {
        // Abstract method 'UEMessage' that must be implemented by any subclass.
        // This method returns a string that describes the specific error message.
        public abstract string UEMessage();
    }

    // Class 'NumericInputError' that inherits from 'UserError'.
    // Represents an error when a numeric input is used in a text-only field.
    public class NumericInputError : UserError
    {
        // Overrides the 'UEMessage' method to return a specific error message for numeric input errors.
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    // Class 'TextInputError' that inherits from 'UserError'.
    // Represents an error when a text input is used in a numeric-only field.
    public class TextInputError : UserError
    {
        // Overrides the 'UEMessage' method to return a specific error message for text input errors.
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // Class 'FileNotFoundError' that inherits from 'UserError'.
    // Represents an error when a specified file is not found.
    public class FileNotFoundError : UserError
    {
        // Overrides the 'UEMessage' method to return a specific error message for file-not-found errors.
        public override string UEMessage()
        {
            return "The specified file was not found. This fired an error!";
        }
    }

    // Class 'PermissionDeniedError' that inherits from 'UserError'.
    // Represents an error when the user lacks the necessary permissions.
    public class PermissionDeniedError : UserError
    {
        // Overrides the 'UEMessage' method to return a specific error message for permission denial errors.
        public override string UEMessage()
        {
            return "You do not have the required permissions. This fired an error!";
        }
    }

    // Class 'OutOfMemoryError' that inherits from 'UserError'.
    // Represents an error when the system runs out of memory.
    public class OutOfMemoryError : UserError
    {
        // Overrides the 'UEMessage' method to return a specific error message for out-of-memory errors.
        public override string UEMessage()
        {
            return "The system ran out of memory. This fired an error!";
        }
    }
}
