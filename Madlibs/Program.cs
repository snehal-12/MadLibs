using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program demonstrates a simple Madlibs game where user enters words in the blank spaces that results in a funny narrrative..
      Author: Snehal Gaikwad...
      */


            // Let the user know that the program is starting:
            Console.WriteLine("MadLibs is about to Start");

            // Give the Mad Lib a title:
            string title = "Crazy Day";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your favorite color:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter any adjective:");
            string adj = Console.ReadLine();
            Console.WriteLine("Enter a word that describes texture:");
            string texture = Console.ReadLine();

            Console.WriteLine("Enter some verb:");
            string action = Console.ReadLine();

            Console.WriteLine("Enter a noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("Enter a thing:");
            string thing = Console.ReadLine();

            Console.WriteLine("Enter any kind of animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter any kind of food:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter any fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter your favorite superhero:");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter any country name:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter your favorite dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter any year:");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {color}. 'It is going to be a {adj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {noun}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {thing}s ruled the world.";
            // Print the story:
            Console.WriteLine(story);
            Console.ReadLine();



            
        }
    }
}
