
/*******************************************************************
 * Name: Adam Smithhisler
 * Date: November 22, 2026
 * Assignment: SDC320 Week 2 GP - Interfaces
 *
 * Implements the IAnimal interface for a cat.
 * Includes a private name field and formatted output.
 *******************************************************************/

using System;

public class Cat : IAnimal
{
    private string m_name;

    public Cat(string name)
    {
        m_name = name;
    }

    public string GetName()
    {
        return m_name;
    }

    public string MakeSound()
    {
        return "Meow!";
    }

    public void Move(string start, string end)
    {
        Console.WriteLine(
            $"{m_name} walks from {start} to {end}.");
    }

    public override string ToString()
    {
        return string.Format(
            "Class Name (Object Type): {0}\n"
            + "Animal Name: {1}",
            GetType().Name,
            GetName());
    }
}
