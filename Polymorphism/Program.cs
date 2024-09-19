// This program demonstrates polymorphism by using a list of different types of errors (subclasses of UserError) and calling a common method on each.

namespace Polymorphism
{
    internal class Program
    {
        // Main method: Entry point of the program.
        static void Main(string[] args)
        {
            // Create a list to store instances of various types of UserError.
            List<UserError> userError = new List<UserError>();

            // Add instances of different subclasses of UserError to the list.
            userError.Add(new NumericInputError()); // Adds a NumericInputError to the list.
            userError.Add(new TextInputError()); // Adds a TextInputError to the list.
            userError.Add(new FileNotFoundError()); // Adds a FileNotFoundError to the list.
            userError.Add(new PermissionDeniedError()); // Adds a PermissionDeniedError to the list.
            userError.Add(new OutOfMemoryError()); // Adds an OutOfMemoryError to the list.

            // Loop through each error in the list and call the UEMessage() method, which displays an error message.
            foreach (var error in userError)
            {
                Console.WriteLine(error.UEMessage()); // Executes UEMessage() based on the type of each specific error.
            }
        }
    }
}
