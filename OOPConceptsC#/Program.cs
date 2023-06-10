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
            LookingAtConstructors myObject = new LookingAtConstructors();

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


            //multiple inheritance through interface

            Rectangel rectang = new Rectangel();
             rectang.Draw();
            rectang.IPrint();
            rectang.DrawFillColor();


            //polymorphism
            Shape1 shape1 = new Shape1();
            shape1.Draw1();       // Output: "Drawing a shape"

            Circle1 circle1 = new Circle1();
            circle.Draw();      // Output: "Drawing a circle"

            Rectangle1 rectangle1 = new Rectangle1();
            rectangle.Draw();   // Output: "Drawing a rectangle"

            Shape1 polymorphicCircle = new Circle1();
            polymorphicCircle.Draw1();   // Output: "Drawing a circle"

            Shape1 polymorphicRectangle = new Rectangle1();
            polymorphicRectangle.Draw1();    // Output: "Drawing a rectangle"


            //contructors 
            // Default Constructor
            constructor obj1 = new constructor();
            Console.WriteLine("Default Constructor - Value: " + obj1.Value);    // Output: 0

            // Parameterized Constructor
            constructor obj2 = new constructor(42);
            Console.WriteLine("Parameterized Constructor - Value: " + obj2.Value);   // Output: 42

            // Copy Constructor
            constructor obj3 = new constructor(obj2);
            Console.WriteLine("Copy Constructor - Value: " + obj3.Value);   // Output: 42

            // Static Constructor
            // Static constructor is called automatically before any instance is created or static member is accessed
            // Output: "Static constructor called"

            // Private Constructor
            // Uncomment the code below to see the private constructor in action
            //constructor obj4 = new constructor("Private constructor called");



            //private constructor and singleton

            // Trying to create an instance using the private constructor will result in a compilation error
            // Singleton singleton = new Singleton();

            // Accessing the single instance using the public static method
            Singleton singleton = Singleton.GetInstance();
            singleton.DoSomething();

            Console.ReadKey();
        }
    }
}
