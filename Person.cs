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

        public string FirstName 
        {
            get
            {
                return firstName;
            }

            set
            { 
                if(value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                firstName = value; 
            } 
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollars!");
                }

                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal bonus)
        {
            if(bonus >= 1.0m)
            {
                bonus = bonus / 100.0m;
            }

            if (age >= 30)
            {
                salary += salary * bonus;
            }
            else
            {
                salary += salary * (bonus / 2.0m);
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
