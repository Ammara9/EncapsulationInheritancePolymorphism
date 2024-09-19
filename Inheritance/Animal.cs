// The code defines a hierarchy of classes related to animals, demonstrating inheritance, polymorphism, and abstraction in C#.

namespace Inheritance
{
    // Abstract class 'Animal' serves as the base class for all animal types.
    // It defines properties and methods that can be inherited and overridden by derived classes.
    public abstract class Animal
    {
        // Properties to store the name, age, and weight of the animal.
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public double Weight { get; set; }

        // Abstract method 'DoSound', which must be implemented by derived classes.
        public abstract void DoSound();

        // Virtual method 'Stats', which returns basic information about the animal.
        // Derived classes can override this method to extend or modify the information.
        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

        // Constructor for initializing the Animal class with name, age, and weight.
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

    // Derived class 'Horse' inherits from 'Animal' and adds a specific property 'MaxSpeed'.
    public class Horse : Animal
    {
        public int MaxSpeed { get; set; }

        // Constructor to initialize a Horse object with its specific properties.
        public Horse(string name, int age, double weight, int maxSpeed)
            : base(name, age, weight)
        {
            MaxSpeed = maxSpeed;
        }

        // Override the 'Stats' method to include the horse's max speed.
        public override string Stats()
        {
            return base.Stats() + $",MaxSpeed of Horse is: {MaxSpeed} km/h";
        }

        // Implement the 'DoSound' method to represent the sound of a horse.
        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }

    // Derived class 'Dog' adds a specific property 'Breed'.
    public class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor to initialize a Dog object with its specific properties.
        public Dog(string name, int age, double weight, string breed)
            : base(name, age, weight)
        {
            Breed = breed;
        }

        // Override the 'Stats' method to include the dog's breed.
        public override string Stats()
        {
            return base.Stats() + $", Dog Breed is: {Breed}";
        }

        // Implement the 'DoSound' method to represent the sound of a dog.
        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }

        // Additional method specific to the Dog class.
        public string GetDogSpecificInfo()
        {
            return $"This is a special method for dogs. Breed: {Breed}";
        }
    }

    // Derived class 'Hedgehog' adds a specific property 'NumberOfSpikes'.
    public class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        // Constructor to initialize a Hedgehog object.
        public Hedgehog(string name, int age, double weight, int numberOfSpikes)
            : base(name, age, weight)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        // Override the 'Stats' method to include the number of spikes.
        public override string Stats()
        {
            return base.Stats() + $", NumberOfSpikes in Hedgehog:{NumberOfSpikes}";
        }

        // Implement the 'DoSound' method to represent the sound of a hedgehog.
        public override void DoSound()
        {
            Console.WriteLine("Snuffle");
        }
    }

    // Derived class 'Worm' adds a specific property 'Length'.
    public class Worm : Animal
    {
        public int Length { get; set; }

        // Constructor to initialize a Worm object.
        public Worm(string name, int age, double weight, int length)
            : base(name, age, weight)
        {
            Length = length;
        }

        // Override the 'Stats' method to include the worm's length.
        public override string Stats()
        {
            return base.Stats() + $", Worm Length is: {Length} cm.";
        }

        // Implement the 'DoSound' method to represent the sound of a worm.
        public override void DoSound()
        {
            Console.WriteLine("Wriggle");
        }
    }

    // Derived class 'Wolf' adds a specific property 'PackSize'.
    public class Wolf : Animal
    {
        public int PackSize { get; set; }

        // Constructor to initialize a Wolf object.
        public Wolf(string name, int age, double weight, int packSize)
            : base(name, age, weight)
        {
            PackSize = packSize;
        }

        // Override the 'Stats' method to include the pack size.
        public override string Stats()
        {
            return base.Stats() + $", PackSize of a Wolf is: {PackSize}";
        }

        // Implement the 'DoSound' method to represent the sound of a wolf.
        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }
    }

    // Class 'WolfMan' inherits from 'Wolf' and implements the 'IPerson' interface.
    public class WolfMan : Wolf, IPerson
    {
        public string Walk { get; set; }

        // Constructor to initialize a WolfMan object.
        public WolfMan(string name, int age, double weight, int packSize, string walk)
            : base(name, age, weight, packSize)
        {
            Walk = walk;
        }

        // Override the 'Stats' method to include the WolfMan's ability to walk.
        public override string Stats()
        {
            return base.Stats() + $", Can Wolfman Walk?: {Walk}";
        }

        // Implementation of the 'Talk' method from the IPerson interface.
        public void Talk()
        {
            Console.WriteLine("Talking...");
        }
    }

    // Base class 'Bird' adds a specific property 'Fly' and serves as the base for different bird types.
    public class Bird : Animal
    {
        public string Fly { get; set; }

        // Constructor to initialize a Bird object.
        public Bird(string name, int age, double weight, string fly)
            : base(name, age, weight)
        {
            Fly = fly;
        }

        // Override the 'Stats' method to include the bird's ability to fly.
        public override string Stats()
        {
            return base.Stats() + $", Is {Name} Flying?: {Fly}";
        }

        // Implement the 'DoSound' method to represent the sound of a bird.
        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }
    }

    // Derived class 'Pelican' adds a specific property 'BeakLength'.
    public class Pelican : Bird
    {
        public int BeakLength { get; set; }

        // Constructor to initialize a Pelican object.
        public Pelican(string name, int age, double weight, string fly, int beakLength)
            : base(name, age, weight, fly)
        {
            BeakLength = beakLength;
        }

        // Override the 'Stats' method to include the beak length.
        public override string Stats()
        {
            return base.Stats() + $", BeakLength: {BeakLength} cm";
        }

        // Implement the 'DoSound' method to represent the sound of a pelican.
        public override void DoSound()
        {
            Console.WriteLine("Chirp.");
        }
    }

    // Derived class 'Flemingo' adds a specific property 'BeakLength'.
    public class Flemingo : Bird
    {
        public int BeakLength { get; set; }

        // Constructor to initialize a Flemingo object.
        public Flemingo(string name, int age, double weight, string fly, int beakLength)
            : base(name, age, weight, fly)
        {
            BeakLength = beakLength;
        }

        // Override the 'Stats' method to include the beak length.
        public override string Stats()
        {
            return base.Stats() + $", BeakLength: {BeakLength} cm";
        }

        // Implement the 'DoSound' method to represent the sound of a flemingo.
        public override void DoSound()
        {
            Console.WriteLine("Chirp.");
        }
    }

    // Derived class 'Swan' adds a specific property 'BeakLength'.
    public class Swan : Bird
    {
        public int BeakLength { get; set; }

        // Constructor to initialize a Swan object.
        public Swan(string name, int age, double weight, string fly, int beakLength)
            : base(name, age, weight, fly)
        {
            BeakLength = beakLength;
        }

        // Override the 'Stats' method to include the beak length.
        public override string Stats()
        {
            return base.Stats() + $", BeakLength: {BeakLength}  cm";
        }

        // Implement the 'DoSound' method to represent the sound of a swan.
        public override void DoSound()
        {
            Console.WriteLine("Chirp.");
        }
    }
}
