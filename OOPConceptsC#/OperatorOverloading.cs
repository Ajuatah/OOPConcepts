using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class OperatorOverloading
    {
    }

    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Overloading the + operator to add two vectors
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Overloading the * operator to scale a vector by a scalar value
        public static Vector operator *(Vector v, int scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        // Overloading the == operator to compare two vectors for equality
        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        // Overloading the != operator to compare two vectors for inequality
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
    }

}
