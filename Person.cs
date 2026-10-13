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
        private decimal salary;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public decimal Salary { get => salary; set => salary = value; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public void IncreaseSalary(decimal bonus)
        {
            if (age >= 30)
            {
                salary += salary * bonus;
            }
            else
            {
                salary += salary * (bonus / 2);
            }
        }

        public override string ToString()
        {
            if (Program.Exercise == 1)
            {
                return $"{firstName} {lastName} is {age} years old.";
            }
            else if(Program.Exercise == 2)
            {
                return $"{firstName} {lastName} receives {salary:F2} dollars.";
            }
            else
            {
                return $"{firstName} {lastName} is {age} years old.";
            }
        }
    }
}
