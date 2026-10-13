using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} is {age} years old.";
        }
    }
}
