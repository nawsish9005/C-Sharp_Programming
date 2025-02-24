using System;

abstract class Animal
{
    public abstract void MakeSound();  // Abstract method (no implementation)
    public void Sleep() // Concrete method (has implementation)
    {
        Console.WriteLine("Sleeping...");
    }
}
class Dog : Animal
{
    public override void MakeSound() // Implementing the abstract method
    {
        Console.WriteLine("Woof! Woof!");
    }
}
class Program
{
    static void Main()
    {
        Animal myDog = new Dog();  // Cannot create instance of Animal, but Dog can
        myDog.MakeSound();  // Output: Woof! Woof!
        myDog.Sleep();      // Output: Sleeping...
    }
}
