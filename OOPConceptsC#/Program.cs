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


            //access modifiers
            MyClass myObject = new MyClass();

            myObject.publicField = 1;                   // Accessible
                                                        // myObject.privateField = 2;              // Not accessible (private)
                                                        // myObject.protectedField = 3;            // Not accessible (not inherited)
            myObject.internalField = 4;                 // Accessible
            myObject.protectedInternalField = 5;        // Accessible

            myObject.PublicMethod();                    // Accessible
                                                        // myObject.PrivateMethod();                // Not accessible (private)
                                                        // myObject.ProtectedMethod();              // Not accessible (not inherited)
            myObject.InternalMethod();                   // Accessible
            myObject.ProtectedInternalMethod();          // Accessible

            DerivedClass derivedObject = new DerivedClass();
            derivedObject.AccessBaseClassMembers();

            Console.ReadKey();
        }
    }
}
