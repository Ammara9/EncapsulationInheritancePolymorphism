# C# Object-Oriented Programming Example

This solution demonstrates key concepts of object-oriented programming in C#, including encapsulation, inheritance, and polymorphism. It consists of three separate projects, each focusing on a different aspect of these concepts.

## Projects Overview

### 1. **EncapsulationInheritancePolymorphism**

This project showcases the use of encapsulation, inheritance, and polymorphism through the creation and manipulation of `Person` objects.

- **Main Functionality**:
  - Creates a `Person` instance and sets its properties.
  - Uses `PersonHandler` to manage `Person` objects, including creating new persons and modifying existing ones.
  - Demonstrates how to handle exceptions when setting properties and creating new persons.

- **Key Components**:
  - `Person` class: Encapsulates personal information such as age, first name, last name, height, and weight.
  - `PersonHandler` class: Provides methods for creating and modifying `Person` objects.
  - `Program` class: Contains the `Main` method to execute the demonstration of the `Person` class functionalities.

### 2. **Inheritance**

This project illustrates inheritance by creating various animal classes that derive from a base `Animal` class.

- **Main Functionality**:
  - Defines a base `Animal` class with properties and methods.
  - Implements derived classes like `Horse`, `Dog`, `Hedgehog`, `Worm`, `Wolf`, `WolfMan`, `Pelican`, `Flemingo`, and `Swan`, each with specific attributes and behaviors.
  - Demonstrates polymorphism by using a list of `Animal` objects and invoking methods like `Stats()` and `DoSound()`.

- **Key Components**:
  - `Animal` class: Abstract class with properties and abstract methods.
  - Derived animal classes: Implement specific details and behaviors for each type of animal.
  - `Program` class: Creates instances of various animal types, manages them using a list, and demonstrates method overriding and type casting.

### 3. **Polymorphism**

This project demonstrates polymorphism by using a list of different types of error objects, all derived from a common base class `UserError`.

- **Main Functionality**:
  - Defines a `UserError` base class with an abstract method `UEMessage()`.
  - Implements various derived error classes like `NumericInputError`, `TextInputError`, `FileNotFoundError`, `PermissionDeniedError`, and `OutOfMemoryError`.
  - Demonstrates polymorphism by iterating over a list of `UserError` objects and calling the `UEMessage()` method on each.

- **Key Components**:
  - `UserError` class: Abstract class representing different error types.
  - Derived error classes: Each class provides a specific implementation of the `UEMessage()` method.
  - `Program` class: Creates a list of error objects and demonstrates polymorphic behavior by invoking the `UEMessage()` method on each instance.

## Requirements

- .NET Core 3.1 or later
- A C# development environment (e.g., Visual Studio or Visual Studio Code)

## How to Run

1. Clone the repository or download the source code.
2. Open the solution in your preferred C# IDE.
3. Build and run each project to observe the different functionalities.
