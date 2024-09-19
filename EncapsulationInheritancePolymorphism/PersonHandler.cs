// This code defines a class named 'PersonHandler' which provides methods to manipulate and manage 'Person' objects.
// It allows setting and retrieving individual properties of a 'Person' instance, as well as creating new 'Person' objects.

namespace EncapsulationInheritancePolymorphism
{
    // The 'PersonHandler' class provides utility methods for managing 'Person' objects.
    internal class PersonHandler
    {
        // Sets the age of the given 'Person' instance using the 'Age' property.
        public void SetAge(Person pers, int age)
        {
            pers.Age = age; // Assigns the given age to the 'Person'.
        }

        // Sets the first name of the given 'Person' instance using the 'FirstName' property.
        public void SetFName(Person pers, string fname)
        {
            pers.FirstName = fname; // Assigns the given first name to the 'Person'.
        }

        // Sets the last name of the given 'Person' instance using the 'LastName' property.
        public void SetLName(Person pers, string lname)
        {
            pers.LastName = lname; // Assigns the given last name to the 'Person'.
        }

        // Sets the height of the given 'Person' instance using the 'Height' property.
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height; // Assigns the given height to the 'Person'.
        }

        // Sets the weight of the given 'Person' instance using the 'Weight' property.
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight; // Assigns the given weight to the 'Person'.
        }

        // Retrieves the age of the given 'Person' instance by returning the value of the 'Age' property.
        public int GetAge(Person pers)
        {
            return pers.Age; // Returns the current age of the 'Person'.
        }

        // Retrieves the weight of the given 'Person' instance by returning the value of the 'Weight' property.
        public double GetWeight(Person pers)
        {
            return pers.Weight; // Returns the current weight of the 'Person'.
        }

        // Creates a new 'Person' instance by setting all properties (age, first name, last name, height, and weight).
        public Person CreatePerson(
            int age, // Age of the person
            string fname, // First name of the person
            string lname, // Last name of the person
            double height, // Height of the person
            double weight // Weight of the person
        )
        {
            // Creates a new 'Person' object and sets its properties using the provided values.
            Person per = new Person();

            per.Age = age;
            per.FirstName = fname;
            per.LastName = lname;
            per.Weight = weight;
            per.Height = height;

            // Returns the newly created 'Person' object.
            return per;
        }
    }
}
