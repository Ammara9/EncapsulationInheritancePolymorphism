// #3.3.13 F: Det nya attributet bör läggas i klassen `Bird`, eftersom den är basen för alla fågelklasser och därmed kan ärvas av alla specifika fågeltyper.

// #3.3.14 F: Om alla djur behöver det nya attributet bör det läggas i basklassen `Animal`, eftersom alla djurklasser ärver från den.

// #3.4.9 F: Det fungerar inte att lägga till en häst i listan av hundar eftersom `Horse` och `Dog` är olika typer och listan är typad specifikt för `Dog`. Du kan endast lägga till objekt av typen `Dog` i den listan.

// #3.4.10 F: Listan måste vara av typen `Animal` för att kunna lagra objekt av alla klasser som ärver från `Animal`.

// #3.4.13 F:
/*Koden skapar en foreach-loop som itererar genom varje objekt i animals-listan.
 * För varje Animal-objekt anropas metoden Stats(), som returnerar en sträng med djurets egenskaper.
 * Eftersom Stats() är en virtuell metod, används den specifika implementationen för varje djurklass,
 * vilket ger rätt attributinformation för varje djurtyp. */

// #3.4.17 F:
/* Det är för att List<Animal> innehåller referenser till objekt av typen Animal,
 * och Animal-klassen har inte definierat metoden GetDogSpecificInfo().
 * Därför måste du typ-casta objektet till Dog för att använda den metoden.*/

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of various animals
            Horse horse = new Horse("Horse", 5, 500, 50);

            // Create instances of different Dog breeds
            Dog dog1 = new Dog("Dog", 3, 25, "Bulldog");
            Dog bullDog = new Dog("Dog", 3, 25, "Bulldog");
            Dog germanShepherd = new("Dog", 3, 25, "Bulldog");

            // Create instances of other animals
            Hedgehog hedgehog = new Hedgehog("Hedgehog", 2, 1.2, 7000);
            Worm worm = new Worm("Worm", 1, 0.01, 50);
            Wolf wolf = new Wolf("Wolf", 4, 40, 10);
            WolfMan wolfMan = new WolfMan("Wolfman", 30, 85, 5, "Yes");
            Pelican pelican = new Pelican("Pelican", 8, 12, "Yes", 50);
            Flemingo flemingo = new Flemingo("Flemingo", 6, 10, "Yes", 12);
            Swan swan = new Swan("Swan", 7, 15, "Yes", 10);

            // Create a list to hold various animals
            List<Animal> animals = new List<Animal>()
            {
                horse,
                dog1,
                bullDog,
                germanShepherd,
                hedgehog,
                worm,
                wolf,
                wolfMan, // WolfMan inherits from Wolf and thus acts as an Animal
                pelican,
                flemingo,
                swan,
            };

            // Iterate through the list of animals and print their properties using the Stats() method
            Console.WriteLine("Animal Stats:");
            foreach (Animal animal in animals)
            {
                if (animal is IPerson person)
                {
                    // Cast the animal to IPerson and call the Talk() method
                    person.Talk();
                }
                // Print the stats of each animal
                Console.WriteLine(animal.Stats());
                Console.Write("Animal sound: ");
                animal.DoSound(); // Print the sound of each animal

                if (animal is Dog dogObj)
                {
                    // Cast the animal to Dog and call the GetDogSpecificInfo() method
                    Console.WriteLine(dogObj.GetDogSpecificInfo());
                }
            }

            // Create a list specifically for Dog objects
            List<Dog> dogs = new List<Dog>() { dog1, bullDog, germanShepherd };

            // Print information about each dog
            Console.WriteLine("\nDog List:");
            foreach (Dog dog in dogs)
            {
                // Print the stats of each dog
                Console.WriteLine(dog.Stats());
                Console.Write("Dog sound: ");
                dog.DoSound(); // Print the sound of each dog
                Console.WriteLine(dog.GetDogSpecificInfo()); // Print specific info for each dog
            }

            // Uncomment the following section to use methods to print animal sounds
            //Console.WriteLine("Animal sounds:");
            //horse.DoSound(); // Neigh
            //dog.DoSound(); // Bark
            //hedgehog.DoSound(); // Snuffle
            //worm.DoSound(); // Wriggle
            //wolf.DoSound(); // Howl
            //pelican.DoSound(); // Chirp
            //flemingo.DoSound(); // Chirp
            //swan.DoSound(); // Chirp

            // Demonstrate WolfMan's abilities
            Console.WriteLine("\nWolfMan abilities:");
            wolfMan.Talk(); // WolfMan talks
            wolfMan.DoSound(); // WolfMan makes a sound

            // Display some properties of the animals
            Console.WriteLine("\nAnimal properties:");
            Console.WriteLine(
                $"Horse Name: {horse.Name}, Age: {horse.Age}, Weight: {horse.Weight}"
            );
            Console.WriteLine($"Dog Name: {dog1.Name}, Age: {dog1.Age}, Weight: {dog1.Weight}");
        }
    }
}
