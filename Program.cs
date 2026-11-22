
/*******************************************************************
 * Name: Adam Smithhisler
 * Date: November 22, 2026
 * Assignment: SDC320 Week 2 GP - Interfaces
 *
 * Demonstrates interfaces and polymorphism using
 * Dog and Cat objects through the IAnimal interface.
 *******************************************************************/

using System;
using System.Collections.Generic;

public class InterfaceExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine(
            "\nAdam Smithhisler, Week 2 Interfaces GP\n");

        // Create two objects implementing IAnimal.
        Dog dog = new Dog("Buddy", "Playing fetch");
        Cat cat = new Cat("Luna");

        // Both objects can be stored as IAnimal.
        List<IAnimal> animals = new List<IAnimal>();

        animals.Add(dog);
        animals.Add(cat);

        Console.WriteLine("Items in IAnimal List:\n");

        // Process both objects through the interface.
        foreach (IAnimal animal in animals)
        {
            PrintAnimalInfo(animal);
        }
    }

    private static void PrintAnimalInfo(IAnimal animal)
    {
        Console.WriteLine(animal.ToString());

        Console.WriteLine(
            "Animal Sound: " + animal.MakeSound());

        animal.Move("Living Room", "Backyard");

        Console.WriteLine();
    }
}
