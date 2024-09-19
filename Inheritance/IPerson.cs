// This code defines an interface 'IPerson' in the 'Inheritance' namespace.
// An interface in C# specifies a contract that any implementing class must follow.

namespace Inheritance
{
    // The 'IPerson' interface declares a method signature for 'Talk'.
    // Any class that implements 'IPerson' must provide its own implementation of the 'Talk' method.
    internal interface IPerson
    {
        // Method declaration for 'Talk'.
        // This method will represent a person's ability to talk, with no implementation provided here.
        void Talk();
    }
}
