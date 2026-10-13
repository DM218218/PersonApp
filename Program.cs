using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;
            var persons = new List<Person>();

            Console.WriteLine("Enter a first name, followed by a space, followed by a last name, " +
                              "\nfollowed by a space, and followed by an age. Confirm with Enter.");
            Console.WriteLine($"Repeat this {lines} times.");

            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var input = Console.ReadLine() ?? throw new NullReferenceException($"Input was null on line {i}");
                    var cmdArgs = input.Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])); 
                    persons.Add(person);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }

            persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
