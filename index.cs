using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program: Adlibe Game
      Author: Yohanes
      */


      // Let the user know that the program is starting:
Console.WriteLine("READY");

      // Give the Mad Lib a title:
      string title = "Funny Stories";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("BEGIN");

Console.WriteLine("Enter a name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter an adjective: ");
string adjOne = Console.ReadLine();

Console.WriteLine("Enter an adjective: ");
string adjTwo = Console.ReadLine();

Console.WriteLine("Enter an animal: ");
string animal = Console.ReadLine();

Console.WriteLine("Enter an adjective: ");
string adjThree = Console.ReadLine();

Console.WriteLine("Choose a verb: ");
string verb = Console.ReadLine();

Console.WriteLine("Choose a noun: ");
string nounOne = Console.ReadLine();

Console.WriteLine("Choose a noun: ");
string nounTwo = Console.ReadLine();

Console.WriteLine("Choose a year: ");
string year = Console.ReadLine();

Console.WriteLine("Choose a food: ");
string food = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {nounTwo}s were protesting to keep  in stores. They began to {verb} to the rhythm of the {food}, which made all the {nounOne}s very {adjThree}. Concerned, {nounTwo} texted {nounTwo}, who flew {adjOne} to {nounOne} and dropped {food} in a puddle of frozen {food}. {name} woke up in the year {year}, in a world where {animal}s ruled the world.";


      // Print the story:
Console.WriteLine(story);
    }
  }
}
