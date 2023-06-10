using System;

public class Shape1
{
    public virtual void Draw1()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle1 : Shape1
{
    public override void Draw1()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle1 : Shape1
{
    public override void Draw1()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}
