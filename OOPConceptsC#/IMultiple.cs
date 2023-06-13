using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConceptsC_
{
    public  interface IMultiple
    {
        void IPrint();
    }

    public interface IShape
    {
        void Draw();
    }
     public interface IFllColor
    {
        void DrawFillColor();
    }

    public class BaseClass
    {
        //private string Name;
        public string Name;

        public void DrawName()
        {
            Console.WriteLine(  "Drawing from base class");
        }
    }

    public class DerivedClass :BaseClass
    {
        public void DeriveMethod()
        {
            Name = "Andropov";
            DrawName();
        }
    }

    public class Rectangel:IMultiple, IShape, IFllColor
    {
        public void IPrint()
        {
            Console.WriteLine(  "i am printing I Multiple");
        }

        public void Draw()
        {
            Console.WriteLine(  "I am drawing from shape");
        }

        public void DrawFillColor()
        {
            Console.WriteLine("Drwaing fill color");
        }
    }
}
