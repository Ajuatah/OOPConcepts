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
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}
