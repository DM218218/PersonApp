using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonApp
{
    internal class Program
    {
        public static int Exercise { get; set; }

        static void Main(string[] args)
        {
            if(args.Length == 1 && args[0] == "-skip1")
            {
                goto Skip1;
            }

            Program.Exercise = 1;
            var lines = 5;
            var persons = new List<Person>();

            Console.WriteLine("Enter a first name, followed by a space, followed by a last name, " +
                              "\nfollowed by a space, and followed by an age. Confirm with Enter.");
            Console.WriteLine($"Repeat this {lines} times.");

            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var input = Console.ReadLine() ?? throw new ArgumentNullException($"Input was null for person {i}");
                    var cmdArgs = input.Split();

                    if (cmdArgs.Length != 3)
                    {
                        throw new FormatException($"{input} is not of valid format.");
                    }

                    try
                    {
                        var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                        persons.Add(person);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"An error has occured: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }

            persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        Skip1:
            Program.Exercise = 2;

            try 
            { 
                StartUp.RunBonusProcedure();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }
        }
    }
}
