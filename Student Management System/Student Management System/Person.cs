using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    internal class Person
    {
        private string name;
        protected int age;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Name mustn't be empty or null");
                }

                name = value;
            }
        }
        public int Age
        {
            get {
                return age;
                }
            set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("The age must be positive");
                }
                age = value;
            } 
        }
        public Person()
        {
            name = "Unknown";
            age = 1;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(Person person)
        {
            name = person.name;
            age = person.age;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }
}
