// This program demonstrates the use of encapsulation, inheritance, and polymorphism concepts by creating and manipulating 'Person' objects.

namespace EncapsulationInheritancePolymorphism
{
    internal class Program
    {
        // Main method: Entry point of the program.
        static void Main(string[] args)
        {
            // Create a new Person instance and set its properties (age, first name, last name, height, and weight).
            Person person = new Person();
            person.Age = 30; // Set age to 30
            person.FirstName = "Ammara"; // Set first name to "Ammara"
            person.LastName = "Shakeel"; // Set last name to "Shakeel"
            person.Height = 169; // Set height to 169 cm
            person.Weight = 65; // Set weight to 65 kg
            Console.WriteLine($"");

            // Create an instance of PersonHandler to manage Person objects.
            PersonHandler handler = new PersonHandler();

            try
            {
                // Create a new 'Person' using the PersonHandler's CreatePerson method.
                Person newPerson = handler.CreatePerson(30, "Sabat", "Olla", 180.5, 75.0);

                // Output the details of the newly created person.
                Console.WriteLine(
                    $"Created Person: {newPerson.FirstName} {newPerson.LastName}, Age: {newPerson.Age}, Height: {newPerson.Height} cm, Weight: {newPerson.Weight} kg"
                );
            }
            catch (ArgumentException ex)
            {
                // Catch and display any validation errors that occur during person creation.
                Console.WriteLine(ex.Message);
            }

            // Create a new 'Person' and 'PersonHandler' for additional operations.
            Person pers = new Person();
            PersonHandler persHandler = new PersonHandler();

            try
            {
                // Set properties of the person using PersonHandler's methods.
                persHandler.SetAge(pers, 30); // Set the person's age to 30 using SetAge method.
                persHandler.SetFName(pers, "Ammara"); // Set the person's first name to "Ammara".
                //persHandler.GetWeight(pers);       // Optionally get the weight of the person.

                // Output the details of the person after setting properties.
                Console.WriteLine($"Person's age: {pers.Age} {pers.FirstName} {pers.Weight}");
            }
            catch (ArgumentException ex)
            {
                // Handle any validation errors during property setting.
                Console.WriteLine(ex.Message);
            }
        }
    }
}
