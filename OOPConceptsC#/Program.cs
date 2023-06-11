using OOPConceptsC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //encapsolution 
            Person person = new Person();
            person.Name = "Andropov Ajebua";
            person.Age = 30;
            person.PrintInfo();


            //Abstraction 
            //Shape shape = new Shape(); : not posible
            //you can not create an instance of abstract class
            Circle circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();


            Animal dog = new Dog("Buddy");
            dog.DisplayInfo();  // Output: Name: Buddy
            dog.MakeSound();    // Output: Dog: Woof woof!

            Console.WriteLine();

            Animal cat = new Cat("Whiskers");
            cat.DisplayInfo();  // Output: Name: Whiskers
            cat.MakeSound();    // Output: Cat: Meow!

            Console.ReadKey();
        }
    }
}
