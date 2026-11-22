
/*******************************************************************
 * Name: Adam Smithhisler
 * Date: November 22, 2026
 * Assignment: SDC320 Week 2 GP - Interfaces
 *
 * Implements the IAnimal interface for a dog.
 * Includes a private name field and a favorite activity.
 *******************************************************************/

using System;

public class Dog : IAnimal
{
    private string m_name;

    public string FavoriteActivity { get; set; }

    public Dog(string name, string favoriteActivity)
    {
        m_name = name;
        FavoriteActivity = favoriteActivity;
    }

    public string GetName()
    {
        return m_name;
    }

    public string MakeSound()
    {
        return "Woof!";
    }

    public void Move(string start, string end)
    {
        Console.WriteLine(
            $"{m_name} runs from {start} to {end}.");
    }

    public override string ToString()
    {
        return string.Format(
            "Class Name (Object Type): {0}\n"
            + "Animal Name: {1}\n"
            + "Favorite Activity: {2}",
            GetType().Name,
            GetName(),
            FavoriteActivity);
    }
}
