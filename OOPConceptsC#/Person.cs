using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    public   class Person
    {
        private string name;
        private int age;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Your Name is {Name} with {Age}");
        }
        
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound(); // Abstract method without implementation

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog: Woof woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat: Meow!");
        }
    }
}
