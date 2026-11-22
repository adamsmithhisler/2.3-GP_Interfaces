
/*******************************************************************
 * Name: Adam Smithhisler
 * Date: November 22, 2026
 * Assignment: SDC320 Week 2 GP - Interfaces
 *
 * Defines the required behavior for classes implementing IAnimal.
 *******************************************************************/

public interface IAnimal
{
    string GetName();

    string MakeSound();

    void Move(string start, string end);
}
