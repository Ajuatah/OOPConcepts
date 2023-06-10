using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    public abstract  class Shape
    {
        public abstract void  Draw();

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine( "I am drwaing a Rectangle");
        }
    }
}
