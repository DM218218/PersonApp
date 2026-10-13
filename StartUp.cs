using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp
{
    internal class StartUp
    {
        internal static void RunBonusProcedure()
        {
            Console.Clear();
            Console.WriteLine("Enter number of people. Confirm with Enter.");
            var input = Console.ReadLine() ?? throw new ArgumentNullException("Input was null for number of lines.");
            var lines = int.Parse(input); 
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"Enter person {i + 1}. First name, last name, age and salary, separated by space. Confirm with Enter.");
                input = Console.ReadLine() ?? throw new ArgumentNullException($"Input was null for person {i}");
                var cmdArgs = input.Split(); 

                if(cmdArgs.Length != 4)
                {
                    throw new FormatException($"{input} is not of valid format.");
                }

                var person = new Person(
                    cmdArgs[0], 
                    cmdArgs[1], 
                    int.Parse(cmdArgs[2]), 
                    decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            Console.WriteLine("Enter bonus percentage. Confirm with Enter.");
            input = Console.ReadLine() ?? throw new ArgumentNullException("Input was null for bonus.");
            var bonus = decimal.Parse(input); 
            persons.ForEach(p => p.IncreaseSalary(bonus)); 
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
